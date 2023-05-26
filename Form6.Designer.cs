namespace CTO
{
    partial class Form6
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
            this.PartCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PartName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CarBrand = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // PartCost
            // 
            this.PartCost.Location = new System.Drawing.Point(126, 104);
            this.PartCost.Name = "PartCost";
            this.PartCost.Size = new System.Drawing.Size(109, 22);
            this.PartCost.TabIndex = 7;
            this.PartCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PartCost_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Part cost";
            // 
            // PartName
            // 
            this.PartName.Location = new System.Drawing.Point(126, 12);
            this.PartName.Name = "PartName";
            this.PartName.Size = new System.Drawing.Size(279, 22);
            this.PartName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Part name";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(253, 165);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(163, 35);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(41, 165);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(160, 35);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "Accept";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Car brand";
            // 
            // CarBrand
            // 
            this.CarBrand.FormattingEnabled = true;
            this.CarBrand.Location = new System.Drawing.Point(126, 59);
            this.CarBrand.Name = "CarBrand";
            this.CarBrand.Size = new System.Drawing.Size(279, 24);
            this.CarBrand.TabIndex = 11;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 222);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CarBrand);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.PartCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PartName);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "New part adding";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PartCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PartName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CarBrand;
    }
}