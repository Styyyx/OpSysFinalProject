namespace MemoryManagement
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxTotalMemory = new System.Windows.Forms.TextBox();
            this.textBoxOskb = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDeallocate = new System.Windows.Forms.Button();
            this.buttonAllocate = new System.Windows.Forms.Button();
            this.textBoxSizekb = new System.Windows.Forms.TextBox();
            this.textBoxProcessName = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.radioButtonFirstFit = new System.Windows.Forms.RadioButton();
            this.radioButtonBestFit = new System.Windows.Forms.RadioButton();
            this.simulateButton = new System.Windows.Forms.Button();
            this.buttonCompact = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.textBoxTotalMemory);
            this.panel1.Controls.Add(this.textBoxOskb);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Location = new System.Drawing.Point(384, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 178);
            this.panel1.TabIndex = 0;
            // 
            // textBoxTotalMemory
            // 
            this.textBoxTotalMemory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxTotalMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalMemory.Location = new System.Drawing.Point(20, 129);
            this.textBoxTotalMemory.Name = "textBoxTotalMemory";
            this.textBoxTotalMemory.Size = new System.Drawing.Size(288, 27);
            this.textBoxTotalMemory.TabIndex = 6;
            // 
            // textBoxOskb
            // 
            this.textBoxOskb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxOskb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOskb.Location = new System.Drawing.Point(20, 76);
            this.textBoxOskb.Name = "textBoxOskb";
            this.textBoxOskb.Size = new System.Drawing.Size(288, 27);
            this.textBoxOskb.TabIndex = 5;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Info;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.Black;
            this.textBox7.Location = new System.Drawing.Point(20, 106);
            this.textBox7.Margin = new System.Windows.Forms.Padding(0);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.ShortcutsEnabled = false;
            this.textBox7.Size = new System.Drawing.Size(249, 20);
            this.textBox7.TabIndex = 4;
            this.textBox7.Text = "Totat Memory (KB)";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Info;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.Black;
            this.textBox6.Location = new System.Drawing.Point(20, 53);
            this.textBox6.Margin = new System.Windows.Forms.Padding(0);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.ShortcutsEnabled = false;
            this.textBox6.Size = new System.Drawing.Size(249, 20);
            this.textBox6.TabIndex = 3;
            this.textBox6.Text = "OS (KB)";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Info;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox5.Location = new System.Drawing.Point(20, 10);
            this.textBox5.Name = "textBox5";
            this.textBox5.ShortcutsEnabled = false;
            this.textBox5.Size = new System.Drawing.Size(277, 27);
            this.textBox5.TabIndex = 2;
            this.textBox5.Text = "Define Memory";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.buttonDeallocate);
            this.panel2.Controls.Add(this.buttonAllocate);
            this.panel2.Controls.Add(this.textBoxSizekb);
            this.panel2.Controls.Add(this.textBoxProcessName);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Location = new System.Drawing.Point(384, 291);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 291);
            this.panel2.TabIndex = 1;
            // 
            // buttonDeallocate
            // 
            this.buttonDeallocate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonDeallocate.Location = new System.Drawing.Point(106, 241);
            this.buttonDeallocate.Name = "buttonDeallocate";
            this.buttonDeallocate.Size = new System.Drawing.Size(112, 40);
            this.buttonDeallocate.TabIndex = 7;
            this.buttonDeallocate.Text = "Deallocate";
            this.buttonDeallocate.UseVisualStyleBackColor = false;
            this.buttonDeallocate.Click += new System.EventHandler(this.buttonDeallocate_Click);
            // 
            // buttonAllocate
            // 
            this.buttonAllocate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonAllocate.ForeColor = System.Drawing.Color.Black;
            this.buttonAllocate.Location = new System.Drawing.Point(106, 195);
            this.buttonAllocate.Name = "buttonAllocate";
            this.buttonAllocate.Size = new System.Drawing.Size(112, 40);
            this.buttonAllocate.TabIndex = 6;
            this.buttonAllocate.Text = "Allocate";
            this.buttonAllocate.UseVisualStyleBackColor = false;
            this.buttonAllocate.Click += new System.EventHandler(this.buttonAllocate_Click);
            // 
            // textBoxSizekb
            // 
            this.textBoxSizekb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxSizekb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSizekb.Location = new System.Drawing.Point(20, 162);
            this.textBoxSizekb.Name = "textBoxSizekb";
            this.textBoxSizekb.Size = new System.Drawing.Size(288, 27);
            this.textBoxSizekb.TabIndex = 5;
            // 
            // textBoxProcessName
            // 
            this.textBoxProcessName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxProcessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProcessName.Location = new System.Drawing.Point(20, 82);
            this.textBoxProcessName.Name = "textBoxProcessName";
            this.textBoxProcessName.Size = new System.Drawing.Size(288, 27);
            this.textBoxProcessName.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Info;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox4.Location = new System.Drawing.Point(20, 136);
            this.textBox4.Name = "textBox4";
            this.textBox4.ShortcutsEnabled = false;
            this.textBox4.Size = new System.Drawing.Size(249, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Size (KB)";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Info;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(20, 59);
            this.textBox3.Margin = new System.Windows.Forms.Padding(0);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ShortcutsEnabled = false;
            this.textBox3.Size = new System.Drawing.Size(249, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Proccess Name";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(20, 18);
            this.textBox2.Name = "textBox2";
            this.textBox2.ShortcutsEnabled = false;
            this.textBox2.Size = new System.Drawing.Size(249, 27);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Create Allocate Here";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Info;
            this.panel4.Controls.Add(this.textBox8);
            this.panel4.Controls.Add(this.radioButtonFirstFit);
            this.panel4.Controls.Add(this.radioButtonBestFit);
            this.panel4.Location = new System.Drawing.Point(384, 694);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(336, 93);
            this.panel4.TabIndex = 3;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Info;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox8.Location = new System.Drawing.Point(20, 12);
            this.textBox8.Name = "textBox8";
            this.textBox8.ShortcutsEnabled = false;
            this.textBox8.Size = new System.Drawing.Size(198, 27);
            this.textBox8.TabIndex = 2;
            this.textBox8.Text = "Fitting Algorithm";
            // 
            // radioButtonFirstFit
            // 
            this.radioButtonFirstFit.AutoSize = true;
            this.radioButtonFirstFit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFirstFit.Location = new System.Drawing.Point(181, 56);
            this.radioButtonFirstFit.Name = "radioButtonFirstFit";
            this.radioButtonFirstFit.Size = new System.Drawing.Size(97, 24);
            this.radioButtonFirstFit.TabIndex = 1;
            this.radioButtonFirstFit.TabStop = true;
            this.radioButtonFirstFit.Text = "First Fit";
            this.radioButtonFirstFit.UseVisualStyleBackColor = true;
            // 
            // radioButtonBestFit
            // 
            this.radioButtonBestFit.AutoSize = true;
            this.radioButtonBestFit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBestFit.Location = new System.Drawing.Point(46, 56);
            this.radioButtonBestFit.Name = "radioButtonBestFit";
            this.radioButtonBestFit.Size = new System.Drawing.Size(97, 24);
            this.radioButtonBestFit.TabIndex = 0;
            this.radioButtonBestFit.TabStop = true;
            this.radioButtonBestFit.Text = "Best Fit";
            this.radioButtonBestFit.UseVisualStyleBackColor = true;
            // 
            // simulateButton
            // 
            this.simulateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.simulateButton.Location = new System.Drawing.Point(30, 729);
            this.simulateButton.Name = "simulateButton";
            this.simulateButton.Size = new System.Drawing.Size(302, 45);
            this.simulateButton.TabIndex = 4;
            this.simulateButton.Text = "Simulate";
            this.simulateButton.UseVisualStyleBackColor = false;
            // 
            // buttonCompact
            // 
            this.buttonCompact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonCompact.ForeColor = System.Drawing.Color.Black;
            this.buttonCompact.Location = new System.Drawing.Point(106, 45);
            this.buttonCompact.Name = "buttonCompact";
            this.buttonCompact.Size = new System.Drawing.Size(112, 40);
            this.buttonCompact.TabIndex = 1;
            this.buttonCompact.Text = "Compact";
            this.buttonCompact.UseVisualStyleBackColor = false;
            this.buttonCompact.Click += new System.EventHandler(this.buttonCompact_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.Location = new System.Drawing.Point(12, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 603);
            this.panel3.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightSalmon;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(338, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(551, 46);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Memory Management";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Info;
            this.panel6.Controls.Add(this.buttonCompact);
            this.panel6.Controls.Add(this.textBox9);
            this.panel6.Location = new System.Drawing.Point(384, 588);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(336, 100);
            this.panel6.TabIndex = 8;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.Info;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox9.Location = new System.Drawing.Point(20, 3);
            this.textBox9.Name = "textBox9";
            this.textBox9.ShortcutsEnabled = false;
            this.textBox9.Size = new System.Drawing.Size(198, 27);
            this.textBox9.TabIndex = 2;
            this.textBox9.Text = "Compaction";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(867, 729);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Clear Queue";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1110, 799);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.simulateButton);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button simulateButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBoxSizekb;
        private System.Windows.Forms.TextBox textBoxProcessName;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBoxTotalMemory;
        private System.Windows.Forms.TextBox textBoxOskb;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button buttonAllocate;
        private System.Windows.Forms.RadioButton radioButtonFirstFit;
        private System.Windows.Forms.RadioButton radioButtonBestFit;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button buttonDeallocate;
        private System.Windows.Forms.Button buttonCompact;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button1;
    }
}