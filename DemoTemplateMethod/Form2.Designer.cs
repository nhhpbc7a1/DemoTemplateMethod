using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using Font = System.Drawing.Font;

namespace DemoTemplateMethod
{
    partial class MainInterface
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
            this.StartPosition = FormStartPosition.CenterScreen;
            lblBeverage = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // lblBeverage
            // 
            lblBeverage.AutoSize = true;
            lblBeverage.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBeverage.Location = new Point(336, 26);
            lblBeverage.Name = "lblBeverage";
            lblBeverage.Size = new Size(344, 42);
            lblBeverage.TabIndex = 0;
            lblBeverage.Text = "BEVERAGE MENU";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Location = new Point(31, 80);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(937, 776);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // MainInterface
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 178, 140);
            ClientSize = new Size(1000, 875);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lblBeverage);
            Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MainInterface";
            Text = "MainInterface";
            Load += MainInterface_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBeverage;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}