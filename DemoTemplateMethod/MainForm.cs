using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DemoTemplateMethod.Beverages;

namespace DemoTemplateMethod
{
    // Main Form - displays the menu
    public partial class MainForm : Form
    {
        private Form activeForm = null;
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e) //Important to load on load not constructor.
        {
            OpenChildForm(new MainInterface()); // Open MainInterface when the MainForm loads
        }

        // Method to open a child form inside panel1
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close(); // Close the previous active form
            }
            activeForm = childForm; // Set the new active form
            childForm.TopLevel = false; // Important: Make it a non-top-level form
            childForm.FormBorderStyle = FormBorderStyle.None; // Optional: Remove border
            childForm.Dock = DockStyle.Fill; // Important: Fill the panel
            panel1.Controls.Add(childForm); // Add to the panel's controls
            panel1.Tag = childForm; // Optional: Store the form as the panel's tag
            childForm.BringToFront(); // Optional: Ensure it's on top
            childForm.Show(); // Show the child form
        }

    }
}