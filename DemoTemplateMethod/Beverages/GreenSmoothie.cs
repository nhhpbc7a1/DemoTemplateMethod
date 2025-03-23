using System;

namespace DemoTemplateMethod.Beverages
{
    // Class GreenSmoothie
    public class GreenSmoothie : Beverage
    {
        public GreenSmoothie()
        {
            Name = "Green Smoothie";
            Description = "Refreshing and healthy green smoothie with secret ingredients";
            MenuImagePath = ImagePathHelper.GetImagePath("green_smoothie_menu.jpg"); // Placeholder - replace with actual image path
        }

        protected override void PrepareIngredients()
        {
            CurrentStepDescription = "- Kale (or Spinach)\n"
                                   + "- Favorite Fruit (e.g., banana, berries, mango)\n"
                                   + "- Fresh Ginger (small piece)\n"
                                   + "- Fresh Mint (a few leaves)\n"
                                   + "- Flaxseed Oil\n"
                                   + "- (Optional) Protein Powder or Chia Seeds\n"
                                   + "- Water or Milk (Almond, Coconut, etc.)\n"
                                   + "- Blender";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("green_smoothie_step1.jpg"); // Placeholder - replace with actual image path
        }

        protected override void BrewMainIngredient()
        {
            // No brewing in a traditional sense for a smoothie, so we'll just describe the blending process.  This keeps the Template Method structure.
            CurrentStepDescription = "1. Add all ingredients to a high-power blender.\n"
                                   + "2. Start with a small amount of liquid (water or milk) and add more as needed to achieve desired consistency.";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("green_smoothie_step2.jpg"); // Placeholder - replace with actual image path
        }

        protected override void AddCustomIngredients()
        {
            //  All ingredients are added at once, so this step is mostly for detail.
            CurrentStepDescription = "1. Consider adding extra protein with powder or chia seeds.\n"
                                   + "2. Add ginger and mint for a unique flavour experience";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("green_smoothie_step3.jpg"); // Placeholder - replace with actual image path
        }

        protected override void FinishAndDecorate()
        {
            CurrentStepDescription = "1. Blend until completely smooth, stopping to scrape down the sides of the blender if necessary.\n"
                                   + "2. Adjust liquid to obtain desired consistency.";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("green_smoothie_step4.jpg"); // Placeholder - replace with actual image path
        }

        protected override void Serve()
        {
            CurrentStepDescription = "- Pour into a glass and enjoy immediately!\n"
                                   + "- Best served cold.";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("green_smoothie_step5.jpg"); // Placeholder - replace with actual image path
        }

        //Override to indicate that the smoothie doesn't involve boiling
    }
}