using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTemplateMethod.Beverages
{
    // Class Matcha
    public class Matcha : Beverage
    {
        public Matcha()
        {
            Name = "Matcha Latte";
            Description = "Creamy matcha latte with milk";
            MenuImagePath = ImagePathHelper.GetImagePath("matcha_menu.jpg");
        }

        protected override void PrepareIngredients()
        {
            CurrentStepDescription = "Prepare: Matcha powder, hot water, milk (dairy or non-dairy), sweetener (optional)";
            CurrentStepImage = ImagePathHelper.GetImagePath("matcha_step1.jpg");
        }

        protected override void BrewMainIngredient()
        {
            CurrentStepDescription = "Prepare matcha: Whisk matcha powder with a small amount of hot water until smooth";
            CurrentStepImage = ImagePathHelper.GetImagePath("matcha_step2.jpg");
        }

        protected override void AddCustomIngredients()
        {
            CurrentStepDescription = "Froth milk: Heat and froth milk until foamy (optional)";
            CurrentStepImage = ImagePathHelper.GetImagePath("matcha_step3.jpg");
        }

        protected override void FinishAndDecorate()
        {
            CurrentStepDescription = "Combine: Pour the matcha mixture into a glass, then add the frothed milk";
            CurrentStepImage = ImagePathHelper.GetImagePath("matcha_step4.jpg");
        }

        protected override void Serve()
        {
            CurrentStepDescription = "Serve: Sprinkle with matcha powder on top (optional) and enjoy!";
            CurrentStepImage = ImagePathHelper.GetImagePath("matcha_step5.jpg");
        }
    }

}
