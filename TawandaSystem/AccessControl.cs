using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TawandaSystem
{
    public partial class AccessControl : Form
    {
        public AccessControl()
        {
            InitializeComponent();
        }

        private void btnChildren_Click(object sender, EventArgs e)
        {
            Children form3 = new Children();
            form3.Show();
            this.Hide();
        }

        private void btnDonations_Click(object sender, EventArgs e)
        {
            Donations form4 = new Donations();
            form4.Show();
            this.Hide();
        }

        private void btnDonationT_Click(object sender, EventArgs e)
        {
            DonationTypes form5 = new DonationTypes();
            form5.Show();
            this.Hide();
        }
    }
}
