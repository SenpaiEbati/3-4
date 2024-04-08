namespace _3_4
{
    partial class Main_F
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Spisok_LB = new System.Windows.Forms.ListBox();
            this.AddProduct_GB = new System.Windows.Forms.GroupBox();
            this.Manufacturer = new System.Windows.Forms.Label();
            this.Manufacturer_TB = new System.Windows.Forms.TextBox();
            this.AddProduct_B = new System.Windows.Forms.Button();
            this.DelProduct_B = new System.Windows.Forms.Button();
            this.Weight_NUD = new System.Windows.Forms.NumericUpDown();
            this.Weight_L = new System.Windows.Forms.Label();
            this.Name_L = new System.Windows.Forms.Label();
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.Spisok_L = new System.Windows.Forms.Label();
            this.DeliveryList_GB = new System.Windows.Forms.GroupBox();
            this.DelDeliveryList_NUD = new System.Windows.Forms.NumericUpDown();
            this.SumWeightDeliveryList_L = new System.Windows.Forms.Label();
            this.SumWeightDeliveryList_TB = new System.Windows.Forms.TextBox();
            this.SumWeightDeliveryList_B = new System.Windows.Forms.Button();
            this.CheckDeliveryList_GB = new System.Windows.Forms.Button();
            this.DelDeliveryList_B = new System.Windows.Forms.Button();
            this.AddDeliveryList_B = new System.Windows.Forms.Button();
            this.Quantity_TB = new System.Windows.Forms.TextBox();
            this.Quantity_L = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AddProduct_GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Weight_NUD)).BeginInit();
            this.DeliveryList_GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelDeliveryList_NUD)).BeginInit();
            this.SuspendLayout();
            // 
            // Spisok_LB
            // 
            this.Spisok_LB.FormattingEnabled = true;
            this.Spisok_LB.Location = new System.Drawing.Point(12, 25);
            this.Spisok_LB.Name = "Spisok_LB";
            this.Spisok_LB.Size = new System.Drawing.Size(314, 537);
            this.Spisok_LB.TabIndex = 1;
            // 
            // AddProduct_GB
            // 
            this.AddProduct_GB.Controls.Add(this.Manufacturer);
            this.AddProduct_GB.Controls.Add(this.Manufacturer_TB);
            this.AddProduct_GB.Controls.Add(this.AddProduct_B);
            this.AddProduct_GB.Controls.Add(this.DelProduct_B);
            this.AddProduct_GB.Controls.Add(this.Weight_NUD);
            this.AddProduct_GB.Controls.Add(this.Weight_L);
            this.AddProduct_GB.Controls.Add(this.Name_L);
            this.AddProduct_GB.Controls.Add(this.Name_TB);
            this.AddProduct_GB.Location = new System.Drawing.Point(332, 9);
            this.AddProduct_GB.Name = "AddProduct_GB";
            this.AddProduct_GB.Size = new System.Drawing.Size(252, 249);
            this.AddProduct_GB.TabIndex = 2;
            this.AddProduct_GB.TabStop = false;
            this.AddProduct_GB.Text = "Добавлени&е товара";
            // 
            // Manufacturer
            // 
            this.Manufacturer.AutoSize = true;
            this.Manufacturer.Location = new System.Drawing.Point(6, 73);
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.Size = new System.Drawing.Size(86, 13);
            this.Manufacturer.TabIndex = 2;
            this.Manufacturer.Text = "&Производитель";
            // 
            // Manufacturer_TB
            // 
            this.Manufacturer_TB.Location = new System.Drawing.Point(137, 73);
            this.Manufacturer_TB.Name = "Manufacturer_TB";
            this.Manufacturer_TB.Size = new System.Drawing.Size(109, 20);
            this.Manufacturer_TB.TabIndex = 3;
            // 
            // AddProduct_B
            // 
            this.AddProduct_B.Location = new System.Drawing.Point(9, 157);
            this.AddProduct_B.Name = "AddProduct_B";
            this.AddProduct_B.Size = new System.Drawing.Size(237, 23);
            this.AddProduct_B.TabIndex = 6;
            this.AddProduct_B.Text = "&Добавить товар";
            this.AddProduct_B.UseVisualStyleBackColor = true;
            this.AddProduct_B.Click += new System.EventHandler(this.AddProduct_B_Click);
            // 
            // DelProduct_B
            // 
            this.DelProduct_B.Location = new System.Drawing.Point(9, 200);
            this.DelProduct_B.Name = "DelProduct_B";
            this.DelProduct_B.Size = new System.Drawing.Size(237, 23);
            this.DelProduct_B.TabIndex = 7;
            this.DelProduct_B.Text = "&Удалить товар";
            this.DelProduct_B.UseVisualStyleBackColor = true;
            this.DelProduct_B.Click += new System.EventHandler(this.DelProduct_B_Click);
            // 
            // Weight_NUD
            // 
            this.Weight_NUD.DecimalPlaces = 1;
            this.Weight_NUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Weight_NUD.Location = new System.Drawing.Point(178, 119);
            this.Weight_NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Weight_NUD.Name = "Weight_NUD";
            this.Weight_NUD.Size = new System.Drawing.Size(68, 20);
            this.Weight_NUD.TabIndex = 5;
            this.Weight_NUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // Weight_L
            // 
            this.Weight_L.AutoSize = true;
            this.Weight_L.Location = new System.Drawing.Point(7, 121);
            this.Weight_L.Name = "Weight_L";
            this.Weight_L.Size = new System.Drawing.Size(64, 13);
            this.Weight_L.TabIndex = 4;
            this.Weight_L.Text = "&Вес товара";
            // 
            // Name_L
            // 
            this.Name_L.AutoSize = true;
            this.Name_L.Location = new System.Drawing.Point(6, 31);
            this.Name_L.Name = "Name_L";
            this.Name_L.Size = new System.Drawing.Size(95, 13);
            this.Name_L.TabIndex = 0;
            this.Name_L.Text = "&Название товара";
            // 
            // Name_TB
            // 
            this.Name_TB.Location = new System.Drawing.Point(137, 31);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(109, 20);
            this.Name_TB.TabIndex = 1;
            // 
            // Spisok_L
            // 
            this.Spisok_L.AutoSize = true;
            this.Spisok_L.Location = new System.Drawing.Point(12, 9);
            this.Spisok_L.Name = "Spisok_L";
            this.Spisok_L.Size = new System.Drawing.Size(88, 13);
            this.Spisok_L.TabIndex = 0;
            this.Spisok_L.Text = "&Список товаров";
            // 
            // DeliveryList_GB
            // 
            this.DeliveryList_GB.Controls.Add(this.DelDeliveryList_NUD);
            this.DeliveryList_GB.Controls.Add(this.SumWeightDeliveryList_L);
            this.DeliveryList_GB.Controls.Add(this.SumWeightDeliveryList_TB);
            this.DeliveryList_GB.Controls.Add(this.SumWeightDeliveryList_B);
            this.DeliveryList_GB.Controls.Add(this.CheckDeliveryList_GB);
            this.DeliveryList_GB.Controls.Add(this.DelDeliveryList_B);
            this.DeliveryList_GB.Controls.Add(this.AddDeliveryList_B);
            this.DeliveryList_GB.Controls.Add(this.Quantity_TB);
            this.DeliveryList_GB.Controls.Add(this.Quantity_L);
            this.DeliveryList_GB.Location = new System.Drawing.Point(332, 264);
            this.DeliveryList_GB.Name = "DeliveryList_GB";
            this.DeliveryList_GB.Size = new System.Drawing.Size(252, 301);
            this.DeliveryList_GB.TabIndex = 3;
            this.DeliveryList_GB.TabStop = false;
            this.DeliveryList_GB.Text = "Раб&ота со списком поставки";
            // 
            // DelDeliveryList_NUD
            // 
            this.DelDeliveryList_NUD.DecimalPlaces = 1;
            this.DelDeliveryList_NUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.DelDeliveryList_NUD.Location = new System.Drawing.Point(178, 119);
            this.DelDeliveryList_NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.DelDeliveryList_NUD.Name = "DelDeliveryList_NUD";
            this.DelDeliveryList_NUD.Size = new System.Drawing.Size(68, 20);
            this.DelDeliveryList_NUD.TabIndex = 4;
            this.DelDeliveryList_NUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // SumWeightDeliveryList_L
            // 
            this.SumWeightDeliveryList_L.AutoSize = true;
            this.SumWeightDeliveryList_L.Location = new System.Drawing.Point(7, 272);
            this.SumWeightDeliveryList_L.Name = "SumWeightDeliveryList_L";
            this.SumWeightDeliveryList_L.Size = new System.Drawing.Size(88, 13);
            this.SumWeightDeliveryList_L.TabIndex = 7;
            this.SumWeightDeliveryList_L.Text = "С&уммарный вес";
            // 
            // SumWeightDeliveryList_TB
            // 
            this.SumWeightDeliveryList_TB.Location = new System.Drawing.Point(137, 269);
            this.SumWeightDeliveryList_TB.Name = "SumWeightDeliveryList_TB";
            this.SumWeightDeliveryList_TB.ReadOnly = true;
            this.SumWeightDeliveryList_TB.Size = new System.Drawing.Size(109, 20);
            this.SumWeightDeliveryList_TB.TabIndex = 8;
            // 
            // SumWeightDeliveryList_B
            // 
            this.SumWeightDeliveryList_B.Location = new System.Drawing.Point(9, 227);
            this.SumWeightDeliveryList_B.Name = "SumWeightDeliveryList_B";
            this.SumWeightDeliveryList_B.Size = new System.Drawing.Size(237, 23);
            this.SumWeightDeliveryList_B.TabIndex = 6;
            this.SumWeightDeliveryList_B.Text = "Сум&марный вес товаров в списке поставки";
            this.SumWeightDeliveryList_B.UseVisualStyleBackColor = true;
            this.SumWeightDeliveryList_B.Click += new System.EventHandler(this.SumWeightDeliveryList_B_Click);
            // 
            // CheckDeliveryList_GB
            // 
            this.CheckDeliveryList_GB.Location = new System.Drawing.Point(6, 180);
            this.CheckDeliveryList_GB.Name = "CheckDeliveryList_GB";
            this.CheckDeliveryList_GB.Size = new System.Drawing.Size(237, 23);
            this.CheckDeliveryList_GB.TabIndex = 5;
            this.CheckDeliveryList_GB.Text = "Прове&рка указаного товара";
            this.CheckDeliveryList_GB.UseVisualStyleBackColor = true;
            this.CheckDeliveryList_GB.Click += new System.EventHandler(this.CheckDeliveryList_GB_Click);
            // 
            // DelDeliveryList_B
            // 
            this.DelDeliveryList_B.Location = new System.Drawing.Point(10, 119);
            this.DelDeliveryList_B.Name = "DelDeliveryList_B";
            this.DelDeliveryList_B.Size = new System.Drawing.Size(163, 43);
            this.DelDeliveryList_B.TabIndex = 3;
            this.DelDeliveryList_B.Text = "Уда&ление из списка поставки менее заданного";
            this.DelDeliveryList_B.UseVisualStyleBackColor = true;
            this.DelDeliveryList_B.Click += new System.EventHandler(this.DelDeliveryList_B_Click);
            // 
            // AddDeliveryList_B
            // 
            this.AddDeliveryList_B.Location = new System.Drawing.Point(9, 75);
            this.AddDeliveryList_B.Name = "AddDeliveryList_B";
            this.AddDeliveryList_B.Size = new System.Drawing.Size(237, 23);
            this.AddDeliveryList_B.TabIndex = 2;
            this.AddDeliveryList_B.Text = "Добавлен&ие в список поставки товара";
            this.AddDeliveryList_B.UseVisualStyleBackColor = true;
            this.AddDeliveryList_B.Click += new System.EventHandler(this.AddDeliveryList_B_Click);
            // 
            // Quantity_TB
            // 
            this.Quantity_TB.Location = new System.Drawing.Point(137, 33);
            this.Quantity_TB.Name = "Quantity_TB";
            this.Quantity_TB.ReadOnly = true;
            this.Quantity_TB.Size = new System.Drawing.Size(109, 20);
            this.Quantity_TB.TabIndex = 1;
            // 
            // Quantity_L
            // 
            this.Quantity_L.AutoSize = true;
            this.Quantity_L.Location = new System.Drawing.Point(7, 36);
            this.Quantity_L.Name = "Quantity_L";
            this.Quantity_L.Size = new System.Drawing.Size(110, 13);
            this.Quantity_L.TabIndex = 0;
            this.Quantity_L.Text = "&Количество товаров";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(645, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(648, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(648, 125);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(88, 20);
            this.textBox2.TabIndex = 6;
            // 
            // Main_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 577);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeliveryList_GB);
            this.Controls.Add(this.Spisok_L);
            this.Controls.Add(this.AddProduct_GB);
            this.Controls.Add(this.Spisok_LB);
            this.Name = "Main_F";
            this.Text = "Универсальные типы .NET Framework";
            this.AddProduct_GB.ResumeLayout(false);
            this.AddProduct_GB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Weight_NUD)).EndInit();
            this.DeliveryList_GB.ResumeLayout(false);
            this.DeliveryList_GB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelDeliveryList_NUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Spisok_LB;
        private System.Windows.Forms.GroupBox AddProduct_GB;
        private System.Windows.Forms.Button AddProduct_B;
        private System.Windows.Forms.Button DelProduct_B;
        private System.Windows.Forms.NumericUpDown Weight_NUD;
        private System.Windows.Forms.Label Weight_L;
        private System.Windows.Forms.Label Name_L;
        private System.Windows.Forms.TextBox Name_TB;
        private System.Windows.Forms.Label Spisok_L;
        private System.Windows.Forms.GroupBox DeliveryList_GB;
        private System.Windows.Forms.Label SumWeightDeliveryList_L;
        private System.Windows.Forms.TextBox SumWeightDeliveryList_TB;
        private System.Windows.Forms.Button SumWeightDeliveryList_B;
        private System.Windows.Forms.Button CheckDeliveryList_GB;
        private System.Windows.Forms.Button DelDeliveryList_B;
        private System.Windows.Forms.Button AddDeliveryList_B;
        private System.Windows.Forms.TextBox Quantity_TB;
        private System.Windows.Forms.Label Quantity_L;
        private System.Windows.Forms.NumericUpDown DelDeliveryList_NUD;
        private System.Windows.Forms.Label Manufacturer;
        private System.Windows.Forms.TextBox Manufacturer_TB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

