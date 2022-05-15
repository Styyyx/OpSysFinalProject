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
        public mainForm()
        {
            InitializeComponent();
        }


        //-------------------------------------------------------------

        private void allocJob(object sender, EventArgs e)
        {
            if (tboxProcessName.Text == "" || tboxSize.Text == "")
            {
                MessageBox.Show("Invalid");
                return;
            }

            // validation: check for existing job

            System.Windows.Forms.Label lblAlloc = new System.Windows.Forms.Label();

            int left = 0, top = 0;
            lblAlloc.BackColor = System.Drawing.Color.GreenYellow;
            lblAlloc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblAlloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAlloc.Name = "labelDynamic";
            lblAlloc.Size = new System.Drawing.Size(panelQueue.Width,25);
            lblAlloc.TabIndex = 0;
            lblAlloc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblAlloc.Location = new System.Drawing.Point(left, top);
            lblAlloc.Text = $"Allocate: {tboxProcessName.Text} {tboxSize.Text} KB ";

            this.panelQueue.Controls.Add(lblAlloc);
        }

        public void deallocJob(object sender, EventArgs e)
        {
            
            System.Windows.Forms.Label lblDeAlloc = new System.Windows.Forms.Label();
            this.Controls.Add(lblDeAlloc);


            lblDeAlloc.BackColor = System.Drawing.Color.OrangeRed;
            lblDeAlloc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblDeAlloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDeAlloc.Name = "labelDynamic";
            lblDeAlloc.Size = new System.Drawing.Size(250, 27);
            lblDeAlloc.TabIndex = 0;
            lblDeAlloc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblDeAlloc.Location = new System.Drawing.Point(left, top);
            // top += 35;

            lblDeAlloc.Text = "Deallocate:"+tboxProcessName.Text + " (" + tboxSize.Text + "KB )";
        }

        private void buttonCompact_Click(object sender, EventArgs e)
        {
            addNewLabelcompact();
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


            // lblCompact.Location = new System.Drawing.Point(left, top);
            // top += 35;
            lblCompact.Text = "Compact";

            return lblCompact;
        }

        //-------------------------------------------------------------
    }
}
