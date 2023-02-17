namespace PizzaOrderForm
{
    partial class Form1
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.comboPizzaType = new System.Windows.Forms.ComboBox();
            this.groupSize = new System.Windows.Forms.GroupBox();
            this.radioLarge = new System.Windows.Forms.RadioButton();
            this.radioMedium = new System.Windows.Forms.RadioButton();
            this.radioSmall = new System.Windows.Forms.RadioButton();
            this.btnOrder = new System.Windows.Forms.Button();
            this.gBToppings = new System.Windows.Forms.GroupBox();
            this.cB5ChS = new System.Windows.Forms.CheckBox();
            this.cB4K = new System.Windows.Forms.CheckBox();
            this.cB3G = new System.Windows.Forms.CheckBox();
            this.cB2Ch = new System.Windows.Forms.CheckBox();
            this.cB1M = new System.Windows.Forms.CheckBox();
            this.groupSize.SuspendLayout();
            this.gBToppings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(13, 18);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(141, 28);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Избери пица";
            // 
            // comboPizzaType
            // 
            this.comboPizzaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPizzaType.FormattingEnabled = true;
            this.comboPizzaType.Items.AddRange(new object[] {
            "Маргарита",
            "Калцоне",
            "4 Сирена",
            "Веган",
            "Вегетарианска"});
            this.comboPizzaType.Location = new System.Drawing.Point(13, 50);
            this.comboPizzaType.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.comboPizzaType.Name = "comboPizzaType";
            this.comboPizzaType.Size = new System.Drawing.Size(148, 36);
            this.comboPizzaType.TabIndex = 1;
            // 
            // groupSize
            // 
            this.groupSize.BackColor = System.Drawing.Color.White;
            this.groupSize.Controls.Add(this.radioLarge);
            this.groupSize.Controls.Add(this.radioMedium);
            this.groupSize.Controls.Add(this.radioSmall);
            this.groupSize.Location = new System.Drawing.Point(208, 50);
            this.groupSize.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupSize.Name = "groupSize";
            this.groupSize.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupSize.Size = new System.Drawing.Size(192, 184);
            this.groupSize.TabIndex = 0;
            this.groupSize.TabStop = false;
            this.groupSize.Text = "Размер";
            // 
            // radioLarge
            // 
            this.radioLarge.AutoSize = true;
            this.radioLarge.Location = new System.Drawing.Point(10, 133);
            this.radioLarge.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.radioLarge.Name = "radioLarge";
            this.radioLarge.Size = new System.Drawing.Size(103, 32);
            this.radioLarge.TabIndex = 6;
            this.radioLarge.TabStop = true;
            this.radioLarge.Text = "Голяма";
            this.radioLarge.UseVisualStyleBackColor = true;
            // 
            // radioMedium
            // 
            this.radioMedium.AutoSize = true;
            this.radioMedium.Location = new System.Drawing.Point(10, 85);
            this.radioMedium.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.radioMedium.Name = "radioMedium";
            this.radioMedium.Size = new System.Drawing.Size(103, 32);
            this.radioMedium.TabIndex = 5;
            this.radioMedium.TabStop = true;
            this.radioMedium.Text = "Средна";
            this.radioMedium.UseVisualStyleBackColor = true;
            // 
            // radioSmall
            // 
            this.radioSmall.AutoSize = true;
            this.radioSmall.Location = new System.Drawing.Point(10, 41);
            this.radioSmall.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.radioSmall.Name = "radioSmall";
            this.radioSmall.Size = new System.Drawing.Size(97, 32);
            this.radioSmall.TabIndex = 4;
            this.radioSmall.TabStop = true;
            this.radioSmall.Text = "Малка";
            this.radioSmall.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(208, 258);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(192, 80);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Поръчай";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // gBToppings
            // 
            this.gBToppings.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gBToppings.Controls.Add(this.cB5ChS);
            this.gBToppings.Controls.Add(this.cB4K);
            this.gBToppings.Controls.Add(this.cB3G);
            this.gBToppings.Controls.Add(this.cB2Ch);
            this.gBToppings.Controls.Add(this.cB1M);
            this.gBToppings.Location = new System.Drawing.Point(13, 96);
            this.gBToppings.Margin = new System.Windows.Forms.Padding(4);
            this.gBToppings.Name = "gBToppings";
            this.gBToppings.Padding = new System.Windows.Forms.Padding(4);
            this.gBToppings.Size = new System.Drawing.Size(176, 242);
            this.gBToppings.TabIndex = 4;
            this.gBToppings.TabStop = false;
            this.gBToppings.Text = "Добавки";
            // 
            // cB5ChS
            // 
            this.cB5ChS.AutoSize = true;
            this.cB5ChS.Location = new System.Drawing.Point(9, 204);
            this.cB5ChS.Margin = new System.Windows.Forms.Padding(4);
            this.cB5ChS.Name = "cB5ChS";
            this.cB5ChS.Size = new System.Drawing.Size(144, 32);
            this.cB5ChS.TabIndex = 4;
            this.cB5ChS.Text = "Чеснов сос";
            this.cB5ChS.UseVisualStyleBackColor = true;
            // 
            // cB4K
            // 
            this.cB4K.AutoSize = true;
            this.cB4K.Location = new System.Drawing.Point(9, 162);
            this.cB4K.Margin = new System.Windows.Forms.Padding(4);
            this.cB4K.Name = "cB4K";
            this.cB4K.Size = new System.Drawing.Size(102, 32);
            this.cB4K.TabIndex = 3;
            this.cB4K.Text = "Кетчуп\r\n";
            this.cB4K.UseVisualStyleBackColor = true;
            // 
            // cB3G
            // 
            this.cB3G.AutoSize = true;
            this.cB3G.Location = new System.Drawing.Point(9, 120);
            this.cB3G.Margin = new System.Windows.Forms.Padding(4);
            this.cB3G.Name = "cB3G";
            this.cB3G.Size = new System.Drawing.Size(115, 32);
            this.cB3G.TabIndex = 2;
            this.cB3G.Text = "Горчица\r\n";
            this.cB3G.UseVisualStyleBackColor = true;
            // 
            // cB2Ch
            // 
            this.cB2Ch.AutoSize = true;
            this.cB2Ch.Location = new System.Drawing.Point(9, 78);
            this.cB2Ch.Margin = new System.Windows.Forms.Padding(4);
            this.cB2Ch.Name = "cB2Ch";
            this.cB2Ch.Size = new System.Drawing.Size(121, 32);
            this.cB2Ch.TabIndex = 1;
            this.cB2Ch.Text = "Чубрица\r\n";
            this.cB2Ch.UseVisualStyleBackColor = true;
            // 
            // cB1M
            // 
            this.cB1M.AutoSize = true;
            this.cB1M.Location = new System.Drawing.Point(9, 36);
            this.cB1M.Margin = new System.Windows.Forms.Padding(4);
            this.cB1M.Name = "cB1M";
            this.cB1M.Size = new System.Drawing.Size(133, 32);
            this.cB1M.TabIndex = 0;
            this.cB1M.Text = "Майонеза";
            this.cB1M.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(425, 362);
            this.Controls.Add(this.gBToppings);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.groupSize);
            this.Controls.Add(this.comboPizzaType);
            this.Controls.Add(this.lbl1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Поръчка на пица";
            this.groupSize.ResumeLayout(false);
            this.groupSize.PerformLayout();
            this.gBToppings.ResumeLayout(false);
            this.gBToppings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl1;
        private ComboBox comboPizzaType;
        private GroupBox groupSize;
        private RadioButton radioLarge;
        private RadioButton radioMedium;
        private RadioButton radioSmall;
        private Button btnOrder;
        private GroupBox gBToppings;
        private CheckBox cB5ChS;
        private CheckBox cB4K;
        private CheckBox cB3G;
        private CheckBox cB2Ch;
        private CheckBox cB1M;
    }
}