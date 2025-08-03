using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TawandaSystem
{
    public partial class Children : Form
    {
        public Children()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        string connectionString = (@"Data Source=SOLS\SQLEXPRESS;Initial Catalog=TAWANDA;Integrated Security=True;");

        private void tpgDelete_Click(object sender, EventArgs e)
        {

        }

        private bool ValidateIDNum(string idNum) //validating ID number 
        {
            if (idNum.Length != 13)
            {
                return false;
            }

            if (!idNum.All(char.IsDigit))
            {
                return false;
            }

            return true;
        }
        private void btnBackDel_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplayALLage_Click(object sender, EventArgs e)
        {

        }

        private void tpgChildren_SelectedIndexChanged(object sender, EventArgs e)
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
                        SqlCommand command = new SqlCommand("SELECT * FROM Child_tbl", conn);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dgvchildren.DataSource = table;

                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }


            }
            if(rdoLess.Checked)
            {
                try
                {
                    conn = new SqlConnection(connectionString);
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand("SELECT * FROM Child_tbl WHERE ID_Number < '1612301111111'", conn);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dgvchildren.DataSource = table;

                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }
            if(rdoBetween.Checked)
            {
                try
                {
                    conn = new SqlConnection(connectionString);
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand("SELECT * FROM Child_tbl WHERE ID_Number BETWEEN '1512301111111' AND '0712301111111'", conn);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dgvchildren.DataSource = table;

                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }
            if(rdogreater.Checked)
            {
                try
                {
                    conn = new SqlConnection(connectionString);
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand("SELECT * FROM Child_tbl WHERE ID_Number > '1512301111111'", conn);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dgvchildren.DataSource = table;

                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }
        

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection cnn;
                //string cnnString;
                string sql;
                SqlDataAdapter adp;
                SqlCommand command;

                //connectionString = @"Data Source=DESKTOP-NFU61V4\SQLEXPRESS;Initial Catalog=TawandaSystem;Integrated Security=True;Encrypt=True";
                conn = new SqlConnection(connectionString);

                conn.Open();

                if (txtLName.Text == " " && txtName.Text == " " && txtID.Text == " " && dateTimePicker1.Value.ToString() == " " && !chbxYes.Checked && !chbxNo.Checked)
                {
                    MessageBox.Show("Please enter all required fields");
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(txtLName.Text))
                    {
                        MessageBox.Show("Please enter the child's Last Name");
                    }
                    else if (string.IsNullOrWhiteSpace(txtName.Text))
                    {
                        MessageBox.Show("Please enter the child's Name");
                    }
                    else if (!ValidateIDNum(txtID.Text))
                    {
                        MessageBox.Show("Invalid ID Number");

                        if (string.IsNullOrWhiteSpace(txtID.Text))
                        {
                            MessageBox.Show("Please enter the child's identification number");
                        }
                    }
                    else if (!chbxYes.Checked && !chbxNo.Checked)
                    {
                        MessageBox.Show("Please indicate the child's accpetence status");
                    }
                    else if (dateTimePicker1.Value == dateTimePicker1.MinDate)
                    {
                        MessageBox.Show("Please enter a valid arrival date");
                    }
                    else
                    {
                        bool IsAccepted;

                        if (chbxYes.Checked)
                        {
                            IsAccepted = true;
                        }
                        else
                        {
                            IsAccepted = false;
                        }

                        string FName = txtName.Text;
                        string LName = txtLName.Text;
                        string IDNumber = txtID.Text;
                        string dateArrived = dateTimePicker1.Value.ToString();

                        //sql = $"INSERT INTO Child_tbl VALUES ('{txtLName.Text}','{txtName.Text}','{txtID.Text}','dateArrived,'IsAccepted')";
                        sql = $"INSERT INTO Child_tbl(Child_LName, Child_FName, ID_Number) VALUES ('{FName}','{LName}','{IDNumber}'";
                        command = new SqlCommand(sql, conn);
                        adp = new SqlDataAdapter();

                        adp.InsertCommand = command;
                        adp.InsertCommand.ExecuteNonQuery();

                        MessageBox.Show("Successfully submitted");

                    }
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            /*try
            {

                //SqlConnection cnn;
                //string cnnString;
                string sql;
                SqlDataAdapter adp;
                SqlCommand command;

                //connectionString = @"Data Source=DESKTOP-NFU61V4\SQLEXPRESS;Initial Catalog=TawandaSystem;Integrated Security=True;Encrypt=True";
                conn = new SqlConnection(connectionString);

                conn.Open();

                if (txtLName.Text == " " && txtName.Text == " " && txtID.Text == " " && dateTimePicker1.Value.ToString() == " " && !chbxYes.Checked && !chbxNo.Checked)
                {
                    MessageBox.Show("Please enter all required fields");
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(txtLName.Text))
                    {
                        MessageBox.Show("Please enter the child's Last Name");
                    }
                    else if (string.IsNullOrWhiteSpace(txtName.Text))
                    {
                        MessageBox.Show("Please enter the child's Name");
                    }
                    else if (!ValidateIDNum(txtID.Text))
                    {
                        MessageBox.Show("Invalid ID Number");

                        if (string.IsNullOrWhiteSpace(txtID.Text))
                        {
                            MessageBox.Show("Please enter the child's identification number");
                        }
                    }
                    else if (!chbxYes.Checked && !chbxNo.Checked)
                    {
                        MessageBox.Show("Please indicate the child's accpetence status");
                    }
                    else if (dateTimePicker1.Value == dateTimePicker1.MinDate)
                    {
                        MessageBox.Show("Please enter a valid arrival date");
                    }
                    else
                    {
                        bool IsAccepted;

                        if (chbxYes.Checked)
                        {
                            IsAccepted = true;
                        }
                        else
                        {
                            IsAccepted = false;
                        }

                        string FName = txtName.Text;
                        string LName = txtLName.Text;
                        string IDNumber = txtID.Text;
                        string dateArrived = dateTimePicker1.Value.ToString();

                        //sql = $"INSERT INTO Child_tbl VALUES ('{txtLName.Text}','{txtName.Text}','{txtID.Text}','dateArrived,'IsAccepted')";
                        sql = $"INSERT INTO Child_tbl(Child_LName, Child_FName, ID_Number) VALUES ('{txtLName.Text}','{txtName.Text}','{txtID.Text}'";
                        command = new SqlCommand(sql, conn);
                        adp = new SqlDataAdapter();

                        adp.InsertCommand = command;
                        adp.InsertCommand.ExecuteNonQuery();

                        MessageBox.Show("Successfully submitted");

                    }
                }
                conn.Close();

            }
            catch (SqlException io)
            {
                MessageBox.Show("An error occured in the system, we apologise for any inconveniences" + io);
            }*/
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLName.Clear();
            txtName.Clear();
            txtID.Clear();
            dateTimePicker1.Value = DateTime.Now;
            chbxNo.Checked = false;
            chbxYes.Checked = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AccessControl form = new AccessControl();
            form.ShowDialog();
            this.Hide();
        }

        private void Children_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection cnn;
                //string cnnString;
                string sql, output = " ";
                SqlCommand command;
                SqlDataReader dataReader;


                //cnnString = @"Data Source=DESKTOP-NFU61V4\SQLEXPRESS;Initial Catalog=TawandaSystem;Integrated Security=True;Encrypt=True";
                conn = new SqlConnection(connectionString);

                conn.Open();

                if (string.IsNullOrWhiteSpace(txtLNameUp.Text))
                {
                    MessageBox.Show("Please enter the child's Last Name");
                }
                else if (string.IsNullOrWhiteSpace(txtNameUp.Text))
                {
                    MessageBox.Show("Please enter the child's Name");
                }
                else if (!ValidateIDNum(txtIDUp.Text))
                {
                    MessageBox.Show("Invalid ID Number");

                    if (string.IsNullOrWhiteSpace(txtIDUp.Text))
                    {
                        MessageBox.Show("Please enter the child's identification number");
                    }
                }

                string departureDate = dateTimePicker2.Value.ToString();
                string name = txtNameUp.Text;
                string lname = txtLNameUp.Text;
                string idNum = txtIDUp.Text;

                sql = "UPDATE Child_tbl SET Departure_Date = 'departureDate' WHERE Child_FName = 'name' AND Child_LName = 'lname' AND ID_Number = IDNumber";

                command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();


                string sqlUp = "SELECT FROM Child_tbl WHERE ID_Number = 'idNum'";
                command = new SqlCommand(sqlUp, conn);

                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    output = dataReader.GetValue(0) + "\n";
                }

                lstUpdatedRecord.Items.Add(output);

                conn.Close();


            }
            catch (SqlException io)
            {
                MessageBox.Show("An error occured in the system, we apologise for any inconveniences" + io);
            }
        }

        private void btnClearUp_Click(object sender, EventArgs e)
        {
            txtNameUp.Text = " ";
            txtLNameUp.Text = " ";
            txtIDUp.Text = " ";
            lstUpdatedRecord.Items.Clear();
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            AccessControl form = new AccessControl();
            form.ShowDialog();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
    
}


