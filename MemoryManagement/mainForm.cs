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

        int top = 150;
        int left = 550;
        private void buttonAllocate_Click(object sender, EventArgs e)
        {
            addNewLabelallocation();
        }
        public System.Windows.Forms.Label addNewLabelallocation()
        {
            System.Windows.Forms.Label lblAlloc = new System.Windows.Forms.Label();
            this.Controls.Add(lblAlloc);



            lblAlloc.BackColor = System.Drawing.Color.GreenYellow;
            lblAlloc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblAlloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAlloc.Name = "labelDynamic";
            lblAlloc.Size = new System.Drawing.Size(250,27);
            lblAlloc.TabIndex = 0;
            lblAlloc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            lblAlloc.Location = new System.Drawing.Point(left, top);
            top += 35;
  
            lblAlloc.Text = "Allocate:" + textBoxProcessName.Text + " (" + textBoxSizekb.Text + "KB )";
            return lblAlloc;
        }

        private void labelDynamic_Click(object sender, EventArgs e)
        {

        }

     

        private void buttonDeallocate_Click(object sender, EventArgs e)
        {
            addNewLabeldeallocation();
        }
        public System.Windows.Forms.Label addNewLabeldeallocation()
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

            lblDeAlloc.Location = new System.Drawing.Point(left, top);
            top += 35;

            lblDeAlloc.Text = "Deallocate:"+textBoxProcessName.Text + " (" + textBoxSizekb.Text + "KB )";
            return lblDeAlloc;
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


            lblCompact.Location = new System.Drawing.Point(left, top);
            top += 35;
            lblCompact.Text = "Compact";

            return lblCompact;
        }

        //-------------------------------------------------------------
    }
}
