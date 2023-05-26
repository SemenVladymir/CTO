namespace CTO
{
    partial class Form1
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
            this.lClient = new System.Windows.Forms.Label();
            this.lCar = new System.Windows.Forms.Label();
            this.lOperation = new System.Windows.Forms.Label();
            this.lMaster = new System.Windows.Forms.Label();
            this.lStatus = new System.Windows.Forms.Label();
            this.AddOrder = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Ended = new System.Windows.Forms.RadioButton();
            this.InAction = new System.Windows.Forms.RadioButton();
            this.WaitingParts = new System.Windows.Forms.RadioButton();
            this.Waiting = new System.Windows.Forms.RadioButton();
            this.All = new System.Windows.Forms.RadioButton();
            this.lStartTime = new System.Windows.Forms.Label();
            this.lEndTime = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lClient
            // 
            this.lClient.AutoSize = true;
            this.lClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lClient.Location = new System.Drawing.Point(68, 38);
            this.lClient.Name = "lClient";
            this.lClient.Size = new System.Drawing.Size(46, 16);
            this.lClient.TabIndex = 0;
            this.lClient.Text = "Client";
            // 
            // lCar
            // 
            this.lCar.AutoSize = true;
            this.lCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCar.Location = new System.Drawing.Point(302, 38);
            this.lCar.Name = "lCar";
            this.lCar.Size = new System.Drawing.Size(31, 16);
            this.lCar.TabIndex = 1;
            this.lCar.Text = "Car";
            // 
            // lOperation
            // 
            this.lOperation.AutoSize = true;
            this.lOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lOperation.Location = new System.Drawing.Point(411, 38);
            this.lOperation.Name = "lOperation";
            this.lOperation.Size = new System.Drawing.Size(75, 16);
            this.lOperation.TabIndex = 2;
            this.lOperation.Text = "Operation";
            // 
            // lMaster
            // 
            this.lMaster.AutoSize = true;
            this.lMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lMaster.Location = new System.Drawing.Point(893, 38);
            this.lMaster.Name = "lMaster";
            this.lMaster.Size = new System.Drawing.Size(54, 16);
            this.lMaster.TabIndex = 3;
            this.lMaster.Text = "Master";
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lStatus.Location = new System.Drawing.Point(1092, 38);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(50, 16);
            this.lStatus.TabIndex = 4;
            this.lStatus.Text = "Status";
            // 
            // AddOrder
            // 
            this.AddOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddOrder.Location = new System.Drawing.Point(1202, 306);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(142, 44);
            this.AddOrder.TabIndex = 6;
            this.AddOrder.Text = "Add order";
            this.AddOrder.UseVisualStyleBackColor = true;
            this.AddOrder.Click += new System.EventHandler(this.AddOrder_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(1202, 396);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 44);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Exit";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "№";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Ended);
            this.groupBox1.Controls.Add(this.InAction);
            this.groupBox1.Controls.Add(this.WaitingParts);
            this.groupBox1.Controls.Add(this.Waiting);
            this.groupBox1.Controls.Add(this.All);
            this.groupBox1.Location = new System.Drawing.Point(1202, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 159);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // Ended
            // 
            this.Ended.AutoSize = true;
            this.Ended.Location = new System.Drawing.Point(7, 126);
            this.Ended.Name = "Ended";
            this.Ended.Size = new System.Drawing.Size(68, 20);
            this.Ended.TabIndex = 4;
            this.Ended.TabStop = true;
            this.Ended.Text = "Ended";
            this.Ended.UseVisualStyleBackColor = true;
            // 
            // InAction
            // 
            this.InAction.AutoSize = true;
            this.InAction.Location = new System.Drawing.Point(7, 100);
            this.InAction.Name = "InAction";
            this.InAction.Size = new System.Drawing.Size(77, 20);
            this.InAction.TabIndex = 3;
            this.InAction.TabStop = true;
            this.InAction.Text = "In action";
            this.InAction.UseVisualStyleBackColor = true;
            // 
            // WaitingParts
            // 
            this.WaitingParts.AutoSize = true;
            this.WaitingParts.Location = new System.Drawing.Point(7, 74);
            this.WaitingParts.Name = "WaitingParts";
            this.WaitingParts.Size = new System.Drawing.Size(106, 20);
            this.WaitingParts.TabIndex = 2;
            this.WaitingParts.TabStop = true;
            this.WaitingParts.Text = "Waiting parts";
            this.WaitingParts.UseVisualStyleBackColor = true;
            // 
            // Waiting
            // 
            this.Waiting.AutoSize = true;
            this.Waiting.Location = new System.Drawing.Point(7, 48);
            this.Waiting.Name = "Waiting";
            this.Waiting.Size = new System.Drawing.Size(73, 20);
            this.Waiting.TabIndex = 1;
            this.Waiting.TabStop = true;
            this.Waiting.Text = "Waiting";
            this.Waiting.UseVisualStyleBackColor = true;
            // 
            // All
            // 
            this.All.AutoSize = true;
            this.All.Location = new System.Drawing.Point(7, 22);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(43, 20);
            this.All.TabIndex = 0;
            this.All.TabStop = true;
            this.All.Text = "All";
            this.All.UseVisualStyleBackColor = true;
            // 
            // lStartTime
            // 
            this.lStartTime.AutoSize = true;
            this.lStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lStartTime.Location = new System.Drawing.Point(578, 38);
            this.lStartTime.Name = "lStartTime";
            this.lStartTime.Size = new System.Drawing.Size(72, 16);
            this.lStartTime.TabIndex = 11;
            this.lStartTime.Text = "Start time";
            // 
            // lEndTime
            // 
            this.lEndTime.AutoSize = true;
            this.lEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lEndTime.Location = new System.Drawing.Point(721, 38);
            this.lEndTime.Name = "lEndTime";
            this.lEndTime.Size = new System.Drawing.Size(67, 16);
            this.lEndTime.TabIndex = 12;
            this.lEndTime.Text = "End time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 488);
            this.Controls.Add(this.lEndTime);
            this.Controls.Add(this.lStartTime);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.AddOrder);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.lMaster);
            this.Controls.Add(this.lOperation);
            this.Controls.Add(this.lCar);
            this.Controls.Add(this.lClient);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label lClient;
        private System.Windows.Forms.Label lCar;
        private System.Windows.Forms.Label lOperation;
        private System.Windows.Forms.Label lMaster;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.Button AddOrder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Ended;
        private System.Windows.Forms.RadioButton InAction;
        private System.Windows.Forms.RadioButton WaitingParts;
        private System.Windows.Forms.RadioButton Waiting;
        private System.Windows.Forms.RadioButton All;
        private System.Windows.Forms.Label lStartTime;
        private System.Windows.Forms.Label lEndTime;
    }
}

