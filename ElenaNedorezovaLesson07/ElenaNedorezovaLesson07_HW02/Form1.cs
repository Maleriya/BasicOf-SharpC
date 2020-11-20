using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElenaNedorezovaLesson07_HW02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            textTry.Enabled = false;
            buttonTry.Enabled = false;
        }

        private int computersNum = 0;
        private void buttonStart_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            computersNum = random.Next(1, 100);
            MessageBox.Show("Я загадал!");
            UpdateListTry(null);
            textTry.Enabled = true;
            buttonTry.Enabled = true;
        }

        private void UpdateListTry(int? a)
        {
            if (a == null)
                listBoxTry.Items.Clear();
            else
                listBoxTry.Items.Add(a);
        }

        private void buttonTry_Click(object sender, EventArgs e)
        {
            labelLess.BackColor = Color.White;
            labelMore.BackColor = Color.White;
            if (int.TryParse(textTry.Text, out int userTryNum))
            {
                UpdateListTry(userTryNum);
                if (userTryNum == computersNum)
                {
                    MessageBox.Show("Поздравляю! Ты угадал!");
                    textTry.Enabled = false;
                    buttonTry.Enabled = false;
                }
                else if (userTryNum > computersNum)
                {
                    labelLess.BackColor = Color.LightBlue;
                }
                else
                {
                    labelMore.BackColor = Color.LightCoral;
                }
            }
            else
                MessageBox.Show("Не пиши фигню, редиска!");
        }
    }
}
