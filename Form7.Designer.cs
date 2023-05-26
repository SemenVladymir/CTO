namespace CTO
{
    partial class Form7
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
            this.label2 = new System.Windows.Forms.Label();
            this.Select = new System.Windows.Forms.ComboBox();
            this.RepairerName = new System.Windows.Forms.TextBox();
            this.SpecList = new System.Windows.Forms.ListBox();
            this.AddPart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Level = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "New repairer full name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Specialization";
            // 
            // Select
            // 
            this.Select.FormattingEnabled = true;
            this.Select.Location = new System.Drawing.Point(138, 76);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(279, 24);
            this.Select.TabIndex = 8;
            // 
            // RepairerName
            // 
            this.RepairerName.Location = new System.Drawing.Point(176, 31);
            this.RepairerName.Name = "RepairerName";
            this.RepairerName.Size = new System.Drawing.Size(279, 22);
            this.RepairerName.TabIndex = 10;
            // 
            // SpecList
            // 
            this.SpecList.FormattingEnabled = true;
            this.SpecList.ItemHeight = 16;
            this.SpecList.Location = new System.Drawing.Point(492, 31);
            this.SpecList.Name = "SpecList";
            this.SpecList.Size = new System.Drawing.Size(265, 148);
            this.SpecList.TabIndex = 11;
            // 
            // AddPart
            // 
            this.AddPart.Location = new System.Drawing.Point(261, 126);
            this.AddPart.Name = "AddPart";
            this.AddPart.Size = new System.Drawing.Size(207, 40);
            this.AddPart.TabIndex = 12;
            this.AddPart.Text = "Add specialization to list --->";
            this.AddPart.UseVisualStyleBackColor = true;
            this.AddPart.Click += new System.EventHandler(this.AddPart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Level";
            // 
            // Level
            // 
            this.Level.Location = new System.Drawing.Point(138, 138);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(74, 22);
            this.Level.TabIndex = 15;
            this.Level.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Level_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(465, 201);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(205, 49);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(131, 201);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(205, 49);
            this.btnOk.TabIndex = 16;
            this.btnOk.Text = "Accept";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 272);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.Level);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddPart);
            this.Controls.Add(this.SpecList);
            this.Controls.Add(this.RepairerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "Adding new repairer";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Select;
        private System.Windows.Forms.TextBox RepairerName;
        private System.Windows.Forms.ListBox SpecList;
        private System.Windows.Forms.Button AddPart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Level;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}