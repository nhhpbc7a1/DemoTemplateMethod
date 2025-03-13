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
        private List<Beverage> beverages;

        public MainForm()
        {
            InitializeComponent();
            InitializeBeverages();
            ShowMenuPanel();
        }

        private void InitializeBeverages()
        {
            beverages = new List<Beverage>
            {
                new Coffee(),
                new Tea(),
                new Smoothie()
            };
        }

        private void ShowMenuPanel()
        {
            // Clear all current controls
            this.Controls.Clear();

            // Create panel for Menu
            Panel menuPanel = new Panel
            {
                Dock = DockStyle.Fill
            };

            // Create title label
            Label titleLabel = new Label
            {
                Text = "BEVERAGE MENU",
                Font = new Font("Arial", 24, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 60
            };

            menuPanel.Controls.Add(titleLabel);

            // Create FlowLayoutPanel to display the beverages
            FlowLayoutPanel beverageLayout = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.LeftToRight,
                Padding = new Padding(20),
                WrapContents = true
            };

            menuPanel.Controls.Add(beverageLayout);

            // Add the beverages to the layout
            int index = 0;
            foreach (var beverage in beverages)
            {
                //MessageBox.Show(beverage.MenuImagePath);
                Panel beverageItem = CreateBeveragePanel(beverage, index);
                beverageLayout.Controls.Add(beverageItem);
                index++;
            }

            this.Controls.Add(menuPanel);
        }

        private Panel CreateBeveragePanel(Beverage beverage, int index)
        {
            Panel panel = new Panel
            {
                Width = 250,
                Height = 300,
                Margin = new Padding(15),
                BorderStyle = BorderStyle.FixedSingle
            };

            // Create PictureBox to display beverage image
            PictureBox pictureBox = new PictureBox
            {
                Width = 200,
                Height = 150,
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(25, 20),
                BorderStyle = BorderStyle.FixedSingle
            };

            // Load the image from the file path
            try
            {
                pictureBox.Image = Image.FromFile(beverage.MenuImagePath);
                
            }
            catch (Exception ex)
            {
                // Handle the exception if the image file is not found
                //MessageBox.Show($"Error loading image: {beverage.MenuImagePath}");
                //MessageBox.Show(System.IO.Path.GetDirectoryName(Application.ExecutablePath));
                pictureBox.BackColor = Color.LightGray; // Set a default background color in case of error
            }

            // Temporarily use color to replace image
            //pictureBox.BackColor = index == 0 ? Color.Brown : (index == 1 ? Color.DarkOrange : Color.Pink);

            // Create beverage name label
            Label nameLabel = new Label
            {
                Text = beverage.Name,
                Font = new Font("Arial", 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Width = 250,
                Location = new Point(0, 180)
            };

            // Create beverage description label
            Label descriptionLabel = new Label
            {
                Text = beverage.Description,
                Font = new Font("Arial", 9),
                TextAlign = ContentAlignment.TopCenter,
                Width = 230,
                Height = 40,
                Location = new Point(10, 210)
            };

            // Create "Prepare" button
            Button prepareButton = new Button
            {
                Text = "Prepare",
                Width = 100,
                Height = 30,
                Location = new Point(75, 255),
                Tag = index  // Store beverage index
            };

            prepareButton.Click += (sender, e) =>
            {
                int beverageIndex = (int)((Button)sender).Tag;
                // Launch the PreparationForm
                Prepare preparationForm = new Prepare(beverages[beverageIndex]);
                preparationForm.ShowDialog();
            };

            panel.Controls.Add(pictureBox);
            panel.Controls.Add(nameLabel);
            panel.Controls.Add(descriptionLabel);
            panel.Controls.Add(prepareButton);

            return panel;
        }
    }
}