using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTemplateMethod.Beverages
{
    // Class Soda
    public class Soda : Beverage
    {
        public Soda()
        {
            Name = "Sparkling Soda";
            Description = "Refreshing soda with flavorings";
            MenuImagePath = ImagePathHelper.GetImagePath("soda_menu.jpg");
        }

        protected override void PrepareIngredients()
        {
            CurrentStepDescription = "Prepare: Soda water, flavored syrup (e.g., raspberry, lemon), ice";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("soda_step1.jpg");
        }

        protected override void BrewMainIngredient()
        {
            // No brewing needed for soda
            CurrentStepDescription = "No brewing required";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("blank_image.jpg"); // Use a blank image or a suitable placeholder
        }

        protected override void AddCustomIngredients()
        {
            CurrentStepDescription = "Add flavor: Pour the flavored syrup into the glass";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("soda_step2.jpg");
        }

        protected override void FinishAndDecorate()
        {
            CurrentStepDescription = "Add soda water: Gently pour soda water into the glass to mix with syrup";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("soda_step3.jpg");
        }

        protected override void Serve()
        {
            CurrentStepDescription = "Serve: Add ice cubes and garnish with a lemon slice. Enjoy!";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("soda_step4.jpg");
        }
    }
}
