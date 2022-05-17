using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryManagement
{
    internal class QueueItem : Label
    {
        public string Task;
        public string JobName;
        public int JobSize;
        public Button btnRmvQueItem = new Button();

        public QueueItem()
        {
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabIndex = 0;
            this.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            btnRmvQueItem.BackColor = System.Drawing.Color.Red;
            btnRmvQueItem.ForeColor = System.Drawing.Color.Black;
            btnRmvQueItem.Location = new System.Drawing.Point(0, 0);
            btnRmvQueItem.Name = $"btnRmvLbl{this.Name}";
            btnRmvQueItem.Size = new System.Drawing.Size(25, 25);
            btnRmvQueItem.TabIndex = 0;
            btnRmvQueItem.Text = "X";
            btnRmvQueItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            btnRmvQueItem.UseVisualStyleBackColor = false;

            this.Controls.Add(btnRmvQueItem);
        }
    }
}
