using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProfitHeat;

namespace ProfitHeat
{
    public partial class Form_Аутентификация : Form
    {
        public Form_Аутентификация()
        {
            InitializeComponent();
        }

        private void textBox_Имя_Enter(object sender, EventArgs e)
        {
            textBox_Имя.Text = "";
        }


        private void textBox_Пароль_Enter(object sender, EventArgs e)
        {
            textBox_Пароль.Text = "";
            textBox_Пароль.UseSystemPasswordChar = true;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            string name = textBox_Имя.Text;
            string password = textBox_Пароль.Text;
            if (name + password == "user1")
            {
                MessageBox.Show("Привет, " + name + "!");
                Form_User f2 = new Form_User();
                this.Hide();
                f2.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Имя или палоль указаны неверно!");
        }
    }
}
