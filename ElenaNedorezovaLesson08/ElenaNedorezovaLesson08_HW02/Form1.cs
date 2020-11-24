using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElenaNedorezovaLesson08_HW02
{
    public partial class Form1 : Form
    {
        /*
        Задание:
        Создайте простую форму на котором свяжите свойство Text элемента TextBox со свойством Value элемента NumericUpDown

        Студент:
        Елена Недорезова
        */

        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = numericUpDown1.Value.ToString();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(int.TryParse(textBox1.Text, out int d))
                {
                    numericUpDown1.Value = d;
                }
            }
        }
    }
}
