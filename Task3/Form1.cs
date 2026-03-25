using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
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
            double totalCost = 0;
            int selectedTypesCount = 0;
            int quantityPerType = (int)numCount.Value;
            string selectedSizesInfo = "";

            if (cb9x12.Checked)
            {
                totalCost += Price9x12 * quantityPerType;
                selectedSizesInfo += "9x12, ";
                selectedTypesCount++;
            }
            if (cb12x15.Checked)
            {
                totalCost += Price12x15 * quantityPerType;
                selectedSizesInfo += "12x15, ";
                selectedTypesCount++;
            }
            if (cb18x24.Checked)
            {
                totalCost += Price18x24 * quantityPerType;
                selectedSizesInfo += "18x24, ";
                selectedTypesCount++;
            }

            if (selectedTypesCount == 0)
            {
                lblResult.Text = "Будь ласка, оберіть хоча б один розмір фотографії!";
                lblResult.ForeColor = Color.Red;
                return;
            }

            lblResult.ForeColor = Color.Black;
            int totalPhotos = selectedTypesCount * quantityPerType;
            string discountNote = "";

            if (totalPhotos > 20)
            {
                double discount = totalCost * 0.10;
                totalCost -= discount;
                discountNote = $"\n(Знижка 10%: -{discount:F2} грн)";
            }
            selectedSizesInfo = selectedSizesInfo.TrimEnd(' ', ',');
            lblResult.Text = $"Формати: {selectedSizesInfo}\n" +
                             $"Загальна кількість: {totalPhotos} шт.\n" +
                             $"Сума до сплати: {totalCost:F2} грн" +
                             discountNote;
        }
    }
}
