using System;
using System.Drawing;
using System.Windows.Forms;
using DemoTemplateMethod.Beverages;

namespace DemoTemplateMethod
{
    public partial class PreparationForm : Form
    {
        private Beverage beverage;
        private int currentStep = 0;

        public PreparationForm(Beverage beverage)
        {
            InitializeComponent();
            InitializeUI();
            this.beverage = beverage;
            InitializePreparationPanel();
            UpdateStepDisplay();
        }

        private void InitializeUI()
        {
            this.ClientSize = new Size(900, 600);  // Adjust as needed
            this.Text = "Preparation Steps";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Initialize any controls here. You can also do it via the Designer.
            stepImage = new PictureBox
            {
                Width = 400,
                Height = 400,
                Location = new Point(20, 20),
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.Zoom
            };

            stepNumberLabel = new Label
            {
                Text = "Step 1/5",
                Font = new Font("Arial", 16, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(440, 20),
                Size = new Size(430, 40)
            };

            stepDescriptionLabel = new Label
            {
                Font = new Font("Arial", 12),
                TextAlign = ContentAlignment.TopLeft,
                Location = new Point(440, 60),
                Size = new Size(430, 340)
            };

            prevButton = new Button
            {
                Text = "< Previous",
                Width = 100,
                Height = 40,
                Location = new Point(220, 440) //Adjust to be relative to the image panel
            };

            nextButton = new Button
            {
                Text = "Next >",
                Width = 100,
                Height = 40,
                Location = new Point(340, 440)  //Adjust to be relative to the image panel
            };
            backToMenuButton = new Button
            {
                Text = "Back to Menu",
                Width = 120,
                Height = 30,
                Location = new Point(20, 5)
            };

            backToMenuButton.Click += (sender, e) => {
                this.Close();
            };

            prevButton.Click += PrevButton_Click;
            nextButton.Click += NextButton_Click;

            // Add Controls to the Form
            this.Controls.Add(stepImage);
            this.Controls.Add(stepNumberLabel);
            this.Controls.Add(stepDescriptionLabel);
            this.Controls.Add(prevButton);
            this.Controls.Add(nextButton);
            this.Controls.Add(backToMenuButton);
        }

        private Panel preparationPanel;
        private PictureBox stepImage;
        private Label stepNumberLabel;
        private Label stepDescriptionLabel;
        private Button prevButton;
        private Button nextButton;
        private Button backToMenuButton;

        private void InitializePreparationPanel()
        {
            // You can initialize here common properties like background color, padding
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (currentStep < beverage.GetStepDescriptions().Length - 1)
            {
                currentStep++;
                UpdateStepDisplay();
            }
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            if (currentStep > 0)
            {
                currentStep--;
                UpdateStepDisplay();
            }
        }
        private void UpdateStepDisplay()
        {
            string[] stepDescriptions = beverage.GetStepDescriptions();
            string[] stepImagePaths = beverage.GetStepImagePaths();

            stepNumberLabel.Text = $"Step {currentStep + 1}/{stepDescriptions.Length}";
            stepDescriptionLabel.Text = stepDescriptions[currentStep];
            // Set text wrapping
            stepDescriptionLabel.AutoSize = true;
            stepDescriptionLabel.MaximumSize = new Size(430, 0);
            if (stepImagePaths != null && stepImagePaths.Length > currentStep)
            {
                try
                {
                    stepImage.Image = Image.FromFile(stepImagePaths[currentStep]);
                }
                catch (Exception ex)
                {
                    // Handle the exception as necessary:
                    Console.WriteLine("Unable to load image: " + ex.Message);
                }

            }
            else
            {
                stepImage.Image = null; // or some default image
            }

            prevButton.Enabled = (currentStep > 0);
            nextButton.Enabled = (currentStep < stepDescriptions.Length - 1);

        }
    }
}