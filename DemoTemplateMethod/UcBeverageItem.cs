using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoTemplateMethod.Beverages;

namespace DemoTemplateMethod
{
    public partial class UcBeverageItem : UserControl
    {
        public Beverage beverage;

        public UcBeverageItem(Beverage beverage)
        {
            InitializeComponent();

            this.beverage = beverage;

            try
            {
                pictureBox1.Image = Image.FromFile(beverage.MenuImagePath); // Access UI elements AFTER InitializeComponent
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., image not found)
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // You might want to set a default image here to avoid a blank image
                pictureBox1.Image = pictureBox1.ErrorImage; //If you set an ErrorImage in the designer
            }

            lblName.Text = beverage.Name;
            lblDescription.Text = beverage.Description;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPrepare preparationForm = new FormPrepare(beverage);
            preparationForm.ShowDialog();
        }

    }
}