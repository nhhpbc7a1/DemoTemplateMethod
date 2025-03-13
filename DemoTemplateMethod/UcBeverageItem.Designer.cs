namespace DemoTemplateMethod
{
    partial class UcBeverageItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            lblName = new Label();
            lblDescription = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(15, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 360);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblName);
            panel2.Controls.Add(lblDescription);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 211);
            panel2.Name = "panel2";
            panel2.Size = new Size(262, 147);
            panel2.TabIndex = 7;
            // 
            // lblName
            // 
            lblName.Dock = DockStyle.Top;
            lblName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.FromArgb(242, 178, 140);
            lblName.Location = new Point(0, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(262, 30);
            lblName.TabIndex = 4;
            lblName.Text = "Mochi MilkTea";
            lblName.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.FromArgb(251, 210, 136);
            lblDescription.Location = new Point(3, 30);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(240, 51);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Mochi milktea  is the best in the world, everyone loves it";
            lblDescription.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(54, 87);
            button1.Name = "button1";
            button1.Size = new Size(145, 48);
            button1.TabIndex = 3;
            button1.Text = "Prepare";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(21, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // UcBeverageItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UcBeverageItem";
            Size = new Size(292, 379);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblDescription;
        private PictureBox pictureBox1;
        private Label lblName;
        private Button button1;
        private Panel panel2;
    }
}
