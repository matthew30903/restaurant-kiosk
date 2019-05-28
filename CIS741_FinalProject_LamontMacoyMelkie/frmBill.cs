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
    public partial class frmBill : Form
    {
        // Public information to send back to main form
        public string cardNumber { get; set; }
        public string cardPin { get; set; }
        public decimal tip { get; set; }
        public decimal subTotal;


        // private Const
        private const decimal TAX = .095m;

        public frmBill()
        {
            InitializeComponent();
        }

        // Check Radio Buttons
        private void radPayCash_CheckedChanged(object sender, EventArgs e)
        {
            if (radPayCash.Checked)
            {
                lblCardNumber.Visible = false;
                maskTxtCardNumber.Visible = false;
                lblBillCardPin.Visible = false;
                txtBillCardPin.Visible = false;
                lblCardExpirationDate.Visible = false;
                dateCardExpirationDate.Visible =false;
            }
        }

        private void radPayCredit_CheckedChanged(object sender, EventArgs e)
        {
            if (radPayCredit.Checked)
            {
                lblCardNumber.Visible = true;
                maskTxtCardNumber.Visible = true;
                lblBillCardPin.Visible = false;
                txtBillCardPin.Visible = false;
                lblCardExpirationDate.Visible = true;
                dateCardExpirationDate.Visible = true;
            }
        }

        private void radPayDebit_CheckedChanged(object sender, EventArgs e)
        {
            if (radPayDebit.Checked)
            {
                lblCardNumber.Visible = true;
                maskTxtCardNumber.Visible = true;
                lblBillCardPin.Visible = true;
                txtBillCardPin.Visible = true;
                lblCardExpirationDate.Visible = true;
                dateCardExpirationDate.Visible = true;
            }
        }

        // When bill is payed
        private void btnBillPay_Click(object sender, EventArgs e)
        {
            // Use in for card number validation, then convert it to string for later storage
            const int CARD_NUMBER_SIZE = 19;
            string cardNumber = maskTxtCardNumber.Text;
            int cardPin;
            decimal tip = (decimal)numBoxBillTip.Value;
            this.tip = tip;
         
            string order = txtBill.Text;

            // Checks payment method and performs input validation

            if (radPayCash.Checked)
            {
                MessageBox.Show("Thank you, please wait for a waiter to bring you your bill.");
                // sends a Dialouge Okay back to main form and closes the form.
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            if (radPayCredit.Checked)
            {
                if (maskTxtCardNumber.Text.Length < CARD_NUMBER_SIZE)
                {
                    MessageBox.Show("Please enter a valid card number!");
                }
                // TO-DO Parse Exp Date
                else
                {
                    // Stores card infoin public variable for main form to use
                    this.cardNumber = cardNumber;

                    // sends a Dialouge Okay back to main form and closes the form.
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }

            if (radPayDebit.Checked)
            {
                if (maskTxtCardNumber.Text.Length < CARD_NUMBER_SIZE)
                {
                    MessageBox.Show("Please enter a valid card number!");
                }
                // TO-DO Parse Exp Date

                else if (!int.TryParse(txtBillCardPin.Text, out cardPin))
                {
                    MessageBox.Show("Please enter a valid card pin!");
                }
                else
                {
                    // Stores card infoin public variable for main form to use
                    this.cardNumber = cardNumber;
                    this.cardPin = cardPin.ToString();

                    // sends a Dialouge Okay back to main form and closes the form.
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }


        }

        private void btnBillClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBill_Load(object sender, EventArgs e)
        {
            // Variables
            decimal taxAmount = this.subTotal * TAX;
            decimal total = taxAmount + this.subTotal;

            txtBillSubtotal.Text = this.subTotal.ToString("C");
            txtBilltax.Text = taxAmount.ToString("C");
            txtBillTotal.Text = total.ToString("C");
            txtBillGrandtotal.Text = total.ToString("C");
        }

        private void dateCardExpirationDate_ValueChanged(object sender, EventArgs e)
        {
            if (dateCardExpirationDate.Value < DateTime.Now)
            {
                MessageBox.Show("Your card is expired!");
            }
        }

        private void numBoxBillTip_ValueChanged(object sender, EventArgs e)
        {
            //Varialbes
            decimal tip = (decimal)numBoxBillTip.Value;
            this.tip = tip;
            decimal taxAmount = this.subTotal * TAX;
            decimal total = taxAmount + this.subTotal;
            decimal grandTotal = total + this.tip;
            txtBillGrandtotal.Text = grandTotal.ToString("C");
        }
    }
}
