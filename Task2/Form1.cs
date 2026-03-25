using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private const double Price9x12 = 5.50;
        private const double Price12x15 = 10.00;
        private const double Price18x24 = 22.50;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double pricePerUnit = 0;
            string sizeName = "";

            if (rb9x12.Checked) { pricePerUnit = Price9x12; sizeName = "9x12"; }
            else if (rb12x15.Checked) { pricePerUnit = Price12x15; sizeName = "12x15"; }
            else if (rb18x24.Checked) { pricePerUnit = Price18x24; sizeName = "18x24"; }

            int quantity = (int)numCount.Value;
            double total = pricePerUnit * quantity;
            string discountNote = "";

            if (quantity > 20)
            {
                double discount = total * 0.10; 
                total -= discount;
                discountNote = $"\n(Знижка 10%: -{discount:F2} грн)";
            }

            lblResult.Text = $"Замовлення: {sizeName}\n" + $"Кількість: {quantity} шт.\n" + $"Разом до сплати: {total:F2} грн" + discountNote;
        }
    }
}
