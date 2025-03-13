﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoTemplateMethod
{
    public partial class Nav : UserControl
    {
        public Nav()
        {
            InitializeComponent();
            this.Load += Nav_Load;
        }

        private void Nav_Load(object sender, EventArgs e)
        {
            AssignHoverEvents(this);
        }
        private void AssignHoverEvents(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.MouseEnter += Button_MouseEnter;
                    btn.MouseLeave += Button_MouseLeave;
                }
                else
                {
                    AssignHoverEvents(ctrl); // Gọi lại nếu ctrl chứa controls khác (Panel, GroupBox)
                }
            }
        }

        private void btnPrepare_Click(object sender, EventArgs e)
        {

        }
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(242, 178, 140);
        }

        // Xử lý khi rời khỏi button
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(35, 40, 45);
        }

    }
}
