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
        List<SimItem> SimList = new List<SimItem>() { };
        SimItem osSimItem = new SimItem();

        public mainForm()
        {
            InitializeComponent();
            tboxOSMemory.Focus();
            tboxOSMemory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxOnKeyPress);
            tboxTotalMemory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxOnKeyPress);
            tboxSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxOnKeyPress);
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
            if (tboxProcessName.Text == "OS" || tboxProcessName.Text == "Free Memory")
            {
                MessageBox.Show("Process Name is reserved");
            }
            else
            {
                // validation: check for existing job
                foreach (QueueItem qItem in panelQueue.Controls)
                {
                    if (qItem.JobName == tboxProcessName.Text)
                    {
                        MessageBox.Show("Job has already been allocated");
                        return;
                    }
                }
                addItem("alloc");
                tboxProcessName.Text = "";
                tboxSize.Text = "";
            }
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

        public void addCompacJob(object sender, EventArgs e)
        {
            addItem("compac");
            tboxProcessName.Text = "";
            tboxSize.Text = "";
        }
        #endregion

        private void SetMemory(object sender, EventArgs e)
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
            if (SimList.Any(item => item.jobName == "OS"))
            {
                SimList.RemoveAll(item => item.jobName == "OS");
            }

            SimList.Clear();
            panelSimulation.Controls.Clear();

            totalMemory = Convert.ToInt32(tboxTotalMemory.Text);
            osMemory = Convert.ToInt32(tboxOSMemory.Text);


            osSimItem.jobName = "OS";
            osSimItem.jobSize = osMemory;
            osSimItem.jobMemoryStart = 0;
            osSimItem.Height = Convert.ToInt32(((float)osMemory / (float)totalMemory) * (float)panelSimulation.Height);
            osSimItem.Width = panelSimulation.Width;
            osSimItem.BackColor = Color.White;
            osSimItem.ForeColor = Color.Black;
            osSimItem.Text = $"OS: {osMemory} KB";

            SimList.Add(osSimItem);
            panelSimulation.Controls.Add(osSimItem);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns>
        /// (backColor, foreColor)
        /// </returns>
        private (Color, Color) GetRandomColor()
        {
            Color backColor, foreColor;
            int R = rand.Next(0, 255), G = rand.Next(0, 255), B = rand.Next(0, 255);
            backColor = Color.FromArgb(R, G, B);

            // Forecolor depends if BackColor too dark based on luma coefficients
            foreColor = (75 > (0.2126 * R + 0.7152 * G + 0.0722 * B)) ? Color.White : Color.Black;

            return (backColor, foreColor);
        }

        private void tboxOnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }

        #region Simulation System

        private void AddFreeMemory(int top, int height, int memorySize, int jobMemoryStart)
        {
            // Add free memory block
            SimItem freeMem = new SimItem();

            freeMem.Top = top;
            freeMem.Width = panelSimulation.Width;
            freeMem.Height = height;
            freeMem.Text = $"Free Memory: {memorySize} KB";
            freeMem.Visible = true;
            freeMem.ForeColor = Color.Black;
            freeMem.BackColor = Color.White;
            freeMem.jobName = "Free Memory";
            freeMem.jobSize = memorySize;
            freeMem.jobMemoryStart = jobMemoryStart;

            SimList.Add(freeMem);
            panelSimulation.Controls.Add(freeMem);
        }

        private void CompacFreeMemory()
        {
            List<SimItem> CopySimList = SimList.ToList();
            foreach (SimItem item in CopySimList)
            {
                // Check if item and next item is free memory
                if (item.jobName == "Free Memory")
                {
                    // Check if last to avoid going out of index
                    if (item != SimList.Last())
                    {
                        // Check if next item is free memory
                        SimItem nextItem = CopySimList[CopySimList.IndexOf(item) + 1];
                        if (nextItem.jobName == "Free Memory")
                        {
                            // Add current free memory to next one
                            nextItem.jobSize += item.jobSize;
                            nextItem.jobMemoryStart = item.jobMemoryStart;
                            nextItem.Top = item.Top;
                            nextItem.Height += item.Height;
                            nextItem.Text = $"Free Memory: {nextItem.jobSize} KB";

                            SimList[SimList.IndexOf(item) + 1] = nextItem;
                            SimList.Remove(item);
                            panelSimulation.Controls.Remove(item);
                        }
                    }
                }
            }
        }

        private void Simulate(object sender, EventArgs e)
        {
            try
            {
                panelSimulation.Controls.Clear();
                SimList.Clear();
                bestFit = (rbtnBestFit.Checked) ? true : false;

                SetMemory(sender, e);
                AddFreeMemory(osSimItem.Height, panelSimulation.Height - osSimItem.Height, totalMemory - osMemory, osMemory);

                foreach (QueueItem qItem in panelQueue.Controls)
                {
                    if (qItem.Task == "compac")
                    {
                        simCompac();
                    }
                    else if (qItem.Task == "dealloc")
                    {
                        simDealloc(qItem);
                    }
                    else
                    {
                        simAlloc(qItem);
                    }
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void SliceFreeMemory(QueueItem qItem, SimItem freeMem)
        {
            SimItem newItem = new SimItem();
            // Set properties of new item to be allocated
            newItem.Name = qItem.Name;
            newItem.jobName = qItem.JobName;
            newItem.jobSize = qItem.JobSize;
            newItem.jobMemoryStart = freeMem.jobMemoryStart;
            newItem.Text = $"{newItem.jobName}: {newItem.jobSize} KB";
            (Color newBackColor, Color newForeColor) = GetRandomColor();
            newItem.BackColor = newBackColor;
            newItem.ForeColor = newForeColor;
            newItem.Top = freeMem.Top;
            newItem.Height = Convert.ToInt32(((float)qItem.JobSize / (float)totalMemory) * (float)panelSimulation.Height);
            newItem.Width = panelSimulation.Width;

            SimList.Insert(SimList.IndexOf(freeMem), newItem);
            panelSimulation.Controls.Add(newItem);

            // Adjust free memory properties
            freeMem.Top += newItem.Height;
            freeMem.jobSize -= newItem.jobSize;
            freeMem.Height -= newItem.Height;
            freeMem.jobMemoryStart += newItem.jobSize;
            freeMem.Text = $"Free Memory: {freeMem.jobSize} KB";
        }

        private void simAlloc(QueueItem qItem)
        {
            // Find the smallest free memory
            SimItem bestMemoryFit = null;
            foreach (SimItem item in SimList.ToList())
            {
                if (item.jobName == "Free Memory" && item.jobSize >= qItem.JobSize)
                {
                    if (bestMemoryFit == null)
                    {
                        bestMemoryFit = item;

                        // First Fit
                        if (!bestFit)
                        {
                            SliceFreeMemory(qItem, bestMemoryFit);
                            return;
                        }
                    }
                    else
                    {
                        if (bestMemoryFit.jobSize > item.jobSize) { bestMemoryFit = item; }
                    }
                }
            }
            if (bestMemoryFit != null)
            {
                if (bestMemoryFit.jobSize == qItem.JobSize)
                {
                    bestMemoryFit.jobName = qItem.JobName;
                    bestMemoryFit.Text = $"{qItem.JobName}: {bestMemoryFit.jobSize} KB";

                    (Color back, Color fore) = GetRandomColor();
                    bestMemoryFit.BackColor = back;
                    bestMemoryFit.ForeColor = fore;

                    return;
                }
                // Free memory bigger so need to slice
                else
                {
                    SliceFreeMemory(qItem, bestMemoryFit);
                }
            }
            else { MessageBox.Show($"Job {qItem.JobName} of size {qItem.JobSize}KB cannot be fit in any free memory, need to compact or deallocate some other jobs"); }
        }

        private void simDealloc(QueueItem qItem)
        {
            foreach (SimItem simItem in SimList)
            {
                if (simItem.jobName == qItem.JobName)
                {
                    // Convert item to free memory
                    simItem.jobName = "Free Memory";
                    simItem.BackColor = Color.White;
                    simItem.ForeColor = Color.Black;
                    simItem.Text = $"Free Memory: {simItem.jobSize} KB";
                    CompacFreeMemory();
                    return;
                }
            }
        }

        private void simCompac()
        {
            // Shallow copy
            foreach (SimItem item in SimList.ToList())
            {
                // OS will always be on top, no need to 
                if (item.jobName != "Free Memory" && SimList.Last() != item && item.jobName != "OS")
                {
                    SimItem lastItem = SimList[SimList.IndexOf(item) - 1];
                    if (lastItem.jobName == "Free Memory")
                    {
                        //Swap current item and next item in SimList
                        SimItem tempItem = SimList[SimList.IndexOf(item)];
                        SimList[SimList.IndexOf(item)] = SimList[SimList.IndexOf(lastItem)];

                        int tempTop = item.Top + item.Height, tempMemoryStart = item.jobMemoryStart + item.jobSize;

                        tempItem.Top = lastItem.Top;
                        tempItem.jobMemoryStart = lastItem.jobMemoryStart;

                        lastItem.Top = item.Top + item.Height;
                        lastItem.jobMemoryStart = tempMemoryStart;

                        SimList[SimList.IndexOf(lastItem)] = tempItem;
                    }
                }
                CompacFreeMemory();
            }
        }

        #endregion
    }
}
