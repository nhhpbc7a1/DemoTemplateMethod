using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DemoTemplateMethod.Beverages;

namespace DemoTemplateMethod
{
    public partial class FormPrepare : Form
    {
        private Beverage _beverage;
        private List<StepPanel> _stepPanels = new List<StepPanel>();
        private int _currentStepIndex = -1;
        private bool _autoPlayEnabled = true;

        // Các tiêu đề bước
        private static readonly string[] stepTitles = new string[]
        {
            "I. Prepare Ingredients",
            "II. Brew Main Ingredient",
            "III. Add Custom Ingredients",
            "IV. Finish And Decorate",
            "V. Serve"
        };

        public FormPrepare(Beverage beverage)
        {
            beverage.Prepare();
            InitializeComponent();
            _beverage = beverage;
            this.lblTitle.Text = $"Preparing: {_beverage.Name}";
        }

        private void FormPrepare_Load(object sender, EventArgs e)
        {
            // Khởi tạo trạng thái các nút
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;

            // Tạo các panel cho từng bước
            CreateStepPanels();

            // Bắt đầu hiển thị các bước
            timer.Start();
        }

        private void CreateStepPanels()
        {
            int panelHeight = 120;
            int padding = 10;

            for (int i = 0; i < 5; i++)
            {
                StepPanel panel = new StepPanel
                {
                    Title = stepTitles[i],
                    Description = "",
                    StepState = i == 0 ? StepState.Loading : StepState.Pending,
                    Size = new Size(panelSteps.Width - 40, panelHeight),
                    Location = new Point(0, i * (panelHeight + padding)),
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
                };

                _stepPanels.Add(panel);
                panelSteps.Controls.Add(panel);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Chuyển sang bước tiếp theo
            GoToNextStep();
        }

        private void GoToNextStep()
        {
            _currentStepIndex++;

            // Dừng timer nếu đã hoàn thành tất cả các bước
            if (_currentStepIndex >= 5)
            {
                timer.Stop();
                _autoPlayEnabled = false;
                btnStartStop.Text = "Start";
                btnStartStop.BackColor = Color.FromArgb(40, 167, 69);
                btnNext.Enabled = false;
                btnPrevious.Enabled = true;
                return;
            }

            // Cập nhật trạng thái các nút
            UpdateButtonState();

            // Cập nhật trạng thái của các bước
            UpdateStepStates();
        }

        private void GoToPreviousStep()
        {
            if (_currentStepIndex <= 0)
                return;

            _currentStepIndex--;

            // Cập nhật trạng thái các nút
            UpdateButtonState();

            // Cập nhật trạng thái của các bước
            UpdateStepStates();
        }

        private void UpdateButtonState()
        {
            // Cập nhật nút Previous
            btnPrevious.Enabled = _currentStepIndex > 0;

            // Cập nhật nút Next
            btnNext.Enabled = _currentStepIndex < 4;
        }

        private void UpdateStepStates()
        {
            // Cập nhật trạng thái tất cả các bước
            for (int i = 0; i < _stepPanels.Count; i++)
            {
                if (i < _currentStepIndex)
                {
                    _stepPanels[i].StepState = StepState.Completed;
                    _stepPanels[i].Description = _beverage.StepDescriptions[i];
                }
                else if (i == _currentStepIndex)
                {
                    _stepPanels[i].Description = _beverage.StepDescriptions[i];
                    _stepPanels[i].StepState = StepState.Loading;

                    // Cập nhật hình ảnh
                    UpdateStepImage(i);
                }
                else
                {
                    _stepPanels[i].StepState = StepState.Pending;
                    _stepPanels[i].Description = "";
                }
            }
        }

        private void UpdateStepImage(int stepIndex)
        {
            try
            {
                if (File.Exists(_beverage.StepImagePaths[stepIndex]))
                {
                    using (var stream = new FileStream(_beverage.StepImagePaths[stepIndex], FileMode.Open, FileAccess.Read))
                    {
                        pictureBoxStep.Image = Image.FromStream(stream);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            // Dừng tự động phát nếu đang bật
            if (_autoPlayEnabled)
            {
                _autoPlayEnabled = false;
                timer.Stop();
                btnStartStop.Text = "Start";
                btnStartStop.BackColor = Color.FromArgb(40, 167, 69);
            }

            GoToPreviousStep();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Dừng tự động phát nếu đang bật
            if (_autoPlayEnabled)
            {
                _autoPlayEnabled = false;
                timer.Stop();
                btnStartStop.Text = "Start";
                btnStartStop.BackColor = Color.FromArgb(40, 167, 69);
            }

            GoToNextStep();
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (_autoPlayEnabled)
            {
                // Dừng tự động phát
                _autoPlayEnabled = false;
                timer.Stop();
                btnStartStop.Text = "Start";
                btnStartStop.BackColor = Color.FromArgb(40, 167, 69);
            }
            else
            {
                // Bật tự động phát nếu chưa hoàn thành
                if (_currentStepIndex < 4)
                {
                    _autoPlayEnabled = true;
                    timer.Start();
                    btnStartStop.Text = "Stop";
                    btnStartStop.BackColor = Color.FromArgb(220, 53, 69);
                }
            }
        }
    }

    // Enum định nghĩa trạng thái của bước
    public enum StepState
    {
        Pending,
        Loading,
        Completed
    }

    // Custom control hiển thị một bước
    public class StepPanel : Panel
    {
        private Label lblTitle;
        private Label lblDescription;
        private PictureBox pictureBoxStatus;
        private System.Windows.Forms.Timer animationTimer;
        private int loadingIconFrame = 0;
        private StepState _stepState;

        public string Title
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }

        public string Description
        {
            get { return lblDescription.Text; }
            set
            {
                lblDescription.Text = value;
                lblDescription.Visible = !string.IsNullOrEmpty(value);
            }
        }

        public StepState StepState
        {
            get { return _stepState; }
            set
            {
                _stepState = value;
                UpdateAppearance();
            }
        }

        public StepPanel()
        {
            InitializeComponent();
            animationTimer = new System.Windows.Forms.Timer
            {
                Interval = 100,
                Enabled = false
            };
            animationTimer.Tick += AnimationTimer_Tick;
        }

        private void InitializeComponent()
        {
            this.BackColor = Color.FromArgb(245, 245, 245);
            this.Padding = new Padding(15);
            this.BorderStyle = BorderStyle.None;

            // Khởi tạo icon trạng thái
            pictureBoxStatus = new PictureBox
            {
                Size = new Size(24, 24),
                Location = new Point(15, 15),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.Transparent
            };
            this.Controls.Add(pictureBoxStatus);

            // Khởi tạo tiêu đề
            lblTitle = new Label
            {
                AutoSize = false,
                Size = new Size(Width - 90, 24),
                Location = new Point(50, 15),
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft
            };
            this.Controls.Add(lblTitle);

            // Khởi tạo mô tả
            lblDescription = new Label
            {
                AutoSize = false,
                Size = new Size(Width - 50, 60),
                Location = new Point(50, 45),
                Font = new Font("Segoe UI", 9),
                TextAlign = ContentAlignment.TopLeft,
                Visible = false
            };
            this.Controls.Add(lblDescription);

            this.Resize += StepPanel_Resize;
        }

        private void StepPanel_Resize(object sender, EventArgs e)
        {
            lblTitle.Width = Width - 90;
            lblDescription.Width = Width - 50;
        }

        private void UpdateAppearance()
        {
            switch (_stepState)
            {
                case StepState.Pending:
                    this.BackColor = Color.FromArgb(245, 245, 245);
                    this.ForeColor = Color.Gray;
                    pictureBoxStatus.Image = CreateCircleImage(20, Color.LightGray);
                    animationTimer.Stop();
                    break;

                case StepState.Loading:
                    this.BackColor = Color.FromArgb(232, 244, 255);
                    this.ForeColor = Color.Black;
                    animationTimer.Start();
                    break;

                case StepState.Completed:
                    this.BackColor = Color.FromArgb(240, 255, 240);
                    this.ForeColor = Color.Black;
                    pictureBoxStatus.Image = CreateCheckmarkImage();
                    animationTimer.Stop();
                    break;
            }
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            loadingIconFrame = (loadingIconFrame + 1) % 8;
            pictureBoxStatus.Image = CreateLoadingImage(loadingIconFrame);
        }

        private Bitmap CreateCircleImage(int size, Color color)
        {
            Bitmap bmp = new Bitmap(size, size);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);
                using (SolidBrush brush = new SolidBrush(color))
                {
                    g.FillEllipse(brush, 0, 0, size - 1, size - 1);
                }
            }
            return bmp;
        }

        private Bitmap CreateCheckmarkImage()
        {
            Bitmap bmp = new Bitmap(24, 24);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);

                // Vẽ hình tròn xanh
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(76, 175, 80)))
                {
                    g.FillEllipse(brush, 0, 0, 23, 23);
                }

                // Vẽ dấu tích
                using (Pen pen = new Pen(Color.White, 2))
                {
                    g.DrawLine(pen, 6, 12, 10, 16);
                    g.DrawLine(pen, 10, 16, 18, 8);
                }
            }
            return bmp;
        }

        private Bitmap CreateLoadingImage(int frame)
        {
            Bitmap bmp = new Bitmap(24, 24);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);

                // Tạo hiệu ứng loading xoay tròn
                using (Pen pen = new Pen(Color.FromArgb(33, 150, 243), 2))
                {
                    float startAngle = frame * 45;
                    g.DrawArc(pen, 2, 2, 20, 20, startAngle, 270);
                }
            }
            return bmp;
        }
    }

}