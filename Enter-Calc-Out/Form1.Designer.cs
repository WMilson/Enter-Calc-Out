namespace Enter_Calc_Out
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            inputMenuItem = new ToolStripMenuItem();
            calculateMenuItem = new ToolStripMenuItem();
            exitMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { inputMenuItem, calculateMenuItem, exitMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(420, 24);
            menuStrip.TabIndex = 0;
            // 
            // inputMenuItem
            // 
            inputMenuItem.Name = "inputMenuItem";
            inputMenuItem.Size = new Size(45, 20);
            inputMenuItem.Text = "Ввод";
            inputMenuItem.Click += inputMenuItem_Click;
            // 
            // calculateMenuItem
            // 
            calculateMenuItem.Enabled = false;
            calculateMenuItem.Name = "calculateMenuItem";
            calculateMenuItem.Size = new Size(77, 20);
            calculateMenuItem.Text = "Посчитать";
            calculateMenuItem.Click += calculateMenuItem_Click;
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Size = new Size(53, 20);
            exitMenuItem.Text = "Выход";
            exitMenuItem.Click += exitMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 27);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "Form1";
            Text = "Enter-Calc-Out";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem inputMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
    }
}