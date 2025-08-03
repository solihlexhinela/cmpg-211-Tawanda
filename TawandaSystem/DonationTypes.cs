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
using System.Xml.Linq;

namespace TawandaSystem
{
    public partial class DonationTypes : Form
    {
        public DonationTypes()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        string connectionString = (@"Data Source=SOLS\SQLEXPRESS;Initial Catalog=TAWANDA;Integrated Security=True;");
        
        SqlCommand comm;
        SqlDataAdapter adp;
        

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tpgDonationTDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                
                conn = new SqlConnection(connectionString);
                conn.Open();
                String donationType = cmbDonationTA.SelectedItem.ToString();

                if (donationType == " " && txtDonationDescr.Text == " ")
                {
                    MessageBox.Show("Please enter all required fields");
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(donationType))
                    {
                        MessageBox.Show("Please enter the Donation Type");
                    }
                    else if (string.IsNullOrWhiteSpace(txtDonationDescr.Text))
                    {
                        MessageBox.Show("Please enter the Description of the donation type");
                    }
                    else
                    {
                        string Name = donationType;
                        string Description = txtDonationDescr.Text;
                        string query = ($"INSERT INTO DonationType(Name, Decsription) VALUES ('{donationType}', '{txtDonationDescr.Text}'");


                        comm = new SqlCommand(query, conn);
                        adp = new SqlDataAdapter();

                        adp.InsertCommand = comm;
                        adp.InsertCommand.ExecuteNonQuery();

                        MessageBox.Show("Successfully submitted");
                    }




                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           
            txtDonationDescr.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AccessControl accessControl = new AccessControl();
            accessControl.ShowDialog();
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string donationType = cbxDonationType.SelectedItem.ToString();
                string donationDescription = txtDonationDescr.Text;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("UPDATE DonationType SET DonationDescri = @donationDescription WHERE cbxDonationType = @donationType", conn))
                    {
                        command.Parameters.AddWithValue("@ DonationT_ID", donationType);
                        command.Parameters.AddWithValue("@ DonationDescription", donationDescription);

                        command.ExecuteNonQuery();
                    }
                }

                lstUpdatedRecord.Items.Clear();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("SELECT DonationT,DonationDescription FROM DonationType", conn);
                    
                    SqlDataReader reader = command.ExecuteReader();
                    while(reader.Read())
                    {
                        lstUpdatedRecord.Items.Add(reader["donationType"] + ":" + reader["donationDescription"]);
                    }
                }

                MessageBox.Show("Data added successfully");
               
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error!" + ex.Message);
            }
        }

        private void btnClearUp_Click(object sender, EventArgs e)
        {
            cbxDonationType.SelectedIndex = -1;
            txtDonationDescri.Clear();
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            AccessControl accessControl = new AccessControl();
            accessControl.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn;
                string donationType = txtDonationTDel.Text;

                if (donationType != "")
                {
                    string connectionString = (@"Data Source=SOLS\SQLEXPRESS;Initial Catalog=TAWANDA;Integrated Security=True;");
                    conn = new SqlConnection(connectionString);
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand("SELECT * FROM DonationType WHERE donationType LIKE @DonationType", conn);
                        command.Parameters.AddWithValue("@ DonationType", "%" + donationType + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dgvDeleteRecord.DataSource = table;
                    }

                }
                else
                {
                    MessageBox.Show("Please enter Donation Type");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn;

                string donationType = txtDonationTDel.Text;

                if (donationType != "")
                {
                    string connectionString = @"Data Source=SOLS\\SQLEXPRESS;Initial Catalog=TAWANDA;Integrated Security=True;";
                    conn = new SqlConnection(connectionString);
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand("DELETE FROM DonationType WHERE donationType LIKE @DonationType", conn);
                        command.Parameters.AddWithValue("@ DonationType", donationType);
                        command.ExecuteNonQuery();
                    }

                }
                else
                {
                    MessageBox.Show("Please enter Donation Type");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void btnClearDel_Click(object sender, EventArgs e)
        {
            txtDonationTDel.Clear();
        }

        private void btnBackDel_Click(object sender, EventArgs e)
        {
            AccessControl accessControl = new AccessControl();
            accessControl.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
               Application.Exit();
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error " +  ex.Message);
            }
        }

        private void rbtnDisplayAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDisplayAll.Checked)
            {
                SqlConnection conn;
                string connectionString = (@"Data Source=SOLS\SQLEXPRESS;Initial Catalog=TAWANDA;Integrated Security=True;");
                
                try
                {
                    conn = new SqlConnection(connectionString);
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand("SELECT * FROM DonationType", conn);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dgvDisplay.DataSource = table;

                        conn.Close();
                    }
                }
                catch( Exception ex )
                {
                    MessageBox.Show("Error " + ex.Message);
                }
                
            }
            if(rbtMonetary.Checked)
            {
                try
                {
                    conn = new SqlConnection(connectionString);
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand("SELECT * FROM DonationType WHERE Decsription = 'Money' ", conn);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dgvDisplay.DataSource = table;

                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }
            if(rbtnClothes.Checked)
            {
                try
                {
                    conn = new SqlConnection(connectionString);
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand("SELECT * FROM DonationType WHERE Decsription = 'Electronics'", conn);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dgvDisplay.DataSource = table;

                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }

        }

        private void DonationTypes_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand comm = new SqlCommand("SELECT DISTINCT Name FROM DonationType", conn);
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    cmbDonationTA.Items.Add(reader["Name"].ToString());
                }
                reader.Close();
                conn.Close();


            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
