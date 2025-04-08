namespace Demo1
{
    partial class DemoSolutionUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            sideControlPanel1 = new demoSidePanel1.sideControlPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 17, 26);
            panel1.Controls.Add(sideControlPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 3;
            // 
            // sideControlPanel1
            // 
            sideControlPanel1.AutoSize = true;
            sideControlPanel1.Dock = DockStyle.Left;
            sideControlPanel1.Location = new Point(0, 0);
            sideControlPanel1.MinimumSize = new Size(25, 25);
            sideControlPanel1.Name = "sideControlPanel1";
            sideControlPanel1.Size = new Size(240, 450);
            sideControlPanel1.TabIndex = 0;
            // 
            // DemoSolutionUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "DemoSolutionUI";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private demoSidePanel1.sideControlPanel sideControlPanel1;
    }
}
