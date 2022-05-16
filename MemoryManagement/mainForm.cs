using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace MemoryManagement
{
    public partial class mainForm : Form
    {
        int top = 0, left = 0;
        int totalMemory = 0, osMemory = 0;
        Random rand = new Random();

        public mainForm()
        {
            InitializeComponent();
            tboxOSMemory.Focus();
        }

        #region Queue System
        private void addQueueItem(string task)
        {
            QueueItem queueItem = new QueueItem();
            string jobName = tboxProcessName.Text, jobSize = "";
            if (task == "compac")
            {
                jobName = "0";
                jobSize = "0";
                queueItem.BackColor = System.Drawing.Color.WhiteSmoke;
                queueItem.Text = $"Compaction";
            }
            else if (task == "dealloc")
            {
                jobSize = "0";
                queueItem.BackColor = System.Drawing.Color.OrangeRed;
                queueItem.Text = $"Deallocate: {jobName}";
            }
            else
            {
                jobSize = tboxSize.Text;
                queueItem.BackColor = System.Drawing.Color.GreenYellow;
                queueItem.Text = $"Allocate: {jobName} {jobSize} KB ";
            }

            queueItem.Task = task;
            queueItem.JobName = jobName;
            queueItem.JobSize = Convert.ToInt32(jobSize);

            queueItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            queueItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            queueItem.Name = $"[{task}][{jobName}][{jobSize}]";
            queueItem.Size = new System.Drawing.Size(panelQueue.Width, 25);
            queueItem.TabIndex = 0;
            queueItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            queueItem.Location = new System.Drawing.Point(left, top);
            top += 25;

            panelQueue.Controls.Add(queueItem);

            Button btnRmvQueItem = new Button();
            btnRmvQueItem.BackColor = System.Drawing.Color.Red;
            btnRmvQueItem.ForeColor = System.Drawing.Color.Black;
            btnRmvQueItem.Location = new System.Drawing.Point(0, 0);
            btnRmvQueItem.Name = $"btnRmvLbl{queueItem.Name}";
            btnRmvQueItem.Size = new System.Drawing.Size(25, 25);
            btnRmvQueItem.TabIndex = 0;
            btnRmvQueItem.Text = "X";
            btnRmvQueItem.TextAlign = ContentAlignment.MiddleCenter;
            btnRmvQueItem.UseVisualStyleBackColor = false;
            btnRmvQueItem.Click += new System.EventHandler(removeTask);

            queueItem.Controls.Add(btnRmvQueItem);
        }

        private void removeTask(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            panelQueue.Controls.Remove(btn.Parent);
            int newTop = 0;
            foreach (Control ctrl in panelQueue.Controls)
            {
                Label lbl = ctrl as Label;
                lbl.Top = newTop;
                newTop += 25;
            }
            top = newTop;
        }

        private void addAllocJob(object sender, EventArgs e)
        {
            if (tboxProcessName.Text == "")
            {
                MessageBox.Show("No Name Entered");
                return;
            }
            if (tboxSize.Text == "")
            {
                MessageBox.Show("No Size Entered");
                return;
            }
            // validation: check for existing job

            addQueueItem("alloc");
            tboxProcessName.Text = "";
            tboxSize.Text = "";
        }

        public void addDeallocJob(object sender, EventArgs e)
        {
            if (tboxProcessName.Text == "")
            {
                MessageBox.Show("No Job Name Specified");
                return;
            }
            // validation: check if job exists in queue

            addQueueItem("dealloc");
            tboxProcessName.Text = "";
            tboxSize.Text = "";
        }

        private void clearQueue(object sender, EventArgs e)
        {
            panelQueue.Controls.Clear();
            top = 0;
        }

        private void setMemory(object sender, EventArgs e)
        {
            if (tboxTotalMemory.Text == "" || tboxOSMemory.Text == "")
            {
                MessageBox.Show("Incomplete Input");
                return;
            }
            panelSimulation.Controls.Clear();
            simTop = 0;
            totalMemory = Convert.ToInt32(tboxTotalMemory.Text);
            osMemory = Convert.ToInt32(tboxOSMemory.Text);

            QueueItem osItem = new QueueItem();
            osItem.Task = "Alloc";
            osItem.JobName = "OS";
            osItem.JobSize = osMemory;
            simAlloc(osItem);
        }

        public void addCompacJob(object sender, EventArgs e)
        {
            addQueueItem("compac");
            tboxProcessName.Text = "";
            tboxSize.Text = "";
        }


        #endregion

        #region Simulation System

        int simTop = 0;

        private void Simulate(object sender, EventArgs e)
        {
            panelSimulation.Controls.Clear();
            simTop = 0;
            foreach (QueueItem qItem in panelQueue.Controls)
            {
                if (qItem.Task == "compac")
                {
                    simCompac();
                }
                else if (qItem.Task == "dealloc")
                {
                    simDealloc();
                }
                else
                {
                    simAlloc(qItem);
                }
            }
        }

        private void simAlloc(QueueItem qItem)
        {
            Label simItem = new Label();

            int simItemHeight = Convert.ToInt32(((float)qItem.JobSize / (float)totalMemory) * (float)panelSimulation.Height);

            simItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            simItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            simItem.Name = $"[{qItem.Task}][{qItem.JobName}][{qItem.JobSize}]";
            simItem.Size = new System.Drawing.Size(panelSimulation.Width, simItemHeight);
            simItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            simItem.Location = new System.Drawing.Point(0, simTop);

            int R = rand.Next(0, 255), G = rand.Next(0, 255), B = rand.Next(0, 255);
            simItem.BackColor = Color.FromArgb(R, G, B);
            simItem.ForeColor = (75 > (0.2126 * R + 0.7152 * G + 0.0722 * B)) ? Color.White : Color.Black;
            simItem.Text = $"{qItem.JobName}: {qItem.JobSize} KB";
            simItem.TabIndex = 0;

            simTop += simItem.Height;

            panelSimulation.Controls.Add(simItem);
        }


        private void simDealloc()
        {

        }

        private void radioButtonFirstFit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void simCompac()
        {

        }

        private void addSimItem()
        {

        }

        #endregion
    }
}
