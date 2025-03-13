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
    public partial class MainInterface : Form
    {
        public MainInterface()
        {
            InitializeComponent();
        }

        private void MainInterface_Load(object sender, EventArgs e)
        {
            List<Beverage> list = new List<Beverage>()
            {
                new Coffee(),
                new Tea(),
                new Smoothie(),
                new Soda(),
                new Juice(),
                new Matcha(),
            };

            LoadBeverages(list); // Call LoadBeverages here.
        }

        private async void LoadBeverages(List<Beverage> list)
        {
            flowLayoutPanel1.SuspendLayout(); // Stop painting while adding controls

            foreach (var beverage in list)
            {
                UcBeverageItem item = new UcBeverageItem(beverage);
                flowLayoutPanel1.Controls.Add(item);
            }
            flowLayoutPanel1.ResumeLayout(true); // resume painting.
        }

    }
}