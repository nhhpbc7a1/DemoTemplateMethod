using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using DemoTemplateMethod.Beverages;

namespace DemoTemplateMethod
{
    public partial class Prepare : Form
    {
        private Beverage _beverage;
        private int _currentStep = 0;
        private readonly string[] _steps = new string[]
        {
            "1. Chuẩn bị nguyên liệu & dụng cụ",
            "2. Ủ hoặc pha chế nguyên liệu chính",
            "3. Thêm thành phần tùy chỉnh",
            "4. Hoàn thiện & trang trí",
            "5. Phục vụ & thưởng thức"
        };
        // UI Controls
        private Panel[] _stepPanels;
        private Label[] _stepLabels;
        private PictureBox _animationBox;
        private Label _stepDescriptionLabel;
        private SplitContainer _mainSplitContainer;
        private Button _btnPrevious;
        private Button _btnNext;
        private Color _accentColor = Color.FromArgb(41, 128, 185); // Màu chủ đạo
        private Color _lightAccentColor = Color.FromArgb(165, 205, 236); // Màu nhạt của chủ đạo
        private Color _darkTextColor = Color.FromArgb(44, 62, 80); // Màu chữ tối
        private Color _backgroundColor = Color.FromArgb(245, 245, 245); // Màu nền nhẹ

        public Prepare()
        {
            InitializeComponent();
        }

        public Prepare(Beverage beverage) : this()
        {
            _beverage = beverage;

            // Thiết lập Form
            this.Text = $"Hướng dẫn pha chế {beverage?.Name ?? "đồ uống"}";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1000, 700);
            this.MinimumSize = new Size(800, 600);

            SetupUI();
            UpdateCurrentStep(0);
        }

        private void SetupUI()
        {
            this.BackColor = _backgroundColor;

            // Main split container to divide the form
            _mainSplitContainer = new SplitContainer
            {
                Dock = DockStyle.Fill,
                SplitterDistance = 350,
                FixedPanel = FixedPanel.Panel1,
                IsSplitterFixed = true,
                BackColor = _backgroundColor,
                BorderStyle = BorderStyle.None
            };
            this.Controls.Add(_mainSplitContainer);

            // Left panel for steps
            Panel stepsPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Padding = new Padding(15)
            };
            _mainSplitContainer.Panel1.Controls.Add(stepsPanel);
            AddDropShadow(_mainSplitContainer.Panel1);

            // Title for the left panel
            Panel titlePanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 80,
                BackColor = _accentColor
            };
            stepsPanel.Controls.Add(titlePanel);

            Label titleLabel = new Label
            {
                Text = _beverage != null ?
                      $"QUY TRÌNH CHẾ BIẾN\n{_beverage.Name.ToUpper()}" :
                      "QUY TRÌNH CHẾ BIẾN ĐỒ UỐNG",
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White
            };
            titlePanel.Controls.Add(titleLabel);

            // Create panels and labels for each step
            _stepPanels = new Panel[_steps.Length];
            _stepLabels = new Label[_steps.Length];
            int panelHeight = 70;
            int margin = 10;

            Panel stepsContainer = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Padding = new Padding(0, 20, 0, 0)
            };
            stepsPanel.Controls.Add(stepsContainer);

            for (int i = 0; i < _steps.Length; i++)
            {
                _stepPanels[i] = new Panel
                {
                    Height = panelHeight,
                    Dock = DockStyle.Top,
                    Margin = new Padding(0, margin, 0, 0),
                    Padding = new Padding(15, 0, 15, 0),
                    BackColor = Color.WhiteSmoke,
                    Tag = i // Store step index
                };

                _stepLabels[i] = new Label
                {
                    Text = _steps[i],
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Fill,
                    Font = new Font("Segoe UI", 11),
                    ForeColor = _darkTextColor,
                    Cursor = Cursors.Hand
                };

                _stepPanels[i].Click += (sender, e) =>
                {
                    Panel clickedPanel = sender as Panel;
                    if (clickedPanel != null && clickedPanel.Tag is int stepIndex)
                    {
                        UpdateCurrentStep(stepIndex);
                        _btnPrevious.Enabled = stepIndex > 0;
                        _btnNext.Text = stepIndex == _steps.Length - 1 ? "Hoàn thành" : "Bước tiếp theo";
                        _btnNext.Enabled = true;
                    }
                };

                _stepLabels[i].Click += (sender, e) =>
                {
                    Label clickedLabel = sender as Label;
                    if (clickedLabel != null && clickedLabel.Parent is Panel parentPanel && parentPanel.Tag is int stepIndex)
                    {
                        UpdateCurrentStep(stepIndex);
                        _btnPrevious.Enabled = stepIndex > 0;
                        _btnNext.Text = stepIndex == _steps.Length - 1 ? "Hoàn thành" : "Bước tiếp theo";
                        _btnNext.Enabled = true;
                    }
                };

                _stepPanels[i].Controls.Add(_stepLabels[i]);

                // Add vertical line connecting steps
                if (i < _steps.Length - 1)
                {
                    Panel connector = new Panel
                    {
                        Width = 2,
                        Height = margin,
                        BackColor = Color.LightGray,
                        Location = new Point(25, panelHeight)
                    };
                    _stepPanels[i].Controls.Add(connector);
                }

                // Add steps in reverse order for correct display
                stepsContainer.Controls.Add(_stepPanels[_steps.Length - 1 - i]);
            }

            // Right panel for animation
            Panel animationPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Padding = new Padding(20)
            };
            _mainSplitContainer.Panel2.Controls.Add(animationPanel);
            AddDropShadow(_mainSplitContainer.Panel2);

            // Title for the right panel
            Panel animationTitlePanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 60,
                BackColor = _accentColor
            };
            animationPanel.Controls.Add(animationTitlePanel);

            Label animationTitleLabel = new Label
            {
                Text = "MINH HỌA THỰC HIỆN",
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White
            };
            animationTitlePanel.Controls.Add(animationTitleLabel);

            // Step description label
            _stepDescriptionLabel = new Label
            {
                Text = "",
                Dock = DockStyle.Top,
                Font = new Font("Segoe UI", 11, FontStyle.Italic),
                Height = 70,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = _darkTextColor,
                BackColor = Color.WhiteSmoke,
                Margin = new Padding(0, 15, 0, 0)
            };
            animationPanel.Controls.Add(_stepDescriptionLabel);

            // PictureBox for GIF animation with border
            Panel animationBoxContainer = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(0, 15, 0, 15),
                BackColor = Color.Transparent
            };
            animationPanel.Controls.Add(animationBoxContainer);

            _animationBox = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.Zoom,
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                BorderStyle = BorderStyle.None
            };
            animationBoxContainer.Controls.Add(_animationBox);
            AddDropShadow(_animationBox);

            // Control panel for navigation buttons
            Panel controlPanel = new Panel
            {
                Height = 70,
                Dock = DockStyle.Bottom,
                BackColor = Color.White,
                Padding = new Padding(0, 10, 0, 10)
            };
            animationPanel.Controls.Add(controlPanel);

            // Previous button
            _btnPrevious = CreateStyledButton("Bước trước", 130, 45);
            _btnPrevious.Location = new Point(60, 12);
            _btnPrevious.Enabled = false;
            _btnPrevious.Click += BtnPrevious_Click;
            _btnPrevious.ImageAlign = ContentAlignment.MiddleLeft;
            _btnPrevious.TextAlign = ContentAlignment.MiddleRight;
            _btnPrevious.TextImageRelation = TextImageRelation.ImageBeforeText;
            _btnPrevious.Padding = new Padding(10, 0, 10, 0);
            controlPanel.Controls.Add(_btnPrevious);

            // Next button
            _btnNext = CreateStyledButton("Bước tiếp theo", 150, 45);
            _btnNext.Location = new Point(_mainSplitContainer.Panel2.Width - 210, 12);
            _btnNext.Anchor = AnchorStyles.Right;
            _btnNext.Click += BtnNext_Click;
            _btnNext.ImageAlign = ContentAlignment.MiddleRight;
            _btnNext.TextAlign = ContentAlignment.MiddleLeft;
            _btnNext.TextImageRelation = TextImageRelation.TextBeforeImage;
            _btnNext.Padding = new Padding(10, 0, 10, 0);
            controlPanel.Controls.Add(_btnNext);
        }

        private Button CreateStyledButton(string text, int width, int height)
        {
            Button button = new Button
            {
                Text = text,
                Width = width,
                Height = height,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                BackColor = _accentColor,
                ForeColor = Color.White,
                FlatAppearance =
                {
                    BorderSize = 0,
                    MouseOverBackColor = Color.FromArgb(52, 152, 219),
                    MouseDownBackColor = Color.FromArgb(41, 128, 185)
                },
                Cursor = Cursors.Hand
            };
            return button;
        }

        private void AddDropShadow(Control control)
        {
            // Thêm panel bên ngoài control để tạo bóng đổ
            if (control.Parent != null)
            {
                Panel shadowPanel = new Panel
                {
                    BackColor = Color.Transparent,
                    Size = new Size(control.Width + 6, control.Height + 6),
                    Location = new Point(control.Left - 3, control.Top - 3),
                    Padding = new Padding(3)
                };

                if (control.Parent != null && !control.Parent.Controls.IsReadOnly)
                {
                    control.Parent.Controls.Add(shadowPanel);
                }
    
                control.Location = new Point(3, 3);

                shadowPanel.Paint += (sender, e) =>
                {
                    using (GraphicsPath path = new GraphicsPath())
                    {
                        path.AddRectangle(new Rectangle(0, 0, shadowPanel.Width, shadowPanel.Height));
                        using (PathGradientBrush brush = new PathGradientBrush(path))
                        {
                            brush.CenterColor = Color.FromArgb(60, 0, 0, 0);
                            brush.SurroundColors = new Color[] { Color.Transparent };
                            brush.FocusScales = new PointF(0.95f, 0.95f);
                            e.Graphics.FillPath(brush, path);
                        }
                    }
                };
            }
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (_currentStep > 0)
            {
                UpdateCurrentStep(_currentStep - 1);
                _btnPrevious.Enabled = _currentStep > 0;
                _btnNext.Text = _currentStep == _steps.Length - 1 ? "Hoàn thành" : "Bước tiếp theo";
                _btnNext.Enabled = true;
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (_currentStep < _steps.Length - 1)
            {
                UpdateCurrentStep(_currentStep + 1);
                _btnPrevious.Enabled = true;
                _btnNext.Text = _currentStep == _steps.Length - 1 ? "Hoàn thành" : "Bước tiếp theo";
            }
            else
            {
                this.Close(); // Close the form when finished
            }
        }

        private void UpdateCurrentStep(int step)
        {
            _currentStep = step;

            // Update step panels
            for (int i = 0; i < _steps.Length; i++)
            {
                if (i == _currentStep)
                {
                    _stepPanels[i].BackColor = _lightAccentColor;
                    _stepLabels[i].Font = new Font("Segoe UI", 11, FontStyle.Bold);
                    _stepLabels[i].ForeColor = _accentColor;

                    // Add indicator for active step
                    Panel indicator = new Panel
                    {
                        Width = 6,
                        Dock = DockStyle.Left,
                        BackColor = _accentColor
                    };

                    // Remove any existing indicators first
                    foreach (Control c in _stepPanels[i].Controls)
                    {
                        if (c is Panel p && p.Dock == DockStyle.Left && p.Width == 6)
                        {
                            _stepPanels[i].Controls.Remove(p);
                            p.Dispose();
                        }
                    }

                    _stepPanels[i].Controls.Add(indicator);
                    indicator.BringToFront();
                }
                else
                {
                    _stepPanels[i].BackColor = Color.WhiteSmoke;
                    _stepLabels[i].Font = new Font("Segoe UI", 11);
                    _stepLabels[i].ForeColor = _darkTextColor;

                    // Remove any indicators
                    foreach (Control c in _stepPanels[i].Controls)
                    {
                        if (c is Panel p && p.Dock == DockStyle.Left && p.Width == 6)
                        {
                            _stepPanels[i].Controls.Remove(p);
                            p.Dispose();
                        }
                    }
                }
            }

            // Update the step description
            UpdateStepDescription();

            // Update the animation
            LoadAnimationForCurrentStep();
        }

        private void UpdateStepDescription()
        {
            
        }

        private void LoadAnimationForCurrentStep()
        {
            try
            {
                if (_beverage == null)
                    return;

                string animationPath = GetAnimationPathForCurrentStep();

                if (File.Exists(animationPath))
                {
                    // Use Image.FromFile for GIFs to ensure animation works
                    _animationBox.Image = Image.FromFile(animationPath);
                }
                else
                {
                    // If GIF not found, display a placeholder
                    _animationBox.Image = null;

                    // Create a placeholder image
                    Bitmap placeholder = new Bitmap(_animationBox.Width, _animationBox.Height);
                    using (Graphics g = Graphics.FromImage(placeholder))
                    {
                        g.Clear(Color.WhiteSmoke);


                     

                        // Draw text
                        StringFormat sf = new StringFormat
                        {
                            Alignment = StringAlignment.Center,
                            LineAlignment = StringAlignment.Center
                        };

                        using (Font font = new Font("Segoe UI", 12))
                        {
                            Rectangle textRect = new Rectangle(0,
                                (_animationBox.Height / 2),
                                _animationBox.Width,
                                40);

                            g.DrawString($"Đang cập nhật hình ảnh",
                                font,
                                new SolidBrush(_darkTextColor),
                                textRect,
                                sf);

                            g.DrawString($"{_steps[_currentStep]}",
                                new Font("Segoe UI", 10, FontStyle.Italic),
                                new SolidBrush(Color.Gray),
                                new Rectangle(0, (_animationBox.Height / 2) + 40, _animationBox.Width, 30),
                                sf);
                        }
                    }

                    _animationBox.Image = placeholder;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải animation: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetAnimationPathForCurrentStep()
        {
            // Construct path based on beverage type and current step
            string beverageFolder = _beverage.GetType().Name.ToLower();
            string animationFileName = $"step{_currentStep + 1}.gif";

            // Example path: ./Animations/coffee/step1.gif
            return Path.Combine(Application.StartupPath, "Animations", beverageFolder, animationFileName);
        }
    }
}