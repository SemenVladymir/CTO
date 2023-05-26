namespace CTO
{
    partial class Form8
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
            this.label3 = new System.Windows.Forms.Label();
            this.Parts = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SetTime = new System.Windows.Forms.DateTimePicker();
            this.btnOk = new System.Windows.Forms.Button();
            this.lRepairers = new System.Windows.Forms.Label();
            this.Repairers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Operations = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CarName = new System.Windows.Forms.Label();
            this.lClients = new System.Windows.Forms.Label();
            this.ClientFIO = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NewPart = new System.Windows.Forms.Button();
            this.AddPart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Part = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Cost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.ComboBox();
            this.EndTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(718, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Parts list";
            // 
            // Parts
            // 
            this.Parts.FormattingEnabled = true;
            this.Parts.ItemHeight = 16;
            this.Parts.Location = new System.Drawing.Point(596, 130);
            this.Parts.Name = "Parts";
            this.Parts.Size = new System.Drawing.Size(308, 148);
            this.Parts.TabIndex = 38;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(549, 312);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(155, 46);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SetTime
            // 
            this.SetTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.SetTime.Location = new System.Drawing.Point(224, 67);
            this.SetTime.Name = "SetTime";
            this.SetTime.Size = new System.Drawing.Size(163, 22);
            this.SetTime.TabIndex = 36;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(193, 312);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(169, 46);
            this.btnOk.TabIndex = 35;
            this.btnOk.Text = "Accept";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lRepairers
            // 
            this.lRepairers.AutoSize = true;
            this.lRepairers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lRepairers.Location = new System.Drawing.Point(593, 71);
            this.lRepairers.Name = "lRepairers";
            this.lRepairers.Size = new System.Drawing.Size(68, 16);
            this.lRepairers.TabIndex = 34;
            this.lRepairers.Text = "Repairer";
            // 
            // Repairers
            // 
            this.Repairers.FormattingEnabled = true;
            this.Repairers.Location = new System.Drawing.Point(676, 63);
            this.Repairers.Name = "Repairers";
            this.Repairers.Size = new System.Drawing.Size(228, 24);
            this.Repairers.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Start and end time and date";
            // 
            // Operations
            // 
            this.Operations.FormattingEnabled = true;
            this.Operations.Location = new System.Drawing.Point(115, 117);
            this.Operations.Name = "Operations";
            this.Operations.Size = new System.Drawing.Size(337, 24);
            this.Operations.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Operation";
            // 
            // CarName
            // 
            this.CarName.AutoSize = true;
            this.CarName.Location = new System.Drawing.Point(718, 23);
            this.CarName.Name = "CarName";
            this.CarName.Size = new System.Drawing.Size(28, 16);
            this.CarName.TabIndex = 28;
            this.CarName.Text = "Сar";
            // 
            // lClients
            // 
            this.lClients.AutoSize = true;
            this.lClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lClients.Location = new System.Drawing.Point(21, 23);
            this.lClients.Name = "lClients";
            this.lClients.Size = new System.Drawing.Size(46, 16);
            this.lClients.TabIndex = 23;
            this.lClients.Text = "Сlient";
            // 
            // ClientFIO
            // 
            this.ClientFIO.AutoSize = true;
            this.ClientFIO.Location = new System.Drawing.Point(74, 23);
            this.ClientFIO.Name = "ClientFIO";
            this.ClientFIO.Size = new System.Drawing.Size(61, 16);
            this.ClientFIO.TabIndex = 40;
            this.ClientFIO.Text = "СlientFIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(660, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Car";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(418, 23);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(46, 16);
            this.Phone.TabIndex = 43;
            this.Phone.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(319, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "Сlient phone";
            // 
            // NewPart
            // 
            this.NewPart.Location = new System.Drawing.Point(407, 219);
            this.NewPart.Name = "NewPart";
            this.NewPart.Size = new System.Drawing.Size(168, 41);
            this.NewPart.TabIndex = 47;
            this.NewPart.Text = "Add new part";
            this.NewPart.UseVisualStyleBackColor = true;
            this.NewPart.Click += new System.EventHandler(this.NewPart_Click);
            // 
            // AddPart
            // 
            this.AddPart.Location = new System.Drawing.Point(407, 162);
            this.AddPart.Name = "AddPart";
            this.AddPart.Size = new System.Drawing.Size(168, 41);
            this.AddPart.TabIndex = 46;
            this.AddPart.Text = "Add part to list --->";
            this.AddPart.UseVisualStyleBackColor = true;
            this.AddPart.Click += new System.EventHandler(this.AddPart_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(21, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 45;
            this.label5.Text = "Parts";
            // 
            // Part
            // 
            this.Part.FormattingEnabled = true;
            this.Part.Location = new System.Drawing.Point(115, 167);
            this.Part.Name = "Part";
            this.Part.Size = new System.Drawing.Size(276, 24);
            this.Part.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(21, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 48;
            this.label7.Text = "Cost";
            // 
            // Cost
            // 
            this.Cost.Location = new System.Drawing.Point(115, 212);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(100, 22);
            this.Cost.TabIndex = 49;
            this.Cost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cost_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(21, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 50;
            this.label8.Text = "Status";
            // 
            // Status
            // 
            this.Status.FormattingEnabled = true;
            this.Status.Location = new System.Drawing.Point(115, 253);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(192, 24);
            this.Status.TabIndex = 51;
            // 
            // EndTime
            // 
            this.EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndTime.Location = new System.Drawing.Point(407, 66);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(163, 22);
            this.EndTime.TabIndex = 52;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 378);
            this.Controls.Add(this.EndTime);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NewPart);
            this.Controls.Add(this.AddPart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Part);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ClientFIO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Parts);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.SetTime);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lRepairers);
            this.Controls.Add(this.Repairers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Operations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CarName);
            this.Controls.Add(this.lClients);
            this.Name = "Form8";
            this.Text = "Order information";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Parts;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.DateTimePicker SetTime;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lRepairers;
        public System.Windows.Forms.ComboBox Repairers;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox Operations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CarName;
        private System.Windows.Forms.Label lClients;
        private System.Windows.Forms.Label ClientFIO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button NewPart;
        private System.Windows.Forms.Button AddPart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Part;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox Cost;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox Status;
        public System.Windows.Forms.DateTimePicker EndTime;
    }
}