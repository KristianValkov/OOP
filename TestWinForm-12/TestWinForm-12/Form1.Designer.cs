namespace TestWinForm_12
{
    partial class FormRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cmbFieldОfШork = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEGN = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.grbGandar = new System.Windows.Forms.GroupBox();
            this.rbWomann = new System.Windows.Forms.RadioButton();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.lбFлfeldОfШork = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.grbGandar.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbFieldОfШork
            // 
            this.cmbFieldОfШork.FormattingEnabled = true;
            this.cmbFieldОfШork.Items.AddRange(new object[] {
            "Учащ",
            "Държашен служител",
            "Работник в частна фирма",
            "Безработен"});
            this.cmbFieldОfШork.Location = new System.Drawing.Point(198, 65);
            this.cmbFieldОfШork.Name = "cmbFieldОfШork";
            this.cmbFieldОfШork.Size = new System.Drawing.Size(151, 28);
            this.cmbFieldОfШork.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 27);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 27);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 171);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(162, 27);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 224);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(162, 27);
            this.textBox4.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 20);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Име";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 95);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(73, 20);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "Фамилия";
            // 
            // lblEGN
            // 
            this.lblEGN.AutoSize = true;
            this.lblEGN.Location = new System.Drawing.Point(12, 201);
            this.lblEGN.Name = "lblEGN";
            this.lblEGN.Size = new System.Drawing.Size(35, 20);
            this.lblEGN.TabIndex = 8;
            this.lblEGN.Text = "ЕГН";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(13, 148);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(72, 20);
            this.lblMiddleName.TabIndex = 9;
            this.lblMiddleName.Text = "Презиме";
            // 
            // grbGandar
            // 
            this.grbGandar.Controls.Add(this.rbWomann);
            this.grbGandar.Controls.Add(this.rbMan);
            this.grbGandar.Location = new System.Drawing.Point(198, 99);
            this.grbGandar.Name = "grbGandar";
            this.grbGandar.Size = new System.Drawing.Size(151, 119);
            this.grbGandar.TabIndex = 10;
            this.grbGandar.TabStop = false;
            this.grbGandar.Text = "Пол";
            // 
            // rbWomann
            // 
            this.rbWomann.AutoSize = true;
            this.rbWomann.Location = new System.Drawing.Point(6, 68);
            this.rbWomann.Name = "rbWomann";
            this.rbWomann.Size = new System.Drawing.Size(68, 24);
            this.rbWomann.TabIndex = 1;
            this.rbWomann.TabStop = true;
            this.rbWomann.Text = "Жена";
            this.rbWomann.UseVisualStyleBackColor = true;
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Location = new System.Drawing.Point(6, 38);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(63, 24);
            this.rbMan.TabIndex = 0;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "Мъж";
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // lбFлfeldОfШork
            // 
            this.lбFлfeldОfШork.AutoSize = true;
            this.lбFлfeldОfШork.Location = new System.Drawing.Point(204, 40);
            this.lбFлfeldОfШork.Name = "lбFлfeldОfШork";
            this.lбFлfeldОfШork.Size = new System.Drawing.Size(127, 20);
            this.lбFлfeldОfШork.TabIndex = 11;
            this.lбFлfeldОfШork.Text = "Сфера на работа";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(198, 227);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(151, 29);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = "Напред";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(198, 262);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(151, 29);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "Отпечатване";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 302);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lбFлfeldОfШork);
            this.Controls.Add(this.grbGandar);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lblEGN);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmbFieldОfШork);
            this.Name = "FormRegistration";
            this.Text = "Регистрация";
            this.grbGandar.ResumeLayout(false);
            this.grbGandar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColorDialog colorDialog1;
        private ComboBox cmbFieldОfШork;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label lblName;
        private Label lblLastName;
        private Label lblEGN;
        private Label lblMiddleName;
        private GroupBox grbGandar;
        private RadioButton rbWomann;
        private RadioButton rbMan;
        private Label lбFлfeldОfШork;
        private Button btnNext;
        private Button btnPrint;
    }
}