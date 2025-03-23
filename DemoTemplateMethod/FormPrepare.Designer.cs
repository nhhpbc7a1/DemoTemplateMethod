using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DemoTemplateMethod
{
    partial class FormPrepare
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
            components = new System.ComponentModel.Container();
            panelImage = new Panel();
            pictureBoxStep = new PictureBox();
            panelSteps = new Panel();
            timer = new System.Windows.Forms.Timer(components);
            lblTitle = new Label();
            panelNavigation = new Panel();
            btnNext = new Button();
            btnPrevious = new Button();
            btnStartStop = new Button();
            panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStep).BeginInit();
            panelNavigation.SuspendLayout();
            SuspendLayout();
            // 
            // panelImage
            // 
            panelImage.BackColor = Color.FromArgb(242, 178, 140);
            panelImage.Controls.Add(pictureBoxStep);
            panelImage.Dock = DockStyle.Left;
            panelImage.Location = new Point(0, 0);
            panelImage.Name = "panelImage";
            panelImage.Padding = new Padding(20);
            panelImage.Size = new Size(500, 781);
            panelImage.TabIndex = 0;
            // 
            // pictureBoxStep
            // 
            pictureBoxStep.BackColor = Color.White;
            pictureBoxStep.Dock = DockStyle.Fill;
            pictureBoxStep.Location = new Point(20, 20);
            pictureBoxStep.Name = "pictureBoxStep";
            pictureBoxStep.Size = new Size(460, 741);
            pictureBoxStep.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxStep.TabIndex = 0;
            pictureBoxStep.TabStop = false;
            // 
            // panelSteps
            // 
            panelSteps.AutoScroll = true;
            panelSteps.BackColor = Color.White;
            panelSteps.Dock = DockStyle.Fill;
            panelSteps.Location = new Point(500, 60);
            panelSteps.Name = "panelSteps";
            panelSteps.Padding = new Padding(20);
            panelSteps.Size = new Size(500, 661);
            panelSteps.TabIndex = 1;
            // 
            // timer
            // 
            timer.Interval = 2000;
            timer.Tick += timer_Tick;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.White;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(500, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(500, 60);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Beverage Preparation";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelNavigation
            // 
            panelNavigation.BackColor = Color.White;
            panelNavigation.Controls.Add(btnNext);
            panelNavigation.Controls.Add(btnPrevious);
            panelNavigation.Controls.Add(btnStartStop);
            panelNavigation.Dock = DockStyle.Bottom;
            panelNavigation.Location = new Point(500, 721);
            panelNavigation.Name = "panelNavigation";
            panelNavigation.Size = new Size(500, 60);
            panelNavigation.TabIndex = 3;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNext.BackColor = Color.FromArgb(0, 123, 255);
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI Semibold", 13.75F, FontStyle.Bold);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(380, 12);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(100, 36);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.FromArgb(108, 117, 125);
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Font = new Font("Segoe UI Semibold", 13.75F, FontStyle.Bold);
            btnPrevious.ForeColor = Color.White;
            btnPrevious.Location = new Point(20, 12);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(100, 35);
            btnPrevious.TabIndex = 0;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnStartStop
            // 
            btnStartStop.Anchor = AnchorStyles.None;
            btnStartStop.BackColor = Color.FromArgb(40, 167, 69);
            btnStartStop.FlatAppearance.BorderSize = 0;
            btnStartStop.FlatStyle = FlatStyle.Flat;
            btnStartStop.Font = new Font("Segoe UI Semibold", 13.75F, FontStyle.Bold);
            btnStartStop.ForeColor = Color.White;
            btnStartStop.Location = new Point(200, 12);
            btnStartStop.Name = "btnStartStop";
            btnStartStop.Size = new Size(100, 36);
            btnStartStop.TabIndex = 1;
            btnStartStop.Text = "Stop";
            btnStartStop.UseVisualStyleBackColor = false;
            btnStartStop.Click += btnStartStop_Click;
            // 
            // FormPrepare
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 781);
            Controls.Add(panelSteps);
            Controls.Add(panelNavigation);
            Controls.Add(lblTitle);
            Controls.Add(panelImage);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormPrepare";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Beverage Preparation";
            Load += FormPrepare_Load;
            panelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxStep).EndInit();
            panelNavigation.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.PictureBox pictureBoxStep;
        private System.Windows.Forms.Panel panelSteps;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnStartStop;
    }
}