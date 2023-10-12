using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace PhoneBookSaitOrhan
{
    public partial class AddRecord : Form
    {
        private int _Id;
        private bool _forUpdate;
        public AddRecord()
        {
            InitializeComponent();
        }
        public AddRecord(int id)
        {
            InitializeComponent();
            _Id = id;
            _forUpdate = true;

            string connString = ConfigurationManager.ConnectionStrings["SqlConn"].ConnectionString;
            SqlConnection sqlConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand("Select top 1 * From PhoneBook where ID = @id", sqlConn);
            sqlCommand.Parameters.AddWithValue("@id", _Id);

            try
            {
                sqlConn.Open();
                SqlDataReader read = sqlCommand.ExecuteReader();
                while (read.Read())
                {
                    tbNameSurname.Text = read.GetString(1);
                    mtbPhone.Text = read.GetString(3);
                    tbEmail.Text = read.GetString(2);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Not updated!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConn.State != ConnectionState.Closed)
                {
                    sqlConn.Close();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int result = -1;
            string connString = ConfigurationManager.ConnectionStrings["SqlConn"].ConnectionString;

            SqlConnection sqlConn = new SqlConnection(connString);
            SqlCommand sqlCommand;
            if (_forUpdate)
            {
                sqlCommand = new SqlCommand("Update PhoneBook set NameSurname = @n, Email = @e, Phone = @p where ID = @id", sqlConn);
                sqlCommand.Parameters.AddWithValue("@id", _Id);
            }
            else
            {
                sqlCommand = new SqlCommand("Insert Into PhoneBook Values (@n, @e, @p)", sqlConn);
            }

            sqlCommand.Parameters.AddWithValue("@n", tbNameSurname.Text);
            sqlCommand.Parameters.AddWithValue("@e", tbEmail.Text);
            sqlCommand.Parameters.AddWithValue("@p", mtbPhone.Text);

            try
            {
                sqlConn.Open();
                result = sqlCommand.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConn.State != ConnectionState.Closed)
                {
                    sqlConn.Close();
                }
            }
            if (result > 0)
            {
                MessageBox.Show("Done", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
