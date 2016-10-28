namespace ProxifierKeygen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxKeyOutput = new System.Windows.Forms.TextBox();
            this.checkBoxCustomKeyPart = new System.Windows.Forms.CheckBox();
            this.labelProduct = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBoxExpiration = new System.Windows.Forms.CheckBox();
            this.textBoxCustomKeyPart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerate.Location = new System.Drawing.Point(12, 211);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(352, 45);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "GENERATE";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Proxifier Standard Edition",
            "Proxifier Portable Edition",
            "Proxifier for Mac"});
            this.comboBox1.Location = new System.Drawing.Point(148, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // textBoxKeyOutput
            // 
            this.textBoxKeyOutput.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKeyOutput.Location = new System.Drawing.Point(12, 143);
            this.textBoxKeyOutput.Name = "textBoxKeyOutput";
            this.textBoxKeyOutput.ReadOnly = true;
            this.textBoxKeyOutput.Size = new System.Drawing.Size(352, 32);
            this.textBoxKeyOutput.TabIndex = 3;
            this.textBoxKeyOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBoxCustomKeyPart
            // 
            this.checkBoxCustomKeyPart.AutoSize = true;
            this.checkBoxCustomKeyPart.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCustomKeyPart.Location = new System.Drawing.Point(71, 60);
            this.checkBoxCustomKeyPart.Name = "checkBoxCustomKeyPart";
            this.checkBoxCustomKeyPart.Size = new System.Drawing.Size(129, 17);
            this.checkBoxCustomKeyPart.TabIndex = 4;
            this.checkBoxCustomKeyPart.Text = "Custom 4th key part";
            this.checkBoxCustomKeyPart.UseVisualStyleBackColor = true;
            this.checkBoxCustomKeyPart.CheckedChanged += new System.EventHandler(this.checkBoxCustomKeyPart_CheckedChanged);
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduct.Location = new System.Drawing.Point(68, 25);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(47, 13);
            this.labelProduct.TabIndex = 6;
            this.labelProduct.Text = "Product";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MMMM yyyy";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(165, 93);
            this.dateTimePicker1.MaxDate = new System.DateTime(3001, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 2, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // checkBoxExpiration
            // 
            this.checkBoxExpiration.AutoSize = true;
            this.checkBoxExpiration.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxExpiration.Location = new System.Drawing.Point(71, 98);
            this.checkBoxExpiration.Name = "checkBoxExpiration";
            this.checkBoxExpiration.Size = new System.Drawing.Size(88, 17);
            this.checkBoxExpiration.TabIndex = 10;
            this.checkBoxExpiration.Text = "Expiring key";
            this.checkBoxExpiration.UseVisualStyleBackColor = true;
            this.checkBoxExpiration.CheckedChanged += new System.EventHandler(this.checkBoxExpiration_CheckedChanged);
            // 
            // textBoxCustomKeyPart
            // 
            this.textBoxCustomKeyPart.Enabled = false;
            this.textBoxCustomKeyPart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomKeyPart.Location = new System.Drawing.Point(234, 57);
            this.textBoxCustomKeyPart.MaxLength = 5;
            this.textBoxCustomKeyPart.Name = "textBoxCustomKeyPart";
            this.textBoxCustomKeyPart.Size = new System.Drawing.Size(72, 23);
            this.textBoxCustomKeyPart.TabIndex = 11;
            this.textBoxCustomKeyPart.TextChanged += new System.EventHandler(this.textBoxCustomKeyPart_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "The key was automatically copied to the clipboard";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 268);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCustomKeyPart);
            this.Controls.Add(this.checkBoxExpiration);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.checkBoxCustomKeyPart);
            this.Controls.Add(this.textBoxKeyOutput);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Proxifier Keygen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxKeyOutput;
        private System.Windows.Forms.CheckBox checkBoxCustomKeyPart;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBoxExpiration;
        private System.Windows.Forms.TextBox textBoxCustomKeyPart;
        private System.Windows.Forms.Label label1;
    }
}

