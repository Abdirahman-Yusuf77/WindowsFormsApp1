using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // exit
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // clear 
            txtamounttip.Clear();
            txtfood1.Text = string.Empty;
            txtfood2.Text = string.Empty;
            txtpricefood1.Text = "";
            txtpricefood2.Text = string.Empty;
            lblnetamount.Text = string.Empty;
            lblsalestxt.Text = string.Empty;
            lblsalestxt.Text = string.Empty;
            lblsalestxt.Text = "";
            lbltipsamount.Text = "";
            lbltotalamount.Text = "";
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create varibles 
            string food1, food2;
            const double sales_vat= 5;
            double price_food1, price_food2, sales_text, amount_tip, tips, total_amount, net_amount,amount;
            // assgning variables using parse method
            food1 = txtfood1.Text; food2 = txtfood2.Text;
            price_food1 = double.Parse(txtpricefood1.Text);
            price_food2 = double.Parse(txtpricefood2.Text);
            tips = double.Parse(txtamounttip.Text);
            amount = price_food1 + price_food2 ;
            sales_text = amount * (sales_vat / 100);
            amount_tip = amount * (tips / 100) ;
            net_amount = amount;
            total_amount= amount + sales_text + amount_tip;

            // Display output
            lblsalestxt.Text = sales_text.ToString("c");
            lbltipsamount.Text = amount_tip.ToString("c");
            lbltotalamount.Text = total_amount.ToString("c");
            lblnetamount.Text = net_amount.ToString("c");



        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblsalestxt_Click(object sender, EventArgs e)
        {

        }
    }
}
