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
            this.Spisok_L = new System.Windows.Forms.Label();
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.Name_L = new System.Windows.Forms.Label();
            this.Weight_L = new System.Windows.Forms.Label();
            this.Weight_NUD = new System.Windows.Forms.NumericUpDown();
            this.AddProduct_B = new System.Windows.Forms.Button();
            this.DelProduct_B = new System.Windows.Forms.Button();
            this.DeliveryList_GB = new System.Windows.Forms.GroupBox();
            this.Quantity_L = new System.Windows.Forms.Label();
            this.Quantity_TB = new System.Windows.Forms.TextBox();
            this.AddDeliveryList_B = new System.Windows.Forms.Button();
            this.DelDeliveryList_B = new System.Windows.Forms.Button();
            this.CheckDeliveryList_GB = new System.Windows.Forms.Button();
            this.SumWeightDeliveryList_B = new System.Windows.Forms.Button();
            this.SumWeightDeliveryList_TB = new System.Windows.Forms.TextBox();
            this.SumWeightDeliveryList_L = new System.Windows.Forms.Label();
            this.AddProduct_GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Weight_NUD)).BeginInit();
            this.DeliveryList_GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // Spisok_LB
            // 
            this.Spisok_LB.FormattingEnabled = true;
            this.Spisok_LB.Location = new System.Drawing.Point(12, 25);
            this.Spisok_LB.Name = "Spisok_LB";
            this.Spisok_LB.Size = new System.Drawing.Size(314, 537);
            this.Spisok_LB.TabIndex = 0;
            // 
            // AddProduct_GB
            // 
            this.AddProduct_GB.Controls.Add(this.AddProduct_B);
            this.AddProduct_GB.Controls.Add(this.DelProduct_B);
            this.AddProduct_GB.Controls.Add(this.Weight_NUD);
            this.AddProduct_GB.Controls.Add(this.Weight_L);
            this.AddProduct_GB.Controls.Add(this.Name_L);
            this.AddProduct_GB.Controls.Add(this.Name_TB);
            this.AddProduct_GB.Location = new System.Drawing.Point(332, 9);
            this.AddProduct_GB.Name = "AddProduct_GB";
            this.AddProduct_GB.Size = new System.Drawing.Size(252, 192);
            this.AddProduct_GB.TabIndex = 1;
            this.AddProduct_GB.TabStop = false;
            this.AddProduct_GB.Text = "Добавление товара";
            // 
            // Spisok_L
            // 
            this.Spisok_L.AutoSize = true;
            this.Spisok_L.Location = new System.Drawing.Point(12, 9);
            this.Spisok_L.Name = "Spisok_L";
            this.Spisok_L.Size = new System.Drawing.Size(88, 13);
            this.Spisok_L.TabIndex = 2;
            this.Spisok_L.Text = "Список товаров";
            // 
            // Name_TB
            // 
            this.Name_TB.Location = new System.Drawing.Point(137, 31);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(109, 20);
            this.Name_TB.TabIndex = 0;
            // 
            // Name_L
            // 
            this.Name_L.AutoSize = true;
            this.Name_L.Location = new System.Drawing.Point(6, 31);
            this.Name_L.Name = "Name_L";
            this.Name_L.Size = new System.Drawing.Size(95, 13);
            this.Name_L.TabIndex = 1;
            this.Name_L.Text = "Название товара";
            // 
            // Weight_L
            // 
            this.Weight_L.AutoSize = true;
            this.Weight_L.Location = new System.Drawing.Point(7, 74);
            this.Weight_L.Name = "Weight_L";
            this.Weight_L.Size = new System.Drawing.Size(64, 13);
            this.Weight_L.TabIndex = 2;
            this.Weight_L.Text = "Вес товара";
            // 
            // Weight_NUD
            // 
            this.Weight_NUD.Location = new System.Drawing.Point(137, 72);
            this.Weight_NUD.Name = "Weight_NUD";
            this.Weight_NUD.Size = new System.Drawing.Size(68, 20);
            this.Weight_NUD.TabIndex = 3;
            // 
            // AddProduct_B
            // 
            this.AddProduct_B.Location = new System.Drawing.Point(9, 110);
            this.AddProduct_B.Name = "AddProduct_B";
            this.AddProduct_B.Size = new System.Drawing.Size(237, 23);
            this.AddProduct_B.TabIndex = 3;
            this.AddProduct_B.Text = "Добавить товар";
            this.AddProduct_B.UseVisualStyleBackColor = true;
            // 
            // DelProduct_B
            // 
            this.DelProduct_B.Location = new System.Drawing.Point(9, 153);
            this.DelProduct_B.Name = "DelProduct_B";
            this.DelProduct_B.Size = new System.Drawing.Size(237, 23);
            this.DelProduct_B.TabIndex = 3;
            this.DelProduct_B.Text = "Удалить товар";
            this.DelProduct_B.UseVisualStyleBackColor = true;
            // 
            // DeliveryList_GB
            // 
            this.DeliveryList_GB.Controls.Add(this.SumWeightDeliveryList_L);
            this.DeliveryList_GB.Controls.Add(this.SumWeightDeliveryList_TB);
            this.DeliveryList_GB.Controls.Add(this.SumWeightDeliveryList_B);
            this.DeliveryList_GB.Controls.Add(this.CheckDeliveryList_GB);
            this.DeliveryList_GB.Controls.Add(this.DelDeliveryList_B);
            this.DeliveryList_GB.Controls.Add(this.AddDeliveryList_B);
            this.DeliveryList_GB.Controls.Add(this.Quantity_TB);
            this.DeliveryList_GB.Controls.Add(this.Quantity_L);
            this.DeliveryList_GB.Location = new System.Drawing.Point(332, 207);
            this.DeliveryList_GB.Name = "DeliveryList_GB";
            this.DeliveryList_GB.Size = new System.Drawing.Size(252, 355);
            this.DeliveryList_GB.TabIndex = 4;
            this.DeliveryList_GB.TabStop = false;
            this.DeliveryList_GB.Text = "Работа со списком поставки";
            // 
            // Quantity_L
            // 
            this.Quantity_L.AutoSize = true;
            this.Quantity_L.Location = new System.Drawing.Point(7, 36);
            this.Quantity_L.Name = "Quantity_L";
            this.Quantity_L.Size = new System.Drawing.Size(110, 13);
            this.Quantity_L.TabIndex = 0;
            this.Quantity_L.Text = "Количество товаров";
            // 
            // Quantity_TB
            // 
            this.Quantity_TB.Location = new System.Drawing.Point(137, 33);
            this.Quantity_TB.Name = "Quantity_TB";
            this.Quantity_TB.Size = new System.Drawing.Size(109, 20);
            this.Quantity_TB.TabIndex = 1;
            // 
            // AddDeliveryList_B
            // 
            this.AddDeliveryList_B.Location = new System.Drawing.Point(9, 75);
            this.AddDeliveryList_B.Name = "AddDeliveryList_B";
            this.AddDeliveryList_B.Size = new System.Drawing.Size(237, 23);
            this.AddDeliveryList_B.TabIndex = 4;
            this.AddDeliveryList_B.Text = "Добавление в список поставки товара";
            this.AddDeliveryList_B.UseVisualStyleBackColor = true;
            // 
            // DelDeliveryList_B
            // 
            this.DelDeliveryList_B.Location = new System.Drawing.Point(9, 113);
            this.DelDeliveryList_B.Name = "DelDeliveryList_B";
            this.DelDeliveryList_B.Size = new System.Drawing.Size(237, 23);
            this.DelDeliveryList_B.TabIndex = 5;
            this.DelDeliveryList_B.Text = "Удаление из списка поставки ";
            this.DelDeliveryList_B.UseVisualStyleBackColor = true;
            // 
            // CheckDeliveryList_GB
            // 
            this.CheckDeliveryList_GB.Location = new System.Drawing.Point(9, 152);
            this.CheckDeliveryList_GB.Name = "CheckDeliveryList_GB";
            this.CheckDeliveryList_GB.Size = new System.Drawing.Size(237, 23);
            this.CheckDeliveryList_GB.TabIndex = 6;
            this.CheckDeliveryList_GB.Text = "Проверка указаного товара";
            this.CheckDeliveryList_GB.UseVisualStyleBackColor = true;
            // 
            // SumWeightDeliveryList_B
            // 
            this.SumWeightDeliveryList_B.Location = new System.Drawing.Point(9, 193);
            this.SumWeightDeliveryList_B.Name = "SumWeightDeliveryList_B";
            this.SumWeightDeliveryList_B.Size = new System.Drawing.Size(237, 23);
            this.SumWeightDeliveryList_B.TabIndex = 7;
            this.SumWeightDeliveryList_B.Text = "Суммарный вес товаров в списке поставки";
            this.SumWeightDeliveryList_B.UseVisualStyleBackColor = true;
            // 
            // SumWeightDeliveryList_TB
            // 
            this.SumWeightDeliveryList_TB.Location = new System.Drawing.Point(137, 235);
            this.SumWeightDeliveryList_TB.Name = "SumWeightDeliveryList_TB";
            this.SumWeightDeliveryList_TB.Size = new System.Drawing.Size(109, 20);
            this.SumWeightDeliveryList_TB.TabIndex = 8;
            // 
            // SumWeightDeliveryList_L
            // 
            this.SumWeightDeliveryList_L.AutoSize = true;
            this.SumWeightDeliveryList_L.Location = new System.Drawing.Point(7, 238);
            this.SumWeightDeliveryList_L.Name = "SumWeightDeliveryList_L";
            this.SumWeightDeliveryList_L.Size = new System.Drawing.Size(35, 13);
            this.SumWeightDeliveryList_L.TabIndex = 9;
            this.SumWeightDeliveryList_L.Text = "label5";
            // 
            // Main_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 577);
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
    }
}

