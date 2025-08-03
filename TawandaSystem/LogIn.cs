using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TawandaSystem
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        SqlConnection conn = new SqlConnection(@"Data Source=SOLS\SQLEXPRESS;Initial Catalog=TAWANDA;Integrated Security=True;");

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item from the ComboBox before proceeding.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                MessageBox.Show("Access granted");
            }

            string username, password;

            username = txtUser.Text;
            password = txtPassword.Text;

            try
            {
                string querry = "SELECT * FROM Login WHERE username = '" + txtUser.Text+"'AND passwords = '" + txtPassword.Text+"'";
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    username = txtUser.Text;
                    password = txtPassword.Text;

                    //Load access form
                    AccessControl form2 = new AccessControl();
                    form2.Show();
                    this.Hide();
                    
                }
                else 
                {
                    MessageBox.Show("Invalid login details");
                    txtUser.Clear();
                    txtPassword.Clear();

                    txtUser.Focus();

                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }
    }
}
        
    


        
            
    

