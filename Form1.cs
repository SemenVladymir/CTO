using CTO.Controls;
using CTO.Tables;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CTO
{
    public partial class Form1 : Form
    {
        Panel panel;
        SQLConnection connect = new SQLConnection();
        List<TimeTable> table = new List<TimeTable>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel = new Panel();
            panel.SuspendLayout();
            panel.Location = new Point(5, 50);
            panel.Size = new Size(this.Width - 160, this.Height-100);
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.AutoScroll = true;
            panel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            Controls.Add(panel);
            Resize += Form1_Resize;

            All.Checked = true;
            foreach(Control item in groupBox1.Controls)
                item.MouseClick += GroupBox1_Click;

            table = connect.GetListOperationsFromTimeTable();
            ShowTimeTable(table);
            GotFocus += Form1_GotFocus1;

        }

        private void Form1_GotFocus1(object sender, EventArgs e)
        {
            table.Clear();
            table = connect.GetListOperationsFromTimeTable();
            ShowTimeTable(table);
        }

        private void GroupBox1_Click(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (!radio.Text.Equals("All"))
                {
                List<StatusOfWork> status = connect.GetListStatusOfWork();
                int statusId = status.Find(ee => ee.Status.Equals(radio.Text)).StatusId;
                List<TimeTable>  newTimeTable = table.FindAll(ee => ee.StatusId == statusId);
                ShowTimeTable(newTimeTable);
            }
            else
                ShowTimeTable(table);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            foreach (Control item in panel.Controls)
                item.Size = new Size(panel.Width, item.Height);
        }

        private void ShowTimeTable(List<TimeTable> table)
        {
            panel.Controls.Clear();
            int y = 0;
            for (int i = 0; i < table.Count; i++)
            {
                var item = new UserControl1(table[i]);
                item.Location = new Point(0, (y * item.Height));
                item.BackColor = System.Drawing.SystemColors.ControlLight;
                item.Anchor = System.Windows.Forms.AnchorStyles.Left | AnchorStyles.Right;

                y++;
                panel.Controls.Add(item);
            }
        }

        private void AddOrder_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
            newForm.Deactivate += (s, ee) => 
            {
                table.Clear();
                table = connect.GetListOperationsFromTimeTable();
                ShowTimeTable(table);
            };
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
