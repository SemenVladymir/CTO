namespace CTO
{
    partial class UserControl1
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClientFIO = new System.Windows.Forms.Label();
            this.Car = new System.Windows.Forms.Label();
            this.Operation = new System.Windows.Forms.Label();
            this.Master = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.NumberId = new System.Windows.Forms.Label();
            this.StartTime = new System.Windows.Forms.Label();
            this.EndTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClientFIO
            // 
            this.ClientFIO.AutoSize = true;
            this.ClientFIO.Location = new System.Drawing.Point(43, 19);
            this.ClientFIO.Name = "ClientFIO";
            this.ClientFIO.Size = new System.Drawing.Size(61, 16);
            this.ClientFIO.TabIndex = 0;
            this.ClientFIO.Text = "ClientFIO";
            // 
            // Car
            // 
            this.Car.AutoSize = true;
            this.Car.Location = new System.Drawing.Point(264, 19);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(28, 16);
            this.Car.TabIndex = 1;
            this.Car.Text = "Car";
            // 
            // Operation
            // 
            this.Operation.AutoSize = true;
            this.Operation.Location = new System.Drawing.Point(390, 19);
            this.Operation.Name = "Operation";
            this.Operation.Size = new System.Drawing.Size(66, 16);
            this.Operation.TabIndex = 2;
            this.Operation.Text = "Operation";
            // 
            // Master
            // 
            this.Master.AutoSize = true;
            this.Master.Location = new System.Drawing.Point(846, 19);
            this.Master.Name = "Master";
            this.Master.Size = new System.Drawing.Size(48, 16);
            this.Master.TabIndex = 3;
            this.Master.Text = "Master";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(1082, 19);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(44, 16);
            this.Status.TabIndex = 4;
            this.Status.Text = "Status";
            // 
            // NumberId
            // 
            this.NumberId.AutoSize = true;
            this.NumberId.Location = new System.Drawing.Point(16, 19);
            this.NumberId.Name = "NumberId";
            this.NumberId.Size = new System.Drawing.Size(21, 16);
            this.NumberId.TabIndex = 5;
            this.NumberId.Text = "№";
            // 
            // StartTime
            // 
            this.StartTime.AutoSize = true;
            this.StartTime.Location = new System.Drawing.Point(537, 19);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(59, 16);
            this.StartTime.TabIndex = 6;
            this.StartTime.Text = "Star time";
            // 
            // EndTime
            // 
            this.EndTime.AutoSize = true;
            this.EndTime.Location = new System.Drawing.Point(681, 19);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(59, 16);
            this.EndTime.TabIndex = 7;
            this.EndTime.Text = "End time";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.EndTime);
            this.Controls.Add(this.StartTime);
            this.Controls.Add(this.NumberId);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Master);
            this.Controls.Add(this.Operation);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.ClientFIO);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1175, 63);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClientFIO;
        private System.Windows.Forms.Label Car;
        private System.Windows.Forms.Label Operation;
        private System.Windows.Forms.Label Master;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label NumberId;
        private System.Windows.Forms.Label StartTime;
        private System.Windows.Forms.Label EndTime;
    }
}
