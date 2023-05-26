namespace CTO
{
    partial class Form2
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
            this.lClients = new System.Windows.Forms.Label();
            this.Clients = new System.Windows.Forms.ComboBox();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnAddOperation = new System.Windows.Forms.Button();
            this.Cars = new System.Windows.Forms.ComboBox();
            this.lCars = new System.Windows.Forms.Label();
            this.Operations = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Repairers = new System.Windows.Forms.ComboBox();
            this.lRepairers = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.SetTime = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Parts = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddRepairer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lClients
            // 
            this.lClients.AutoSize = true;
            this.lClients.Location = new System.Drawing.Point(149, 19);
            this.lClients.Name = "lClients";
            this.lClients.Size = new System.Drawing.Size(83, 16);
            this.lClients.TabIndex = 0;
            this.lClients.Text = "Сlient choice";
            // 
            // Clients
            // 
            this.Clients.FormattingEnabled = true;
            this.Clients.Location = new System.Drawing.Point(26, 44);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(372, 24);
            this.Clients.TabIndex = 1;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(35, 326);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(121, 46);
            this.btnAddClient.TabIndex = 2;
            this.btnAddClient.Text = "Add new client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(172, 326);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(114, 46);
            this.btnAddCar.TabIndex = 3;
            this.btnAddCar.Text = "Add new car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnAddOperation
            // 
            this.btnAddOperation.Location = new System.Drawing.Point(302, 326);
            this.btnAddOperation.Name = "btnAddOperation";
            this.btnAddOperation.Size = new System.Drawing.Size(135, 46);
            this.btnAddOperation.TabIndex = 4;
            this.btnAddOperation.Text = "Add new operation";
            this.btnAddOperation.UseVisualStyleBackColor = true;
            this.btnAddOperation.Click += new System.EventHandler(this.btnAddOperation_Click);
            // 
            // Cars
            // 
            this.Cars.FormattingEnabled = true;
            this.Cars.Location = new System.Drawing.Point(480, 45);
            this.Cars.Name = "Cars";
            this.Cars.Size = new System.Drawing.Size(285, 24);
            this.Cars.TabIndex = 6;
            // 
            // lCars
            // 
            this.lCars.AutoSize = true;
            this.lCars.Location = new System.Drawing.Point(573, 19);
            this.lCars.Name = "lCars";
            this.lCars.Size = new System.Drawing.Size(71, 16);
            this.lCars.TabIndex = 5;
            this.lCars.Text = "Сar choice";
            // 
            // Operations
            // 
            this.Operations.FormattingEnabled = true;
            this.Operations.Location = new System.Drawing.Point(424, 260);
            this.Operations.Name = "Operations";
            this.Operations.Size = new System.Drawing.Size(337, 24);
            this.Operations.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Operation choice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Start time and date";
            // 
            // Repairers
            // 
            this.Repairers.FormattingEnabled = true;
            this.Repairers.Location = new System.Drawing.Point(424, 122);
            this.Repairers.Name = "Repairers";
            this.Repairers.Size = new System.Drawing.Size(341, 24);
            this.Repairers.TabIndex = 13;
            // 
            // lRepairers
            // 
            this.lRepairers.AutoSize = true;
            this.lRepairers.Location = new System.Drawing.Point(541, 84);
            this.lRepairers.Name = "lRepairers";
            this.lRepairers.Size = new System.Drawing.Size(103, 16);
            this.lRepairers.TabIndex = 15;
            this.lRepairers.Text = "Repairer choice";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(480, 326);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(159, 61);
            this.btnOk.TabIndex = 16;
            this.btnOk.Text = "Accept";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click_1);
            // 
            // SetTime
            // 
            this.SetTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.SetTime.Location = new System.Drawing.Point(38, 120);
            this.SetTime.Name = "SetTime";
            this.SetTime.Size = new System.Drawing.Size(222, 22);
            this.SetTime.TabIndex = 18;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(664, 326);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 61);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Parts
            // 
            this.Parts.FormattingEnabled = true;
            this.Parts.ItemHeight = 16;
            this.Parts.Location = new System.Drawing.Point(38, 200);
            this.Parts.Name = "Parts";
            this.Parts.Size = new System.Drawing.Size(308, 84);
            this.Parts.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Parts list";
            // 
            // AddRepairer
            // 
            this.AddRepairer.Location = new System.Drawing.Point(513, 164);
            this.AddRepairer.Name = "AddRepairer";
            this.AddRepairer.Size = new System.Drawing.Size(154, 36);
            this.AddRepairer.TabIndex = 22;
            this.AddRepairer.Text = "Add new repairer";
            this.AddRepairer.UseVisualStyleBackColor = true;
            this.AddRepairer.Click += new System.EventHandler(this.AddRepairer_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 412);
            this.Controls.Add(this.AddRepairer);
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
            this.Controls.Add(this.Cars);
            this.Controls.Add(this.lCars);
            this.Controls.Add(this.btnAddOperation);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.Clients);
            this.Controls.Add(this.lClients);
            this.Name = "Form2";
            this.Text = "Adding new order";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lClients;
        private System.Windows.Forms.ComboBox Clients;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnAddOperation;
        private System.Windows.Forms.ComboBox Cars;
        private System.Windows.Forms.Label lCars;
        private System.Windows.Forms.ComboBox Operations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Repairers;
        private System.Windows.Forms.Label lRepairers;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DateTimePicker SetTime;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox Parts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddRepairer;
    }
}