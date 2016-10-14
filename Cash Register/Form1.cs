using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Cash_Register
{
    public partial class cashRegister : Form
    {

        //Setup Variables
        const double PEP_PIZZA_COST = 15.50;
        const double CHEESE_PIZZA_COST = 10.00;
        const double CA_PIZZA_COST = 20.00;
        const double TAX = 1.13;
        double subtotal;
        double total;
        double cash;
        double change;
        int pep_pizza;
        int cheese_pizza;
        int ca_pizza;
        double tax;
        double tendered;
        double pepPizzaCost;
        double cheesePizzaCost;
        double caPizzaCost;

        public cashRegister()
        {
            InitializeComponent();
        }

        private void calculateSubtotal_Click(object sender, EventArgs e)
        {

            try
            {


                //Converts the text input into a number value and places it into a variable

                pep_pizza = Convert.ToInt16(pepInput.Text);
                cheese_pizza = Convert.ToInt16(cheeseInput.Text);
                ca_pizza = Convert.ToInt16(canadianInput.Text);

                pepPizzaCost = pep_pizza * PEP_PIZZA_COST;
                cheesePizzaCost = cheese_pizza * CHEESE_PIZZA_COST;
                caPizzaCost = ca_pizza * CA_PIZZA_COST;

                //MATH
                pepPizzaCost = pep_pizza * PEP_PIZZA_COST;
                cheesePizzaCost = cheese_pizza * CHEESE_PIZZA_COST;
                caPizzaCost = ca_pizza * CA_PIZZA_COST;

                subtotal = (pep_pizza * PEP_PIZZA_COST) + (cheese_pizza * CHEESE_PIZZA_COST) + (ca_pizza * CA_PIZZA_COST);

                subtotalOutput.Text = subtotal.ToString("C");

                total = subtotal * TAX;
                totalOutput.Text = total.ToString("C");

                tax = total - subtotal;
                taxOutput.Text = tax.ToString("C");


            }

            //Message that shows when an input is not given
            catch
            {

                subtotalOutput.Text = "If you dont want a pizza, enter the value as '0'";
            }
                 
        }


        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                tendered = Convert.ToInt16(amountInput.Text);
                change = tendered - total;

                changeOutput.Text = change.ToString("C");

                // If statement that displays a message when the money given is less than the amount owed
                if (tendered < total)
                {
                    changeOutput.Text = "HEY! PAY UP!";

                }

            }

            catch
            {

                changeOutput.Text = "Hey Buddy, you think im running this for free?!";

            }



        }

        private void printReciept_Click(object sender, EventArgs e)
        {
            Graphics fg = this.CreateGraphics();

            SolidBrush recieptColor = new SolidBrush(Color.White);
            fg.FillRectangle(recieptColor, 505, 25, 336, 423);

            //Graphics
            Font titleFont = new Font("Courier New", 16, FontStyle.Underline);
            SolidBrush fontBrush = new SolidBrush(Color.Black);
            Font normalFont = new Font("Courier New", 16);

            //Reciept cost

            fg.DrawString("Joe's Pizza Depot", titleFont, fontBrush, 555, 25);
            fg.DrawString( + "Peperoni Pizza" );
        }
    }
}