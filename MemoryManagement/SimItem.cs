using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryManagement
{
    internal class SimItem : Label
    {
        public int jobMemoryStart;
        public int jobSize;
        public string jobName;
        //public int jobColor;

        public SimItem()
        {
            // General Properties
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabIndex = 0;
            this.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Visible = true;
            this.AutoSize = false;
        }
    }
}
