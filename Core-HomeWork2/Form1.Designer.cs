namespace Core_HomeWork2
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
            comboBoxCategory = new ComboBox();
            txtBoxName = new TextBox();
            txtBoxDescription = new TextBox();
            txtBoxPrice = new TextBox();
            button1 = new Button();
            listViewProducts = new ListView();
            SuspendLayout();
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.Font = new Font("Segoe UI", 13F);
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(635, 12);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(273, 38);
            comboBoxCategory.TabIndex = 1;
            comboBoxCategory.SelectionChangeCommitted += comboBoxCategory_SelectionChangeCommitted;
            // 
            // txtBoxName
            // 
            txtBoxName.Font = new Font("Segoe UI", 12F);
            txtBoxName.Location = new Point(635, 93);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.PlaceholderText = "Name";
            txtBoxName.Size = new Size(273, 34);
            txtBoxName.TabIndex = 2;
            txtBoxName.Tag = "";
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.Font = new Font("Segoe UI", 12F);
            txtBoxDescription.Location = new Point(635, 160);
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.PlaceholderText = "Description";
            txtBoxDescription.Size = new Size(273, 34);
            txtBoxDescription.TabIndex = 3;
            // 
            // txtBoxPrice
            // 
            txtBoxPrice.Font = new Font("Segoe UI", 12F);
            txtBoxPrice.Location = new Point(635, 226);
            txtBoxPrice.Name = "txtBoxPrice";
            txtBoxPrice.PlaceholderText = "Price";
            txtBoxPrice.Size = new Size(273, 34);
            txtBoxPrice.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.SpringGreen;
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(656, 275);
            button1.Name = "button1";
            button1.Size = new Size(235, 53);
            button1.TabIndex = 5;
            button1.Text = "Add Product";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonAdd_Click;
            // 
            // listViewProducts
            // 
            listViewProducts.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listViewProducts.Location = new Point(17, 18);
            listViewProducts.Name = "listViewProducts";
            listViewProducts.Size = new Size(557, 301);
            listViewProducts.TabIndex = 6;
            listViewProducts.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 340);
            Controls.Add(listViewProducts);
            Controls.Add(button1);
            Controls.Add(txtBoxPrice);
            Controls.Add(txtBoxDescription);
            Controls.Add(txtBoxName);
            Controls.Add(comboBoxCategory);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBoxCategory;
        private TextBox txtBoxName;
        private TextBox txtBoxDescription;
        private TextBox txtBoxPrice;
        private Button button1;
        private ListView listViewProducts;
    }
}
