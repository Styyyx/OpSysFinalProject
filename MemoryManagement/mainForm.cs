﻿using System;
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
        List<Process> processList = new List<Process>();

        public mainForm()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------
        private void addQueueItem(string task)
        {
            
            Label queueItem = new System.Windows.Forms.Label();
            string jobName = tboxProcessName.Text, jobSize="";
            if (task == "dealloc")
            {
                jobSize = "0";
                queueItem.BackColor = System.Drawing.Color.OrangeRed;
                queueItem.Text = $"Deallocate: {jobName} KB ";
            } 
            else
            {
                jobSize = tboxSize.Text;
                queueItem.BackColor = System.Drawing.Color.GreenYellow;
                queueItem.Text = $"Allocate: {jobName} {jobSize} KB ";
            }
            processList.Add(new Process(task, jobName, Convert.ToInt32(jobSize)));

            
            queueItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            queueItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            queueItem.Name = $"[{task}][{jobName}][{jobSize}]";
            queueItem.Size = new System.Drawing.Size(panelQueue.Width, 25);
            queueItem.TabIndex = 0;
            queueItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            queueItem.Location = new System.Drawing.Point(left, top);
            top += 25;

            panelQueue.Controls.Add(queueItem);
        }

        private void addAllocJob(object sender, EventArgs e)
        {
            if (tboxProcessName.Text == "" || tboxSize.Text == "")
            {
                MessageBox.Show("Invalid");
                return;
            }

            addQueueItem("alloc");
            // validation: check for existing job
        }

        public void addDeallocJob(object sender, EventArgs e)
        {
            addQueueItem("dealloc");
        }

        public System.Windows.Forms.Label addNewLabelcompact()
        {
            System.Windows.Forms.Label lblCompact = new System.Windows.Forms.Label();
            this.Controls.Add(lblCompact);


            lblCompact.BackColor = System.Drawing.Color.Gray;
            lblCompact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblCompact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCompact.Name = "labelDynamic";
            lblCompact.Size = new System.Drawing.Size(250, 27);
            lblCompact.TabIndex = 0;
            lblCompact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblCompact.Text = "Compact";

            return lblCompact;
        }

        //-------------------------------------------------------------
    }
}