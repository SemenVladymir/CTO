namespace CTO
{
    partial class Form5
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
            this.Operation = new System.Windows.Forms.TextBox();
            this.Cost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Part = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PartList = new System.Windows.Forms.ListBox();
            this.AddPart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "New operation";
            // 
            // Operation
            // 
            this.Operation.Location = new System.Drawing.Point(140, 25);
            this.Operation.Name = "Operation";
            this.Operation.Size = new System.Drawing.Size(279, 22);
            this.Operation.TabIndex = 1;
            // 
            // Cost
            // 
            this.Cost.Location = new System.Drawing.Point(585, 25);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(103, 22);
            this.Cost.TabIndex = 3;
            this.Cost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cost_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Operation cost";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(114, 263);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(205, 49);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Accept";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(448, 263);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(205, 49);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Part
            // 
            this.Part.FormattingEnabled = true;
            this.Part.Location = new System.Drawing.Point(140, 89);
            this.Part.Name = "Part";
            this.Part.Size = new System.Drawing.Size(276, 24);
            this.Part.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Parts";
            // 
            // PartList
            // 
            this.PartList.FormattingEnabled = true;
            this.PartList.ItemHeight = 16;
            this.PartList.Location = new System.Drawing.Point(477, 80);
            this.PartList.Name = "PartList";
            this.PartList.Size = new System.Drawing.Size(265, 148);
            this.PartList.TabIndex = 8;
            // 
            // AddPart
            // 
            this.AddPart.Location = new System.Drawing.Point(292, 143);
            this.AddPart.Name = "AddPart";
            this.AddPart.Size = new System.Drawing.Size(168, 40);
            this.AddPart.TabIndex = 9;
            this.AddPart.Text = "Select part to list --->";
            this.AddPart.UseVisualStyleBackColor = true;
            this.AddPart.Click += new System.EventHandler(this.AddPart_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add new part";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 329);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddPart);
            this.Controls.Add(this.PartList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Part);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Operation);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Operation and part adding";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Operation;
        private System.Windows.Forms.TextBox Cost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox Part;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox PartList;
        private System.Windows.Forms.Button AddPart;
        private System.Windows.Forms.Button button1;
    }
}