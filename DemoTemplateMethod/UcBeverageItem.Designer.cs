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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcBeverageItem));
            panel1 = new Panel();
            lblDescription = new Label();
            pictureBox1 = new PictureBox();
            lblMilktea = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblDescription);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblMilktea);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(15, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 312);
            panel1.TabIndex = 1;
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.FromArgb(251, 210, 136);
            lblDescription.Location = new Point(9, 187);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(240, 58);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Mochi milktea  is the best in the world, everyone loves it";
            lblDescription.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(9, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lblMilktea
            // 
            lblMilktea.AutoSize = true;
            lblMilktea.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMilktea.ForeColor = Color.FromArgb(242, 178, 140);
            lblMilktea.Location = new Point(51, 157);
            lblMilktea.Name = "lblMilktea";
            lblMilktea.Size = new Size(157, 30);
            lblMilktea.TabIndex = 4;
            lblMilktea.Text = "Mochi MilkTea";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(60, 248);
            button1.Name = "button1";
            button1.Size = new Size(140, 48);
            button1.TabIndex = 3;
            button1.Text = "Prepare";
            button1.UseVisualStyleBackColor = false;
            // 
            // UcBeverageItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UcBeverageItem";
            Size = new Size(292, 341);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblDescription;
        private PictureBox pictureBox1;
        private Label lblMilktea;
        private Button button1;
    }
}
