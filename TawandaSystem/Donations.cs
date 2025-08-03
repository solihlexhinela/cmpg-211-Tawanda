using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace TawandaSystem
{
    public partial class Donations : Form
    {
        public Donations()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        string connectionString = @"Data Source=SOLS\SQLEXPRESS;Initial Catalog=TAWANDA;Integrated Security=True;";

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (rbtnDisplayAll.Checked)
            {
                try
                {
                    conn = new SqlConnection(connectionString);
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand("SELECT * FROM Donation_tbl", conn);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dgvReceived.DataSource = table;

                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }


            }
            if(rbtnLessThan.Checked)
            {
                try
                {
                    conn = new SqlConnection(connectionString);
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand("SELECT * FROM Donation_tbl WHERE Datetime < '2017-12-29'", conn);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dgvReceived.DataSource = table;

                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }
            if(rbtnPresent.Checked)
            {
                try
                {
                    conn = new SqlConnection(connectionString);
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand("SELECT * FROM Donation_tbl WHERE Datetime > '2018-12-29'", conn);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dgvReceived.DataSource = table;

                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtSponsorLName.Clear();
            txtSponsorName.Clear();
            txtEmailAddress.Clear();
            txtPhoneNumber.Clear();
            // txtDescription.Clear();
            numAmount.Value = 0;
            lstOutput.Items.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccessControl access = new AccessControl();
            access.Show();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                String sponsorLName = txtSponsorLName.Text;
                String sponsorName = txtSponsorName.Text;
                String emailAdress = txtEmailAddress.Text;
                String phoneNum = txtPhoneNumber.Text;
                //String description = txtDescription.Text;
                int amount = int.Parse(numAmount.Text);
                // String dType = comboBox1.SelectedItem.ToString();
                DateTime dateReceived = dateTimePickerDreceived.Value;
                String quantity = txtQTYA.Text;
                SqlCommand comm = new SqlCommand();
                string _connectionString = @"Data Source=SOLS\SQLEXPRESS;Initial Catalog=TAWANDA;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    if (comboBoxDonationType.Text != " ")
                    {
                        if (!comboBoxDonationType.Items.Contains(comboBoxDonationType.Text))
                        {
                            DialogResult result = MessageBox.Show("Donation type not found. Add as a new type?", "confirm", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                String typeQuery = "INSERT INTO DonationType(Name) VALUES (@comboBoxDonationType.Text) ";
                                comm = new SqlCommand(typeQuery, conn);
                                comm.Parameters.AddWithValue("@Name", comboBoxDonationType.Text);
                                
                                comm.ExecuteNonQuery();
                                

                            }
                        }
                    }
                    String query = "INSERT INTO Donation_tbl(Datetime,Amount,Quantity) VALUES(@dateReceived,@amount,@quantity)";
                    query = "INSERT INTO Sponsor (Sponsor_LName,Sponsor_FName, Sponsor_EmailAdd,Sponsor_PhoneNo) VALUES(@sponsorLName,@sponsorName,@emailAdress,@phoneNum)";
                     comm = new SqlCommand(query, conn);
                    comm.Parameters.AddWithValue("@Datetime", dateReceived);
                    comm.Parameters.AddWithValue("@Amount", amount);
                    comm.Parameters.AddWithValue("@Quantity", quantity);
                    comm.Parameters.AddWithValue("@Sponsor_LName", sponsorLName);
                    comm.Parameters.AddWithValue("@Sponsor_FName", sponsorName);
                    comm.Parameters.AddWithValue("@Sponsor_EmailAdd", emailAdress);
                    comm.Parameters.AddWithValue("@Sponsor_PhoneNo", phoneNum);
                    comm.ExecuteNonQuery();

                    conn.Close();
                    lstOutput.Items.Clear();
                    SqlCommand command = new SqlCommand("SELECT Sponsor_LName,Sponsor_LName,Sponsor_EmailAdd , Sponsor_PhoneNo FROM Donation_tbl ", conn);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        lstOutput.Items.Add(reader["SponsorTBL"].ToString());
                    }
                }
                
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccessControl access = new AccessControl();
            access.Show();
        }

        private void btnClearUp_Click(object sender, EventArgs e)
        {
            // comboBox1.Items.Clear();
            txtDescriptionUp.Clear();
            txtEmailAddressUp.Clear();
            txtPhoneNum.Clear();
            txtLNameUp.Clear();
            txtNameUp.Clear();
            numAmountUp.Value = 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                String sponsorLName = txtSponsorLName.Text;
                String sponsorName = txtSponsorName.Text;
                String emailAdress = txtEmailAddress.Text;
                String phoneNum = txtPhoneNumber.Text;
                String ID = comboBoxID.SelectedItem.ToString();
                // String description = txtDescription.Text;
                //String donationT = comboBox1.SelectedItem.ToString();
                decimal amount = numAmountUp.Value;
                string _connectionString = @"Data Source=SOLS\SQLEXPRESS;Initial Catalog=TAWANDA;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    if (sponsorLName == null && emailAdress == null && phoneNum == null && sponsorName == null)
                    {
                        MessageBox.Show("Please fill all informaion");
                    }
                    conn.Open();
                    String query = "UPDATE SponsorTBL SET Sponsor_Lname= 'sponsorLName',Sponsor_FName='sponsorName',Sponsor_EmailAdd='emailAddress',Sponsor_PhoneNo='phoneNum'  WHERE Sponsor_ID = @ID";

                    SqlCommand comm = new SqlCommand(query, conn);
                    comm.Parameters.AddWithValue("@Sponsor_Lname", sponsorLName);
                    comm.Parameters.AddWithValue("@Sponsor_FName", sponsorName);
                    comm.Parameters.AddWithValue("@Sponsor_EmailAdd", emailAdress);
                    comm.Parameters.AddWithValue("@Sponsor_PhoneNo", phoneNum);



                    int rowsAffected = comm.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        lstUpdatedRecord.Items.Clear();

                        SqlCommand selectedCommand = new SqlCommand("SELECT*FROM SponsorTBL ", conn);
                        SqlDataReader reader = selectedCommand.ExecuteReader();
                        while (reader.Read())
                        {
                            lstUpdatedRecord.Items.Add(reader["SponsorTBL"].ToString());
                        }
                        MessageBox.Show("Data updated successfully!");

                    }
                    else
                    {
                        MessageBox.Show("No data updated");
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBackDel_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccessControl access = new AccessControl();
            access.Show();
        }

        private void btnClearDel_Click(object sender, EventArgs e)
        {

            txtLNameDel.Clear();
            txtNameDel.Clear();
            comboBox1.Items.Clear();
            //txtDescriptionDel.Clear();
            dgvDeleteRecord.DataSource = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String descriptiondl = comboBox1.SelectedItem.ToString();

                string _connectionString = @"Data Source=SOLS\SQLEXPRESS;Initial Catalog=TAWANDA;Integrated Security=True;";


                using (SqlConnection conn = new SqlConnection(_connectionString))
                {

                    DataGridViewRow selectedRow = dgvDeleteRecord.SelectedRows[0];
                    DialogResult result = MessageBox.Show("Are you sure you want to delete " + selectedRow.Cells[descriptiondl].Value.ToString() + "?", "Confirm deletion", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        if (descriptiondl == "Amount")
                        {
                            string displayedData = selectedRow.Cells["Amount"].Value.ToString();
                            conn.Open();
                            SqlCommand comm = new SqlCommand("DELETE FROM Donation WHERE Amount= @descriptiondl", conn);
                            comm.Parameters.AddWithValue("@Amount", descriptiondl);

                            comm.ExecuteNonQuery();
                            MessageBox.Show("Data deleted successfully");
                        }
                        else if (descriptiondl == "Quantity")
                        {
                            string displayedData = selectedRow.Cells["Quantity"].Value.ToString();
                            conn.Open();
                            SqlCommand comm = new SqlCommand("DELETE FROM Donation WHERE Quantity= @descriptiondl", conn);
                            comm.Parameters.AddWithValue("@Quantity", descriptiondl);

                            comm.ExecuteNonQuery();
                            MessageBox.Show("Data deleted successfully");
                        }


                    }



                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                String descriptiondl = comboBox1.SelectedItem.ToString();

                string _connectionString =  @"Data Source=SOLS\SQLEXPRESS;Initial Catalog=TAWANDA;Integrated Security=True;";
                if (descriptiondl == "Quantity")
                {
                    using (SqlConnection conn = new SqlConnection(_connectionString))
                    {
                        conn.Open();
                        SqlCommand comm = new SqlCommand("SELECT * FROM Donation_tbl WHERE Quantity = @descriptiondl", conn);
                        comm.Parameters.AddWithValue("@Quantity", descriptiondl);


                        SqlDataAdapter adpt = new SqlDataAdapter(comm);
                        DataTable dt = new DataTable();
                        adpt.Fill(dt);
                        dgvDeleteRecord.DataSource = dt;
                    }
                }
                else if (descriptiondl == "Amount")
                {
                    using (SqlConnection conn = new SqlConnection(_connectionString))
                    {
                        conn.Open();
                        SqlCommand comm = new SqlCommand("SELECT * FROM Donation_tbl WHERE Amount= @descriptiondl", conn);
                        comm.Parameters.AddWithValue("@Amount", descriptiondl);


                        SqlDataAdapter adpt = new SqlDataAdapter(comm);
                        DataTable dt = new DataTable();
                        adpt.Fill(dt);
                        dgvDeleteRecord.DataSource = dt;
                    }
                }
                else
                {
                    MessageBox.Show("Select a description");
                }

            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void comboBoxDonationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBoxDonationType.Text != " ")
            {
                if (!comboBoxDonationType.Items.Contains(comboBoxDonationType.Text))
                {
                    DialogResult result = MessageBox.Show("Donation type not found. Add as a new type?", "confirm", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        SqlCommand comm = new SqlCommand("INSERT INTO DonationType(Name) VALUES (@comboBoxDonationType.Text) ", conn);
                        comm.Parameters.AddWithValue("@Name", comboBoxDonationType.Text);
                        conn.Open();
                        comm.ExecuteNonQuery();
                        conn.Close();

                    }
                }
            }
        }

        private void Donations_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand comm = new SqlCommand("SELECT DISTINCT Name FROM DonationType", conn);
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxDonationType.Items.Add(reader["Name"].ToString());
                }
                reader.Close();
                conn.Close();


            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void tpgDonationsReceived_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tpgAdd_Click(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {



        }
    }
    }

