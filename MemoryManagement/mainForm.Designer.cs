namespace MemoryManagement
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelDefMemory = new System.Windows.Forms.Panel();
            this.btnSetMemory = new System.Windows.Forms.Button();
            this.tboxTotalMemory = new System.Windows.Forms.TextBox();
            this.tboxOSMemory = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panelAlloc = new System.Windows.Forms.Panel();
            this.btnDealloc = new System.Windows.Forms.Button();
            this.btnAlloc = new System.Windows.Forms.Button();
            this.tboxSize = new System.Windows.Forms.TextBox();
            this.tboxProcessName = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.panelFitAlgo = new System.Windows.Forms.Panel();
            this.rbtnBestFit = new System.Windows.Forms.RadioButton();
            this.rbtnFirstFit = new System.Windows.Forms.RadioButton();
            this.btnSimulate = new System.Windows.Forms.Button();
            this.btnCompact = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelCompaction = new System.Windows.Forms.Panel();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelQueue = new System.Windows.Forms.Panel();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.tboxHeaderSimulation = new System.Windows.Forms.TextBox();
            this.panelSimulation = new System.Windows.Forms.Panel();
            this.panelDefMemory.SuspendLayout();
            this.panelAlloc.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelFitAlgo.SuspendLayout();
            this.panelCompaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDefMemory
            // 
            this.panelDefMemory.BackColor = System.Drawing.SystemColors.Info;
            this.panelDefMemory.Controls.Add(this.btnSetMemory);
            this.panelDefMemory.Controls.Add(this.tboxTotalMemory);
            this.panelDefMemory.Controls.Add(this.tboxOSMemory);
            this.panelDefMemory.Controls.Add(this.textBox7);
            this.panelDefMemory.Controls.Add(this.textBox6);
            this.panelDefMemory.Controls.Add(this.textBox5);
            this.panelDefMemory.Location = new System.Drawing.Point(288, 87);
            this.panelDefMemory.Margin = new System.Windows.Forms.Padding(2);
            this.panelDefMemory.Name = "panelDefMemory";
            this.panelDefMemory.Size = new System.Drawing.Size(252, 175);
            this.panelDefMemory.TabIndex = 1;
            this.panelDefMemory.TabStop = true;
            // 
            // btnSetMemory
            // 
            this.btnSetMemory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSetMemory.ForeColor = System.Drawing.Color.Black;
            this.btnSetMemory.Location = new System.Drawing.Point(79, 132);
            this.btnSetMemory.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetMemory.Name = "btnSetMemory";
            this.btnSetMemory.Size = new System.Drawing.Size(84, 32);
            this.btnSetMemory.TabIndex = 2;
            this.btnSetMemory.Text = "Set Memory";
            this.btnSetMemory.UseVisualStyleBackColor = false;
            this.btnSetMemory.Click += new System.EventHandler(this.SetMemory);
            // 
            // tboxTotalMemory
            // 
            this.tboxTotalMemory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tboxTotalMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxTotalMemory.Location = new System.Drawing.Point(15, 105);
            this.tboxTotalMemory.Margin = new System.Windows.Forms.Padding(2);
            this.tboxTotalMemory.Name = "tboxTotalMemory";
            this.tboxTotalMemory.Size = new System.Drawing.Size(217, 23);
            this.tboxTotalMemory.TabIndex = 1;
            // 
            // tboxOSMemory
            // 
            this.tboxOSMemory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tboxOSMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxOSMemory.Location = new System.Drawing.Point(15, 62);
            this.tboxOSMemory.Margin = new System.Windows.Forms.Padding(2);
            this.tboxOSMemory.Name = "tboxOSMemory";
            this.tboxOSMemory.Size = new System.Drawing.Size(217, 23);
            this.tboxOSMemory.TabIndex = 0;
            
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Info;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.Black;
            this.textBox7.Location = new System.Drawing.Point(15, 86);
            this.textBox7.Margin = new System.Windows.Forms.Padding(0);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.ShortcutsEnabled = false;
            this.textBox7.Size = new System.Drawing.Size(187, 16);
            this.textBox7.TabIndex = 99;
            this.textBox7.TabStop = false;
            this.textBox7.Text = "Total Memory (KB)";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Info;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.Black;
            this.textBox6.Location = new System.Drawing.Point(15, 43);
            this.textBox6.Margin = new System.Windows.Forms.Padding(0);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.ShortcutsEnabled = false;
            this.textBox6.Size = new System.Drawing.Size(187, 16);
            this.textBox6.TabIndex = 99;
            this.textBox6.TabStop = false;
            this.textBox6.Text = "OS (KB)";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Info;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox5.Location = new System.Drawing.Point(24, 11);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.ShortcutsEnabled = false;
            this.textBox5.Size = new System.Drawing.Size(208, 21);
            this.textBox5.TabIndex = 99;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "Define Memory";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelAlloc
            // 
            this.panelAlloc.BackColor = System.Drawing.SystemColors.Info;
            this.panelAlloc.Controls.Add(this.btnDealloc);
            this.panelAlloc.Controls.Add(this.btnAlloc);
            this.panelAlloc.Controls.Add(this.tboxSize);
            this.panelAlloc.Controls.Add(this.tboxProcessName);
            this.panelAlloc.Controls.Add(this.textBox4);
            this.panelAlloc.Controls.Add(this.textBox3);
            this.panelAlloc.Controls.Add(this.textBox2);
            this.panelAlloc.Location = new System.Drawing.Point(288, 266);
            this.panelAlloc.Margin = new System.Windows.Forms.Padding(2);
            this.panelAlloc.Name = "panelAlloc";
            this.panelAlloc.Size = new System.Drawing.Size(252, 208);
            this.panelAlloc.TabIndex = 2;
            // 
            // btnDealloc
            // 
            this.btnDealloc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDealloc.Location = new System.Drawing.Point(80, 167);
            this.btnDealloc.Margin = new System.Windows.Forms.Padding(2);
            this.btnDealloc.Name = "btnDealloc";
            this.btnDealloc.Size = new System.Drawing.Size(84, 32);
            this.btnDealloc.TabIndex = 6;
            this.btnDealloc.Text = "Deallocate";
            this.btnDealloc.UseVisualStyleBackColor = false;
            this.btnDealloc.Click += new System.EventHandler(this.addDeallocJob);
            // 
            // btnAlloc
            // 
            this.btnAlloc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAlloc.ForeColor = System.Drawing.Color.Black;
            this.btnAlloc.Location = new System.Drawing.Point(80, 129);
            this.btnAlloc.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlloc.Name = "btnAlloc";
            this.btnAlloc.Size = new System.Drawing.Size(84, 32);
            this.btnAlloc.TabIndex = 5;
            this.btnAlloc.Text = "Allocate";
            this.btnAlloc.UseVisualStyleBackColor = false;
            this.btnAlloc.Click += new System.EventHandler(this.addAllocJob);
            // 
            // tboxSize
            // 
            this.tboxSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tboxSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxSize.Location = new System.Drawing.Point(15, 102);
            this.tboxSize.Margin = new System.Windows.Forms.Padding(2);
            this.tboxSize.Name = "tboxSize";
            this.tboxSize.Size = new System.Drawing.Size(217, 23);
            this.tboxSize.TabIndex = 4;
            // 
            // tboxProcessName
            // 
            this.tboxProcessName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tboxProcessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxProcessName.Location = new System.Drawing.Point(15, 53);
            this.tboxProcessName.Margin = new System.Windows.Forms.Padding(2);
            this.tboxProcessName.Name = "tboxProcessName";
            this.tboxProcessName.Size = new System.Drawing.Size(217, 23);
            this.tboxProcessName.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Info;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox4.Location = new System.Drawing.Point(15, 80);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.ShortcutsEnabled = false;
            this.textBox4.Size = new System.Drawing.Size(187, 16);
            this.textBox4.TabIndex = 3;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "Size (KB)";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Info;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(15, 34);
            this.textBox3.Margin = new System.Windows.Forms.Padding(0);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ShortcutsEnabled = false;
            this.textBox3.Size = new System.Drawing.Size(187, 16);
            this.textBox3.TabIndex = 2;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Proccess Name";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(34, 11);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ShortcutsEnabled = false;
            this.textBox2.Size = new System.Drawing.Size(187, 21);
            this.textBox2.TabIndex = 1;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Create Job Here";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.panelFitAlgo);
            this.panel2.Location = new System.Drawing.Point(288, 564);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 76);
            this.panel2.TabIndex = 4;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Info;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox8.Location = new System.Drawing.Point(54, 12);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.ShortcutsEnabled = false;
            this.textBox8.Size = new System.Drawing.Size(148, 30);
            this.textBox8.TabIndex = 2;
            this.textBox8.TabStop = false;
            this.textBox8.Text = "Fitting Algorithm";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelFitAlgo
            // 
            this.panelFitAlgo.Controls.Add(this.rbtnBestFit);
            this.panelFitAlgo.Controls.Add(this.rbtnFirstFit);
            this.panelFitAlgo.Location = new System.Drawing.Point(30, 37);
            this.panelFitAlgo.Name = "panelFitAlgo";
            this.panelFitAlgo.Size = new System.Drawing.Size(187, 30);
            this.panelFitAlgo.TabIndex = 3;
            // 
            // rbtnBestFit
            // 
            this.rbtnBestFit.AutoSize = true;
            this.rbtnBestFit.Checked = true;
            this.rbtnBestFit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnBestFit.Location = new System.Drawing.Point(4, 4);
            this.rbtnBestFit.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnBestFit.Name = "rbtnBestFit";
            this.rbtnBestFit.Size = new System.Drawing.Size(81, 21);
            this.rbtnBestFit.TabIndex = 8;
            this.rbtnBestFit.TabStop = true;
            this.rbtnBestFit.Text = "Best Fit";
            this.rbtnBestFit.UseVisualStyleBackColor = true;
            // 
            // rbtnFirstFit
            // 
            this.rbtnFirstFit.AutoSize = true;
            this.rbtnFirstFit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFirstFit.Location = new System.Drawing.Point(104, 4);
            this.rbtnFirstFit.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnFirstFit.Name = "rbtnFirstFit";
            this.rbtnFirstFit.Size = new System.Drawing.Size(81, 21);
            this.rbtnFirstFit.TabIndex = 9;
            this.rbtnFirstFit.TabStop = true;
            this.rbtnFirstFit.Text = "First Fit";
            this.rbtnFirstFit.UseVisualStyleBackColor = true;
            // 
            // btnSimulate
            // 
            this.btnSimulate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSimulate.Location = new System.Drawing.Point(655, 594);
            this.btnSimulate.Margin = new System.Windows.Forms.Padding(2);
            this.btnSimulate.Name = "btnSimulate";
            this.btnSimulate.Size = new System.Drawing.Size(166, 32);
            this.btnSimulate.TabIndex = 11;
            this.btnSimulate.Text = "Simulate";
            this.btnSimulate.UseVisualStyleBackColor = false;
            this.btnSimulate.Click += new System.EventHandler(this.Simulate);
            // 
            // btnCompact
            // 
            this.btnCompact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCompact.ForeColor = System.Drawing.Color.Black;
            this.btnCompact.Location = new System.Drawing.Point(80, 37);
            this.btnCompact.Margin = new System.Windows.Forms.Padding(2);
            this.btnCompact.Name = "btnCompact";
            this.btnCompact.Size = new System.Drawing.Size(84, 32);
            this.btnCompact.TabIndex = 7;
            this.btnCompact.Text = "Compact";
            this.btnCompact.UseVisualStyleBackColor = false;
            this.btnCompact.Click += new System.EventHandler(this.addCompacJob);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightSalmon;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(255, 11);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(413, 37);
            this.textBox1.TabIndex = 7;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Memory Management";
            // 
            // panelCompaction
            // 
            this.panelCompaction.BackColor = System.Drawing.SystemColors.Info;
            this.panelCompaction.Controls.Add(this.btnCompact);
            this.panelCompaction.Controls.Add(this.textBox9);
            this.panelCompaction.Location = new System.Drawing.Point(288, 478);
            this.panelCompaction.Margin = new System.Windows.Forms.Padding(2);
            this.panelCompaction.Name = "panelCompaction";
            this.panelCompaction.Size = new System.Drawing.Size(252, 81);
            this.panelCompaction.TabIndex = 3;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.Info;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox9.Location = new System.Drawing.Point(54, 2);
            this.textBox9.Margin = new System.Windows.Forms.Padding(2);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.ShortcutsEnabled = false;
            this.textBox9.Size = new System.Drawing.Size(148, 21);
            this.textBox9.TabIndex = 2;
            this.textBox9.TabStop = false;
            this.textBox9.Text = "Compaction";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(554, 594);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 32);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear Queue";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.clearQueue);
            // 
            // panelQueue
            // 
            this.panelQueue.AutoScroll = true;
            this.panelQueue.BackColor = System.Drawing.SystemColors.Info;
            this.panelQueue.Location = new System.Drawing.Point(554, 87);
            this.panelQueue.Margin = new System.Windows.Forms.Padding(2);
            this.panelQueue.Name = "panelQueue";
            this.panelQueue.Size = new System.Drawing.Size(267, 490);
            this.panelQueue.TabIndex = 7;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.Info;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox10.Location = new System.Drawing.Point(554, 62);
            this.textBox10.Margin = new System.Windows.Forms.Padding(2);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.ShortcutsEnabled = false;
            this.textBox10.Size = new System.Drawing.Size(267, 21);
            this.textBox10.TabIndex = 7;
            this.textBox10.TabStop = false;
            this.textBox10.Text = "Queue";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tboxHeaderSimulation
            // 
            this.tboxHeaderSimulation.BackColor = System.Drawing.SystemColors.Info;
            this.tboxHeaderSimulation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxHeaderSimulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxHeaderSimulation.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tboxHeaderSimulation.Location = new System.Drawing.Point(11, 62);
            this.tboxHeaderSimulation.Margin = new System.Windows.Forms.Padding(2);
            this.tboxHeaderSimulation.Name = "tboxHeaderSimulation";
            this.tboxHeaderSimulation.ReadOnly = true;
            this.tboxHeaderSimulation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tboxHeaderSimulation.ShortcutsEnabled = false;
            this.tboxHeaderSimulation.Size = new System.Drawing.Size(265, 21);
            this.tboxHeaderSimulation.TabIndex = 10;
            this.tboxHeaderSimulation.TabStop = false;
            this.tboxHeaderSimulation.Text = "Simulation";
            this.tboxHeaderSimulation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelSimulation
            // 
            this.panelSimulation.BackColor = System.Drawing.SystemColors.Info;
            this.panelSimulation.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panelSimulation.Location = new System.Drawing.Point(9, 87);
            this.panelSimulation.Margin = new System.Windows.Forms.Padding(2);
            this.panelSimulation.Name = "panelSimulation";
            this.panelSimulation.Size = new System.Drawing.Size(267, 550);
            this.panelSimulation.TabIndex = 6;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(832, 649);
            this.Controls.Add(this.tboxHeaderSimulation);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.panelQueue);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.panelCompaction);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panelSimulation);
            this.Controls.Add(this.btnSimulate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelAlloc);
            this.Controls.Add(this.panelDefMemory);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Management";
            this.panelDefMemory.ResumeLayout(false);
            this.panelDefMemory.PerformLayout();
            this.panelAlloc.ResumeLayout(false);
            this.panelAlloc.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelFitAlgo.ResumeLayout(false);
            this.panelFitAlgo.PerformLayout();
            this.panelCompaction.ResumeLayout(false);
            this.panelCompaction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDefMemory;
        private System.Windows.Forms.Panel panelAlloc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSimulate;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox tboxSize;
        private System.Windows.Forms.TextBox tboxProcessName;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox tboxTotalMemory;
        private System.Windows.Forms.TextBox tboxOSMemory;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btnAlloc;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button btnDealloc;
        private System.Windows.Forms.Button btnCompact;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelCompaction;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panelQueue;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox tboxHeaderSimulation;
        private System.Windows.Forms.Panel panelSimulation;
        private System.Windows.Forms.Button btnSetMemory;
        private System.Windows.Forms.Panel panelFitAlgo;
        private System.Windows.Forms.RadioButton rbtnBestFit;
        private System.Windows.Forms.RadioButton rbtnFirstFit;
    }
}