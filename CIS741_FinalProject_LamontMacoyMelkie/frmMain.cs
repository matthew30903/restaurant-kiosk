using System;
using System.IO;
using System.Windows.Forms;

namespace CIS741_FinalProject_LamontMacoyMelkie
{
    public partial class frmMain : Form
    {
        // Main Dish Instances
        Food chickenParmesan = new Food("Chicken Parmesan", 16.99M);
        Food creamyShrimpRisottoMascarpone = new Food("Shrimp Risotto with Mascarpone", 18.99M);
        Food lasagnaFresca = new Food("Lasagna Fresca", 15.99M);
        Food seaBassAllaFiorentina = new Food("Sea Bass Alla Fiorentina", 19.99M);
        Food spaghettiAllaPuttanesca = new Food("Spaghetti Alla Puttanesca", 15.99M);
        Food bakedItalianMeatballs = new Food("Baked Italian Meatball", 13.99M);
        Food lentilsConProsciutto = new Food("Lentils con Prosciutto", 13.99M);
        Food stracottoAlVinoRosso = new Food("Stracotto al Vino Rosso", 16.99M);
        Food pizzaNapolitana = new Food("Pizza Napolitana", 15.99M);
        Food stuffCrustItalianPizza = new Food("Stuff Crust Italian Pizza", 15.99M);
        // Salad Instances
        Food italianOliveAndPeppersSalad = new Food("Italian Olive and Peppers Salad", 9.99M);
        Food italianStylePotatoSalad = new Food("Italian Style Potato Salad", 9.99M);
        Food chefsSalad = new Food("Italian Chef's Salad", 9.99m);
        // Beverages
        Food limoncello = new Food("Limoncello", 7.99m);
        Food italianCream = new Food("Italian Cream", 7.99m);
        Food bloodOrange = new Food("Blood Orange", 7.99m);
        // Desserts
        Food cannoliFritti = new Food("Cannoli Fritti", 5.99m);
        Food tiramisu = new Food("Tiramisu", 5.99m);
        Food tortaCaprese = new Food("Torta Caprese", 5.99m);

        public frmMain()
        {
            InitializeComponent();
        }

        // Set Count of each Food item to its respective numbox.
        private void setCount()
        {
            // Converts the value of numBox to int and stores it in count
            // Main Dishes
            chickenParmesan.Count = (int)numBoxChickenParmesan.Value;
            creamyShrimpRisottoMascarpone.Count = (int)numBoxCreamyShrimpRisottoWithMascarpone.Value;
            lasagnaFresca.Count = (int)numBoxLasagnaFresca.Value;
            seaBassAllaFiorentina.Count = (int)numBoxSeaBassAllaFiorentina.Value;
            spaghettiAllaPuttanesca.Count = (int)numBoxSpaghettiAllaPuttanesca.Value;
            bakedItalianMeatballs.Count = (int)numBoxBakedItalianMeatballs.Value;
            lentilsConProsciutto.Count = (int)numBoxLentilsConProsciutto.Value;
            stracottoAlVinoRosso.Count = (int)numBoxStracottoAlVinoRosso.Value;
            pizzaNapolitana.Count = (int)numBoxlblPizzaNapolitana.Value;
            stuffCrustItalianPizza.Count = (int)numBoxStuffCrustItalianPizza.Value;
            // Salads
            italianOliveAndPeppersSalad.Count = (int)numBoxItalianOliveAndPeppersSalad.Value;
            italianStylePotatoSalad.Count = (int)numBoxItalianStylePotatoSalad.Value;
            chefsSalad.Count = (int)numBoxItalianChefsSalad.Value;
            // Beverages
            limoncello.Count = (int)numBoxLimoncello.Value;
            italianCream.Count = (int)numboxItalianCreamSoda.Value;
            bloodOrange.Count = (int)numBoxBloodOrangeItalianSoda.Value;
            //Deserts
            cannoliFritti.Count = (int)numBoxlblCannoliFritti.Value;
            tiramisu.Count = (int)numBoxTiramisu.Value;
            tortaCaprese.Count = (int)numBoxTortaCaprese.Value;
        }

        // Sets the minimum for numBoxes to the value of the count of their respective food
        private void setMinimum()
        {
            // Main Dishes
            numBoxChickenParmesan.Minimum = chickenParmesan.Count;
            numBoxCreamyShrimpRisottoWithMascarpone.Minimum = creamyShrimpRisottoMascarpone.Count;
            numBoxLasagnaFresca.Minimum = lasagnaFresca.Count;
            numBoxSeaBassAllaFiorentina.Minimum = seaBassAllaFiorentina.Count;
            numBoxSpaghettiAllaPuttanesca.Minimum = spaghettiAllaPuttanesca.Count;
            numBoxBakedItalianMeatballs.Minimum = bakedItalianMeatballs.Count;
            numBoxLentilsConProsciutto.Minimum = lentilsConProsciutto.Count;
            numBoxStracottoAlVinoRosso.Minimum = stracottoAlVinoRosso.Count;
            numBoxlblPizzaNapolitana.Minimum = pizzaNapolitana.Count;
            numBoxStuffCrustItalianPizza.Minimum = stuffCrustItalianPizza.Count;

            //Salads
            numBoxItalianOliveAndPeppersSalad.Minimum = italianOliveAndPeppersSalad.Count;
            numBoxItalianStylePotatoSalad.Minimum = italianStylePotatoSalad.Count;
            numBoxItalianChefsSalad.Minimum = chefsSalad.Count;
            // Beverages
            numBoxLimoncello.Minimum = limoncello.Count;
            numboxItalianCreamSoda.Minimum = italianCream.Count;
            numBoxBloodOrangeItalianSoda.Minimum = bloodOrange.Count;

            // Deserts
            numBoxlblCannoliFritti.Minimum = cannoliFritti.Count;
            numBoxTiramisu.Minimum = tiramisu.Count;
            numBoxTortaCaprese.Minimum = tortaCaprese.Count;
        }

        // ViewOrder
        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            if (txtPartyName.Text == "")
                MessageBox.Show("Please enter Customer's name first!");
            else
            {
                frmOrder order = new frmOrder();
                order.txtOrder.Text = viewOrder();
                order.txtOrderSubtotal.Text = getSubTotal().ToString("C");
                order.ShowDialog();
            }
        }

        // PlaceOrder
        public void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (txtPartyName.Text == "")
                MessageBox.Show("Please enter Customer's name first!");
            else
            {
                frmOrder order = new frmOrder();
                order.txtOrder.Text = viewOrder();
                order.txtOrderSubtotal.Text = getSubTotal().ToString("C");
                order.btnPlaceOrder.Visible = true;
                //Makes sure the user ordered something before calling form.
                if (isItemOrdered())
                {
                    if (order.ShowDialog() == DialogResult.OK)
                    {
                        btnRequestBill.Visible = true;
                        setMinimum();
                    }
                }
                else
                {
                    MessageBox.Show("Please order at least one item");
                }

            }
        }

        // RequestBill
        private void btnRequestBill_Click(object sender, EventArgs e)
        {
            StreamWriter receipt;
            Random random = new Random();
            int receiptNumber = random.Next();
            DateTime date = new DateTime();
            date = DateTime.Now;

            frmBill bill = new frmBill();
            bill.txtBill.Text = viewOrder();
            bill.subTotal = getSubTotal();
            // Customer must first enter name before ordering
            if (txtPartyName.Text == "")
                MessageBox.Show("Please enter Customer's name first!");
            else
            {
                if (bill.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Thank you " + txtPartyName.Text + "!");

                    // Writes Receipt
                    receipt = new StreamWriter(receiptNumber.ToString() + "_" + txtPartyName.Text + ".txt");

                    // Header
                    receipt.WriteLine("3M's");
                    receipt.WriteLine("Receipt Number: " + receiptNumber + "\n");
                    receipt.WriteLine("Time: " + date.ToString("yyyy-MM-dd:hh:mm"));

                    receipt.WriteLine(String.Format("{0,-35} | {1,-6} | {2,8}  \n", "Item", "Number", "Price"));
                    // Writes all Ordered Food
                    foreach (Food item in Food.orderList)
                    {
                        if (item.Count > 0)
                            receipt.WriteLine(item.ToString());
                    }

                    // Totals
                    receipt.WriteLine("-------------------------------------------------");
                    receipt.WriteLine("\nSubTotal: " + bill.txtBillSubtotal.Text);
                    receipt.WriteLine("Tax: " + bill.txtBilltax.Text);
                    receipt.WriteLine("Total: " + bill.txtBillTotal.Text);
                    receipt.WriteLine("Tip: " + bill.tip.ToString("C") + "\n");
                    receipt.WriteLine("Grand Total: " + bill.txtBillGrandtotal.Text + "\n");

                    // Card Information
                    receipt.WriteLine("-------------------------------------------------");

                    if (bill.radPayDebit.Checked == true || bill.radPayCredit.Checked == true)
                        receipt.WriteLine("Card Number: " + bill.maskTxtCardNumber.Text);
                    if (bill.radPayDebit.Checked == true || bill.radPayCredit.Checked == true)
                        receipt.WriteLine("Exp. Date:  " + bill.dateCardExpirationDate.Value.ToString("MM-yy"));
                    if (bill.radPayDebit.Checked == true)
                        receipt.WriteLine("Pin: " + bill.txtBillCardPin.Text);

                    receipt.Close();
                    // Resets form
                    resetForm();
                }
            }
        }

        // Calls order form to display the order information.
        private string viewOrder()
        {
            // Header of order form
            string order = String.Format("{0,-35} | {1,6} | {2,8}  \n", "Item", "Number", "Price");
            setCount();

            // Finds each Food that has been ordered and adds it to the order string
            foreach (Food item in Food.orderList)
            {
                if(item.Count > 0)
                    order += item.ToString() + "\n";
            }

            return order;
        }

        // Write Recipt to file
        private void writeToFile()
        {
            StreamWriter outFile = new StreamWriter("recipt.text");
        }

        // Returns the total value of all ordered food items
        private decimal getSubTotal()
        {
            decimal total = 0m;
            foreach (Food item in Food.orderList)
            {
                if (item.Count > 0)
                    total += item.TotalPrice;
            }

            return total;
        }

        // Check if item is ordered
        private bool isItemOrdered()
        {
            foreach (Food item in Food.orderList)
                if (item.Count > 0)
                    return true;
            return false;
        }

        // Resets Form
        private void resetForm()
        {

            // Resets the minimum of each numBox to 0
            foreach(Food item in Food.orderList)
            {
                item.Count = 0;
            }
            setMinimum();

            // Resets the value of each numBox to 0
            // Main Dishes
            numBoxChickenParmesan.Value = 0;
            numBoxCreamyShrimpRisottoWithMascarpone.Value = 0;
            numBoxLasagnaFresca.Value = 0;
            numBoxSeaBassAllaFiorentina.Value = 0;
            numBoxSpaghettiAllaPuttanesca.Value = 0;
            numBoxBakedItalianMeatballs.Value = 0;
            numBoxLentilsConProsciutto.Value = 0;
            numBoxStracottoAlVinoRosso.Value = 0;
            numBoxlblPizzaNapolitana.Value = 0;
            numBoxStuffCrustItalianPizza.Value = 0;
            // Salads
            numBoxItalianOliveAndPeppersSalad.Value = 0;
            numBoxItalianStylePotatoSalad.Value = 0;
            numBoxItalianChefsSalad.Value = 0;
            // Beverages
            numBoxLimoncello.Value = 0;
            numboxItalianCreamSoda.Value = 0;
            numBoxBloodOrangeItalianSoda.Value = 0;
            //Deserts
            numBoxlblCannoliFritti.Value = 0;
            numBoxTiramisu.Value = 0;
            numBoxTortaCaprese.Value = 0;

            setCount();
            txtPartyName.Text = "";
            btnRequestBill.Visible = false;

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmSplash splash = new frmSplash();
            splash.ShowDialog();
        }

    }
}
