using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS741_FinalProject_LamontMacoyMelkie
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        private void btnOrderClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            // Return Okay to main form.
            this.DialogResult = DialogResult.OK;

            MessageBox.Show("Thank you! Please order more or request your bill.");
            this.Close();
        }

    }
}
