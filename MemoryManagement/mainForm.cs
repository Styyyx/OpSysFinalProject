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
        bool bestFit = true;
        Random rand = new Random();

        public mainForm()
        {
            InitializeComponent();
            tboxOSMemory.Focus();
        }

        #region Queue System
        private void addItem(string task)
        {
            string jobName = tboxProcessName.Text, jobSize = "";
            QueueItem queueItem = new QueueItem();
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

            queueItem.Name = $"[{task}][{jobName}][{jobSize}]";
            queueItem.Size = new System.Drawing.Size(panelQueue.Width, 25);
            queueItem.Location = new System.Drawing.Point(left, top);
            top += 25;

            panelQueue.Controls.Add(queueItem);

            queueItem.btnRmvQueItem.Click += new System.EventHandler(removeTask);
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

            addItem("alloc");
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
            bool jobExists = false;
            foreach (QueueItem qItem in panelQueue.Controls)
            {
                if (qItem.JobName == tboxProcessName.Text)
                {
                    jobExists = true;
                }
            }
            if (jobExists)
            {
                addItem("dealloc");
            }
            else
            {
                MessageBox.Show("Job was never allocated");
            }
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
            if (tboxTotalMemory.Text == "")
            {
                MessageBox.Show("Total Memory Not Set");
                return;
            }
            if (tboxOSMemory.Text == "")
            {
                MessageBox.Show("OS Memory Not Set");
                return;
            }
            else
            {
                SimList.Clear();
                totalMemory = Convert.ToInt32(tboxTotalMemory.Text);
                osMemory = Convert.ToInt32(tboxOSMemory.Text);

                QueueItem osItem = new QueueItem();
                osItem.Task = "Alloc";
                osItem.JobName = "OS";
                osItem.JobSize = osMemory;
                simAlloc(osItem);
            }
        }

        public void addCompacJob(object sender, EventArgs e)
        {
            addItem("compac");
            tboxProcessName.Text = "";
            tboxSize.Text = "";
        }


        #endregion

        #region Simulation System

        List<SimItem> SimList = new List<SimItem>() { };

        private void RefreshPanelSimualation()
        {
            panelSimulation.Controls.Clear();
            CheckFreeMemory();
            foreach (SimItem item in SimList.ToList())
            {
                item.Visible = true;
                panelSimulation.Controls.Add(item);
            }
        }

        private void CheckFreeMemory()
        {
            int lastBot = 0;
            foreach (SimItem item in SimList.ToList())
            {
                if (SimList.Last() == item)
                {
                    int lastItemBot = item.Top + item.Height, memSize = totalMemory - (item.jobMemoryStart+item.jobSize);
                    AddFreeMemory(lastBot, item.Top - lastBot, memSize);

                    // if item is last but there is still space after it
                    if ((lastItemBot) != panelSimulation.Height)
                    {
                        AddFreeMemory(lastItemBot, panelSimulation.Height - lastItemBot, memSize);
                    }
                    return;
                }

                if (item.Top == lastBot)
                {
                    lastBot += item.Height;
                }
                else
                {
                    int height = item.Top - lastBot, memSize = totalMemory - (item.jobMemoryStart + item.jobSize);
                    AddFreeMemory(lastBot, height, memSize);
                    lastBot += height + item.Height;
                }
            }
        }

        private void AddFreeMemory(int top, int height, int memorySize)
        {
            // Add free memory block
            SimItem freeMem = new SimItem();

            freeMem.Top = top;
            freeMem.Width = panelSimulation.Width;
            freeMem.Height = height;
            freeMem.Text = $"Free Memory: {memorySize} KB";
            freeMem.Visible = false;
            freeMem.ForeColor = Color.Black;
            freeMem.BackColor = Color.White;

            SimList.Add(freeMem);
        }
        private void Simulate(object sender, EventArgs e)
        {
            SimList.Clear();
            currentSimTop = 0;
            currentMemoryStart = 0;
            btnSetMemory.PerformClick();
            bestFit = (rbtnBestFit.Checked) ? true : false;
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
            RefreshPanelSimualation();
        }

        int currentSimTop = 0;
        int currentMemoryStart = 0;

        private void simAlloc(QueueItem qItem)
        {
            SimItem simItem = new SimItem();

            int simItemHeight = Convert.ToInt32(((float)qItem.JobSize / (float)totalMemory) * (float)panelSimulation.Height);

            simItem.Name = $"[{qItem.Task}][{qItem.JobName}][{qItem.JobSize}]";
            simItem.Size = new System.Drawing.Size(panelSimulation.Width, simItemHeight);
            int R = rand.Next(0, 255), G = rand.Next(0, 255), B = rand.Next(0, 255);
            simItem.BackColor = Color.FromArgb(R, G, B);
            simItem.ForeColor = (75 > (0.2126 * R + 0.7152 * G + 0.0722 * B)) ? Color.White : Color.Black;
            simItem.Text = $"{qItem.JobName}: {qItem.JobSize} KB";

            simItem.jobMemoryStart = currentMemoryStart;
            simItem.jobSize = qItem.JobSize;
            simItem.jobName = qItem.JobName;

            simItem.Location = new System.Drawing.Point(0, currentSimTop);
            currentSimTop += simItemHeight;
            currentMemoryStart += simItem.jobSize;

            SimList.Add(simItem);
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
