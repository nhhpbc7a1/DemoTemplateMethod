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
            lblBeverage = new Label();
            panel1 = new Panel();
            ucBeverageItem6 = new UcBeverageItem();
            ucBeverageItem5 = new UcBeverageItem();
            ucBeverageItem4 = new UcBeverageItem();
            ucBeverageItem3 = new UcBeverageItem();
            ucBeverageItem2 = new UcBeverageItem();
            ucBeverageItem1 = new UcBeverageItem();
            panel1.SuspendLayout();
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
            lblBeverage.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ucBeverageItem6);
            panel1.Controls.Add(ucBeverageItem5);
            panel1.Controls.Add(ucBeverageItem4);
            panel1.Controls.Add(ucBeverageItem3);
            panel1.Controls.Add(ucBeverageItem2);
            panel1.Controls.Add(ucBeverageItem1);
            panel1.Location = new Point(31, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(937, 683);
            panel1.TabIndex = 1;
            // 
            // ucBeverageItem6
            // 
            ucBeverageItem6.Location = new Point(624, 341);
            ucBeverageItem6.Margin = new Padding(3, 4, 3, 4);
            ucBeverageItem6.Name = "ucBeverageItem6";
            ucBeverageItem6.Size = new Size(292, 341);
            ucBeverageItem6.TabIndex = 5;
            // 
            // ucBeverageItem5
            // 
            ucBeverageItem5.Location = new Point(315, 341);
            ucBeverageItem5.Margin = new Padding(3, 4, 3, 4);
            ucBeverageItem5.Name = "ucBeverageItem5";
            ucBeverageItem5.Size = new Size(292, 341);
            ucBeverageItem5.TabIndex = 4;
            // 
            // ucBeverageItem4
            // 
            ucBeverageItem4.Location = new Point(3, 341);
            ucBeverageItem4.Margin = new Padding(3, 4, 3, 4);
            ucBeverageItem4.Name = "ucBeverageItem4";
            ucBeverageItem4.Size = new Size(292, 341);
            ucBeverageItem4.TabIndex = 3;
            // 
            // ucBeverageItem3
            // 
            ucBeverageItem3.Location = new Point(624, 3);
            ucBeverageItem3.Margin = new Padding(3, 4, 3, 4);
            ucBeverageItem3.Name = "ucBeverageItem3";
            ucBeverageItem3.Size = new Size(292, 341);
            ucBeverageItem3.TabIndex = 2;
            // 
            // ucBeverageItem2
            // 
            ucBeverageItem2.Location = new Point(315, 3);
            ucBeverageItem2.Margin = new Padding(3, 4, 3, 4);
            ucBeverageItem2.Name = "ucBeverageItem2";
            ucBeverageItem2.Size = new Size(292, 341);
            ucBeverageItem2.TabIndex = 1;
            // 
            // ucBeverageItem1
            // 
            ucBeverageItem1.Location = new Point(3, 3);
            ucBeverageItem1.Margin = new Padding(3, 4, 3, 4);
            ucBeverageItem1.Name = "ucBeverageItem1";
            ucBeverageItem1.Size = new Size(292, 341);
            ucBeverageItem1.TabIndex = 0;
            // 
            // MainInterface
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 178, 140);
            ClientSize = new Size(1000, 788);
            Controls.Add(panel1);
            Controls.Add(lblBeverage);
            Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainInterface";
            Text = "MainInterface";
            Load += MainInterface_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBeverage;
        private Panel panel1;
        private UcBeverageItem ucBeverageItem2;
        private UcBeverageItem ucBeverageItem1;
        private UcBeverageItem ucBeverageItem6;
        private UcBeverageItem ucBeverageItem5;
        private UcBeverageItem ucBeverageItem4;
        private UcBeverageItem ucBeverageItem3;
    }
}