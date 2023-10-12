using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBookSaitOrhan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void getRecords()
        {
            string connString = ConfigurationManager.ConnectionStrings["SqlConn"].ConnectionString;
            SqlConnection sqlConn = new SqlConnection(connString);

            SqlCommand sqlCommand = new SqlCommand("Select * From PhoneBook", sqlConn);

            try
            {
                sqlConn.Open();
                SqlDataReader read = sqlCommand.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (read.Read())
                {
                    dataGridView1.Rows.Add(read.GetInt32(0), read.GetString(1), read.GetString(2), read.GetString(3));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Can't get records", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConn.State != ConnectionState.Closed)
                {
                    sqlConn.Close();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getRecords();
        }

        private void addRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRecord addRecord = new AddRecord();
            addRecord.ShowDialog();
            getRecords();
        }

        private void deleteSelectedRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int result = -1;

            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            DialogResult dialogResult = MessageBox.Show("The selected record will be deleted." + Environment.NewLine + "Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult != DialogResult.Yes)
            {
                return;
            }   

            object value = dataGridView1.SelectedRows[0].Cells[0].Value;
            int id = (int)value;

            string connString = ConfigurationManager.ConnectionStrings["SqlConn"].ConnectionString;
            SqlConnection sqlConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand("Delete PhoneBook Where Id = @id", sqlConn);
            sqlCommand.Parameters.AddWithValue("@id", id);

            try
            {
                sqlConn.Open();
                result = sqlCommand.ExecuteNonQuery();
                MessageBox.Show(result > 0 ? "Deleted" : "Not Deleted", result > 0 ? "Info" : "Error", MessageBoxButtons.OK, result > 0 ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                
            }
            finally
            {
                sqlConn.Close();
            }
            if (result > 0)
            {
                getRecords();
            }
        }

        private void updateSelectedRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int result = -1;

            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            object value = dataGridView1.SelectedRows[0].Cells[0].Value;
            int id = (int)value;

            AddRecord addRecord = new AddRecord(id);
            addRecord.ShowDialog();
            getRecords();
        }
    }
}
