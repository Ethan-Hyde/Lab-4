namespace _2016002627_Lab_4
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskLIstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forLoopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doWhileLoopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nestedForLoopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forEachLoopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whileLoopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Lab4TxT = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.taskLIstToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fileToolStripMenuItem.Text = "File ";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // taskLIstToolStripMenuItem
            // 
            this.taskLIstToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forLoopToolStripMenuItem,
            this.doWhileLoopToolStripMenuItem,
            this.nestedForLoopToolStripMenuItem,
            this.forEachLoopToolStripMenuItem,
            this.whileLoopToolStripMenuItem});
            this.taskLIstToolStripMenuItem.Name = "taskLIstToolStripMenuItem";
            this.taskLIstToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.taskLIstToolStripMenuItem.Text = "Task LIst ";
            this.taskLIstToolStripMenuItem.Click += new System.EventHandler(this.taskLIstToolStripMenuItem_Click);
            // 
            // forLoopToolStripMenuItem
            // 
            this.forLoopToolStripMenuItem.Name = "forLoopToolStripMenuItem";
            this.forLoopToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.forLoopToolStripMenuItem.Text = "For Loop ";
            this.forLoopToolStripMenuItem.Click += new System.EventHandler(this.forLoopToolStripMenuItem_Click);
            // 
            // doWhileLoopToolStripMenuItem
            // 
            this.doWhileLoopToolStripMenuItem.Name = "doWhileLoopToolStripMenuItem";
            this.doWhileLoopToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.doWhileLoopToolStripMenuItem.Text = "Do While Loop";
            this.doWhileLoopToolStripMenuItem.Click += new System.EventHandler(this.doWhileLoopToolStripMenuItem_Click);
            // 
            // nestedForLoopToolStripMenuItem
            // 
            this.nestedForLoopToolStripMenuItem.Name = "nestedForLoopToolStripMenuItem";
            this.nestedForLoopToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.nestedForLoopToolStripMenuItem.Text = "Nested For Loop";
            this.nestedForLoopToolStripMenuItem.Click += new System.EventHandler(this.nestedForLoopToolStripMenuItem_Click);
            // 
            // forEachLoopToolStripMenuItem
            // 
            this.forEachLoopToolStripMenuItem.Name = "forEachLoopToolStripMenuItem";
            this.forEachLoopToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.forEachLoopToolStripMenuItem.Text = "For Each Loop";
            this.forEachLoopToolStripMenuItem.Click += new System.EventHandler(this.forEachLoopToolStripMenuItem_Click);
            // 
            // whileLoopToolStripMenuItem
            // 
            this.whileLoopToolStripMenuItem.Name = "whileLoopToolStripMenuItem";
            this.whileLoopToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.whileLoopToolStripMenuItem.Text = "While Loop";
            this.whileLoopToolStripMenuItem.Click += new System.EventHandler(this.whileLoopToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.helpToolStripMenuItem.Text = "Help ";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // Lab4TxT
            // 
            this.Lab4TxT.Location = new System.Drawing.Point(12, 133);
            this.Lab4TxT.Multiline = true;
            this.Lab4TxT.Name = "Lab4TxT";
            this.Lab4TxT.Size = new System.Drawing.Size(260, 116);
            this.Lab4TxT.TabIndex = 1;
            this.Lab4TxT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(34, 54);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(203, 31);
            this.label.TabIndex = 2;
            this.label.Text = "LAB 4 - LOOPS";
            this.label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Lab4TxT);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskLIstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox Lab4TxT;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ToolStripMenuItem forLoopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doWhileLoopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nestedForLoopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forEachLoopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whileLoopToolStripMenuItem;
    }
}

