namespace ElenaNedorezovaLesson07_HW01
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
            this.butCommand2 = new System.Windows.Forms.Button();
            this.butCommand1 = new System.Windows.Forms.Button();
            this.butReset = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCountStep = new System.Windows.Forms.Label();
            this.lblNeedNumText = new System.Windows.Forms.Label();
            this.lblNeedNumber = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumber.Location = new System.Drawing.Point(42, 109);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(126, 46);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "label1";
            // 
            // butCommand2
            // 
            this.butCommand2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.butCommand2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butCommand2.Location = new System.Drawing.Point(272, 105);
            this.butCommand2.Name = "butCommand2";
            this.butCommand2.Size = new System.Drawing.Size(145, 58);
            this.butCommand2.TabIndex = 1;
            this.butCommand2.Text = "x2";
            this.butCommand2.UseVisualStyleBackColor = false;
            this.butCommand2.Click += new System.EventHandler(this.butCommand2_Click);
            // 
            // butCommand1
            // 
            this.butCommand1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.butCommand1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butCommand1.Location = new System.Drawing.Point(272, 39);
            this.butCommand1.Name = "butCommand1";
            this.butCommand1.Size = new System.Drawing.Size(145, 58);
            this.butCommand1.TabIndex = 2;
            this.butCommand1.Text = "+1";
            this.butCommand1.UseVisualStyleBackColor = false;
            this.butCommand1.Click += new System.EventHandler(this.butCommand1_Click);
            // 
            // butReset
            // 
            this.butReset.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.butReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butReset.Location = new System.Drawing.Point(272, 233);
            this.butReset.Name = "butReset";
            this.butReset.Size = new System.Drawing.Size(145, 58);
            this.butReset.TabIndex = 3;
            this.butReset.Text = "Сброс";
            this.butReset.UseVisualStyleBackColor = false;
            this.butReset.Click += new System.EventHandler(this.butReset_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItem
            // 
            this.MenuItem.Name = "MenuItem";
            this.MenuItem.Size = new System.Drawing.Size(57, 20);
            this.MenuItem.Text = "Играть";
            this.MenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(444, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Число ходов:";
            // 
            // lblCountStep
            // 
            this.lblCountStep.AutoSize = true;
            this.lblCountStep.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblCountStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountStep.Location = new System.Drawing.Point(551, 132);
            this.lblCountStep.Name = "lblCountStep";
            this.lblCountStep.Size = new System.Drawing.Size(42, 46);
            this.lblCountStep.TabIndex = 6;
            this.lblCountStep.Text = "0";
            // 
            // lblNeedNumText
            // 
            this.lblNeedNumText.AutoSize = true;
            this.lblNeedNumText.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNeedNumText.Location = new System.Drawing.Point(87, 356);
            this.lblNeedNumText.Name = "lblNeedNumText";
            this.lblNeedNumText.Size = new System.Drawing.Size(330, 46);
            this.lblNeedNumText.TabIndex = 7;
            this.lblNeedNumText.Text = "Получите число:";
            // 
            // lblNeedNumber
            // 
            this.lblNeedNumber.AutoSize = true;
            this.lblNeedNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNeedNumber.Location = new System.Drawing.Point(423, 356);
            this.lblNeedNumber.Name = "lblNeedNumber";
            this.lblNeedNumber.Size = new System.Drawing.Size(0, 46);
            this.lblNeedNumber.TabIndex = 8;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(216, 169);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(263, 58);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Отменить ход";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.lblNeedNumber);
            this.Controls.Add(this.lblNeedNumText);
            this.Controls.Add(this.lblCountStep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butReset);
            this.Controls.Add(this.butCommand1);
            this.Controls.Add(this.butCommand2);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button butCommand2;
        private System.Windows.Forms.Button butCommand1;
        private System.Windows.Forms.Button butReset;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCountStep;
        private System.Windows.Forms.Label lblNeedNumText;
        private System.Windows.Forms.Label lblNeedNumber;
        private System.Windows.Forms.Button buttonCancel;
    }
}

