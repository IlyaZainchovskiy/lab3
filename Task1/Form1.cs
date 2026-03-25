using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            txtSurname.ForeColor = Color.Black;
            foreach (char c in txtSurname.Text)
            {
                if (!char.IsLetter(c) && txtSurname.Text != "Прізвище")
                {
                    lDiagnost.Text = "* Прізвище має містити тільки літери";
                    return;
                }
            }
            lDiagnost.Text = "";
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtName.ForeColor = Color.Black;
            foreach (char c in txtName.Text)
            {
                if (!char.IsLetter(c) && txtName.Text != "Ім'я")
                {
                    lDiagnost.Text = "* Ім'я має містити тільки літери";
                    return;
                }
            }
            lDiagnost.Text = "";
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            txtLogin.ForeColor = Color.Black;
        }
        private bool CheckEmptyTextBox()
        {
            if (string.IsNullOrWhiteSpace(txtSurname.Text) || txtSurname.Text == "Прізвище" ||
                string.IsNullOrWhiteSpace(txtName.Text) || txtName.Text == "Ім'я" ||
                string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                lDiagnost.Text = "* Поля Прізвище, Ім'я та Логін обов'язкові";
                return false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtPassword1.Text))
            {
                lDiagnost.Text = "* Введіть пароль";
                return false;
            }
            return true;
        }
        private bool CheckPassword()
        {
            if (txtPassword.Text != txtPassword1.Text)
            {
                lDiagnost.Text = "* Паролі не співпадають";
                return false;
            }
            if (txtPassword.Text.Length < 6)
            {
                lDiagnost.Text = "* Пароль занадто короткий (мін. 6 символів)";
                return false;
            }
            return true;
        }
        private bool CheckLogin()
        {
            Regex myReg1 = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");

            if (!myReg1.IsMatch(txtLogin.Text))
            {
                lDiagnost.Text = "* Невірний формат логіну (Email)";
                return false;
            }
            return true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (CheckEmptyTextBox() && CheckPassword() && CheckLogin())
            {
                lDiagnost.Text = "";
                string gender = rbMale.Checked ? "Чоловік" : "Жінка";
                string birthDate = $"{numDay.Value:00}.{numMonth.Value:00}.{numYear.Value}";

                string result = "--- ДАНІ РЕЄСТРАЦІЇ ---" + Environment.NewLine;
                result += $"Прізвище: {txtSurname.Text}" + Environment.NewLine;
                result += $"Ім'я: {txtName.Text}" + Environment.NewLine;
                result += $"Логін: {txtLogin.Text}" + Environment.NewLine;
                result += $"Стать: {gender}" + Environment.NewLine;
                result += $"Дата народження: {birthDate}" + Environment.NewLine;
                result += "------------------------";

                txtOutput.Text = result;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
