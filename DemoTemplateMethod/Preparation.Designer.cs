namespace DemoTemplateMethod
{
    partial class Preparation
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
            nav2 = new Nav();
            SuspendLayout();
            // 
            // nav2
            // 
            nav2.Dock = DockStyle.Fill;
            nav2.Location = new Point(0, 0);
            nav2.Margin = new Padding(3, 2, 3, 2);
            nav2.Name = "nav2";
            nav2.Size = new Size(1084, 499);
            nav2.TabIndex = 1;
            nav2.Load += nav2_Load;
            // 
            // Preparation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1084, 499);
            Controls.Add(nav2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Preparation";
            Text = "Preparation";
            ResumeLayout(false);
        }

        #endregion

        private Nav nav2;
    }
}