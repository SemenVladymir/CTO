namespace CTO
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.NewClientName = new System.Windows.Forms.TextBox();
            this.NewCarName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CarBrands = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NewCarYear = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ClientPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client full name";
            // 
            // NewClientName
            // 
            this.NewClientName.Location = new System.Drawing.Point(141, 34);
            this.NewClientName.Name = "NewClientName";
            this.NewClientName.Size = new System.Drawing.Size(318, 22);
            this.NewClientName.TabIndex = 1;
            // 
            // NewCarName
            // 
            this.NewCarName.Location = new System.Drawing.Point(141, 213);
            this.NewCarName.Name = "NewCarName";
            this.NewCarName.Size = new System.Drawing.Size(178, 22);
            this.NewCarName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Brand of car";
            // 
            // CarBrands
            // 
            this.CarBrands.FormattingEnabled = true;
            this.CarBrands.Location = new System.Drawing.Point(141, 149);
            this.CarBrands.Name = "CarBrands";
            this.CarBrands.Size = new System.Drawing.Size(240, 24);
            this.CarBrands.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name of car";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Year of car manufacture";
            // 
            // NewCarYear
            // 
            this.NewCarYear.Location = new System.Drawing.Point(212, 270);
            this.NewCarYear.Name = "NewCarYear";
            this.NewCarYear.Size = new System.Drawing.Size(107, 22);
            this.NewCarYear.TabIndex = 6;
            this.NewCarYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewCarYear_KeyPress);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(51, 332);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(152, 50);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(293, 332);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(152, 50);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ClientPhone
            // 
            this.ClientPhone.Location = new System.Drawing.Point(141, 88);
            this.ClientPhone.Name = "ClientPhone";
            this.ClientPhone.Size = new System.Drawing.Size(318, 22);
            this.ClientPhone.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Client phone";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 409);
            this.Controls.Add(this.ClientPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NewCarYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CarBrands);
            this.Controls.Add(this.NewCarName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewClientName);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "New client adding";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewClientName;
        private System.Windows.Forms.TextBox NewCarName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CarBrands;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NewCarYear;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox ClientPhone;
        private System.Windows.Forms.Label label5;
    }
}