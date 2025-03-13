using System;
using System.Drawing;
using System.Windows.Forms;
using DemoTemplateMethod.Beverages;
using System.Diagnostics;

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
            beverage.Prepare();
            UpdateStepDisplay(); // Initial call to set the correct initial values of images and description before it loads.
            //base.OnLoad(e);
        }

        protected override void OnLoad(EventArgs e)
        {
             //Call to prepare 
        }

        //New Local var
        private string stepDescription = string.Empty;
        // string stepImage = string.Empty;

        //Updated method for moving and triggering functions
        //NOTE this update will pull information local, and not from prepare()
        private void UpdateStepDisplay()
        {


            stepNumberLabel.Text = $"Step {currentStep + 1}/{beverage.StepDescriptions.Count}";

            List<string> stepImagePaths = beverage.StepImages;


            try
            {
                //Lets try and set the image to what we hope to find based on name.
                // stepImage.Image = Image.FromFile(stepImage);
                stepDescriptionLabel.Text = beverage.StepDescriptions[currentStep];
                stepImage.Image = Image.FromFile(beverage.StepImages[currentStep]);

            }
            catch (Exception ex)
            {
                // Handle the exception as necessary:
                Console.WriteLine("Unable to load image: " + ex.Message);
            }

            prevButton.Enabled = (currentStep > 0);
            nextButton.Enabled = (currentStep < beverage.StepDescriptions.Count - 1);

        }

        private void InitializeUI()
        {
            this.ClientSize = new Size(900, 600);  
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
                Location = new Point(20, 40),
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.Zoom
            };

            stepNumberLabel = new Label
            {
                Text = "Step 1/5",
                Font = new Font("Arial", 16, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(440, 40),
                Size = new Size(430, 40)
            };

            stepDescriptionLabel = new Label
            {
                Font = new Font("Arial", 12),
                TextAlign = ContentAlignment.TopLeft,
                Location = new Point(440, 80),
                Size = new Size(430, 340)
            };

            prevButton = new Button
            {
                Text = "< Previous",
                Width = 100,
                Height = 40,
                Location = new Point(220, 460) //Adjust to be relative to the image panel
            };

            nextButton = new Button
            {
                Text = "Next >",
                Width = 100,
                Height = 40,
                Location = new Point(340, 460)  //Adjust to be relative to the image panel
            };
            backToMenuButton = new Button
            {
                Text = "Back to Menu",
                Width = 120,
                Height = 30,
                Location = new Point(0, 0)
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
        //Movements
        private void NextButton_Click(object sender, EventArgs e)
        {
            //call a method to proceed
            UpdateStep("Next");
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            // call a method to reverse
            UpdateStep("Prev");
        }
        //Movements with validation
        private void UpdateStep(string direction)
        {
            if (direction == "Next")
            {
                if (beverage.StepDescriptions.Count > currentStep + 1)
                    currentStep++;

            }
            else
            {
                if (currentStep > 0)
                    currentStep--;

            }

            UpdateStepDisplay(); //Now lets call for it to happen

        }
    }
}