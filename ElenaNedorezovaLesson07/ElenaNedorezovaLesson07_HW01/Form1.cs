using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElenaNedorezovaLesson07_HW01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            butCommand1.Text = "+1";
            butCommand2.Text = "x2";
            butReset.Text = "Сброс";
            lblNumber.Text = "0";
            this.Text = "Удвоитель";
            this.BackColor = Color.Azure;
            lblNeedNumText.Visible = false;
            lblNeedNumber.Visible = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private enum WhatButtonLast
        {
            plusOne,
            mul
        }

        private int countStep = 0;
        private bool isGame = false;
        private int GameNum = 0;
        private List<WhatButtonLast> whatButtonLast = new List<WhatButtonLast>();
        private void IncStep(bool isReset = false)
        {
            if (isReset)
                countStep = 0;
            else
                countStep++;
            lblCountStep.Text = countStep.ToString();

            if(isGame)
            {
                if (lblNumber.Text == GameNum.ToString())
                {
                    MessageBox.Show("Вы получили число за " + countStep + " шагов");
                    isGame = false;
                    this.BackColor = Color.Azure;
                    lblNeedNumText.Visible = false;
                    lblNeedNumber.Visible = false;
                }
            }
        }

        private void butCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            IncStep();
            whatButtonLast.Add(WhatButtonLast.plusOne);
        }

        private void butCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            IncStep();
            whatButtonLast.Add(WhatButtonLast.mul);
        }

        private void butReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "0";
            IncStep(true);
            whatButtonLast = new List<WhatButtonLast>();
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            GameNum = random.Next(10, 100);
            lblNeedNumText.Visible = true;
            lblNeedNumber.Visible = true;
            lblNeedNumber.Text = GameNum.ToString();
            butReset_Click(null, null);
            isGame = true;
            this.BackColor = Color.LightGreen;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (whatButtonLast.Count == 0)
                return;

            int lastInd = whatButtonLast.Count - 1;

            switch (whatButtonLast[lastInd])
            {
                case WhatButtonLast.plusOne:
                    lblNumber.Text = (int.Parse(lblNumber.Text) - 1).ToString();
                    break;
                case WhatButtonLast.mul:
                    lblNumber.Text = (int.Parse(lblNumber.Text) / 2).ToString();
                    break;
                default:
                    break;
            }

            whatButtonLast.RemoveAt(lastInd);
            countStep--;
            lblCountStep.Text = countStep.ToString();
        }
    }
}
