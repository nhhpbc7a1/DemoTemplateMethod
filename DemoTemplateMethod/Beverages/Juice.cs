using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTemplateMethod.Beverages
{
    // Class Juice
    public class Juice : Beverage
    {
        public Juice()
        {
            Name = "Freshly Squeezed Juice";
            Description = "Healthy and refreshing juice from fresh fruits";
            MenuImagePath = ImagePathHelper.GetImagePath("juice_menu.jpg");
        }

        protected override void PrepareIngredients()
        {
            CurrentStepDescription = "Prepare: Fresh fruits (e.g., oranges, apples, berries), juicer, glass";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("juice_step1.jpg");
        }

        protected override void BrewMainIngredient()
        {
            //No brewing required for juice
            CurrentStepDescription = "No brewing required";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("blank_image.jpg"); // Use a blank image or a suitable placeholder
        }

        protected override void AddCustomIngredients()
        {
            CurrentStepDescription = "Juice the fruits: Feed the fruits into the juicer";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("juice_step2.jpg");
        }

        protected override void FinishAndDecorate()
        {
            CurrentStepDescription = "Strain (optional): Strain the juice to remove pulp if desired";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("juice_step3.jpg");
        }

        protected override void Serve()
        {
            CurrentStepDescription = "Serve: Pour into a glass and enjoy immediately! Add ice if desired.";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("juice_step4.jpg");
        }

    }
}
