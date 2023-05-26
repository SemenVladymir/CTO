namespace CTO
{
    partial class Form4
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
            this.Clients = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.NewCarYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CarBrands = new System.Windows.Forms.ComboBox();
            this.NewCarName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client";
            // 
            // Clients
            // 
            this.Clients.FormattingEnabled = true;
            this.Clients.Location = new System.Drawing.Point(108, 33);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(311, 24);
            this.Clients.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(278, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(152, 50);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(53, 276);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(152, 50);
            this.btnOk.TabIndex = 16;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Year of car manufacture";
            // 
            // NewCarYear
            // 
            this.NewCarYear.Location = new System.Drawing.Point(214, 214);
            this.NewCarYear.Name = "NewCarYear";
            this.NewCarYear.Size = new System.Drawing.Size(107, 22);
            this.NewCarYear.TabIndex = 14;
            this.NewCarYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewCarYear_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Name of car";
            // 
            // CarBrands
            // 
            this.CarBrands.FormattingEnabled = true;
            this.CarBrands.Location = new System.Drawing.Point(143, 93);
            this.CarBrands.Name = "CarBrands";
            this.CarBrands.Size = new System.Drawing.Size(240, 24);
            this.CarBrands.TabIndex = 12;
            // 
            // NewCarName
            // 
            this.NewCarName.Location = new System.Drawing.Point(143, 157);
            this.NewCarName.Name = "NewCarName";
            this.NewCarName.Size = new System.Drawing.Size(178, 22);
            this.NewCarName.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Brand of car";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 360);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NewCarYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CarBrands);
            this.Controls.Add(this.NewCarName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Clients);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "New car adding";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Clients;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NewCarYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CarBrands;
        private System.Windows.Forms.TextBox NewCarName;
        private System.Windows.Forms.Label label2;
    }
}