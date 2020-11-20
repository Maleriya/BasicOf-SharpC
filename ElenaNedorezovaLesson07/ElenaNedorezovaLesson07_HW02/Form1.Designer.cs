namespace ElenaNedorezovaLesson07_HW02
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumber = new System.Windows.Forms.Label();
            this.listBoxTry = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textTry = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelLess = new System.Windows.Forms.Label();
            this.labelMore = new System.Windows.Forms.Label();
            this.buttonTry = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumber.Location = new System.Drawing.Point(273, 26);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(499, 46);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "Угадай число от 1 до 100";
            // 
            // listBoxTry
            // 
            this.listBoxTry.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxTry.FormattingEnabled = true;
            this.listBoxTry.ItemHeight = 31;
            this.listBoxTry.Location = new System.Drawing.Point(12, 83);
            this.listBoxTry.Name = "listBoxTry";
            this.listBoxTry.Size = new System.Drawing.Size(206, 345);
            this.listBoxTry.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Догадки:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listBoxTry);
            this.panel1.Location = new System.Drawing.Point(0, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 441);
            this.panel1.TabIndex = 4;
            // 
            // textTry
            // 
            this.textTry.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.textTry.Location = new System.Drawing.Point(444, 107);
            this.textTry.Name = "textTry";
            this.textTry.Size = new System.Drawing.Size(127, 53);
            this.textTry.TabIndex = 5;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.buttonStart.Location = new System.Drawing.Point(444, 368);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(156, 59);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelLess
            // 
            this.labelLess.AutoSize = true;
            this.labelLess.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLess.Location = new System.Drawing.Point(273, 247);
            this.labelLess.Name = "labelLess";
            this.labelLess.Size = new System.Drawing.Size(171, 46);
            this.labelLess.TabIndex = 7;
            this.labelLess.Text = "Меньше";
            // 
            // labelMore
            // 
            this.labelMore.AutoSize = true;
            this.labelMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMore.Location = new System.Drawing.Point(582, 247);
            this.labelMore.Name = "labelMore";
            this.labelMore.Size = new System.Drawing.Size(168, 46);
            this.labelMore.TabIndex = 8;
            this.labelMore.Text = "Больше";
            // 
            // buttonTry
            // 
            this.buttonTry.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTry.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.buttonTry.Location = new System.Drawing.Point(281, 166);
            this.buttonTry.Name = "buttonTry";
            this.buttonTry.Size = new System.Drawing.Size(454, 59);
            this.buttonTry.TabIndex = 9;
            this.buttonTry.Text = "Попытка не пытка";
            this.buttonTry.UseVisualStyleBackColor = false;
            this.buttonTry.Click += new System.EventHandler(this.buttonTry_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTry);
            this.Controls.Add(this.labelMore);
            this.Controls.Add(this.labelLess);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textTry);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.ListBox listBoxTry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textTry;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelLess;
        private System.Windows.Forms.Label labelMore;
        private System.Windows.Forms.Button buttonTry;
    }
}

