using System;

namespace DemoTemplateMethod.Beverages
{
    // Class SweetTea
    public class SweetTea : Beverage
    {
        public SweetTea()
        {
            Name = "Sweet Tea";
            Description = "Classic Southern-style sweet tea, refreshing and easy to make";
            MenuImagePath = ImagePathHelper.GetImagePath("sweet_tea_menu.jpg"); // Placeholder - replace with actual image path
        }

        protected override void PrepareIngredients()
        {
            CurrentStepDescription = "- Baking Soda (1 pinch)\n"
                                   + "- Boiling Water (2 cups)\n"
                                   + "- Tea Bags (6)\n"
                                   + "- White Sugar (¾ cup)\n"
                                   + "- Cool Water (6 cups)\n"
                                   + "- Heat-Proof Glass Pitcher (64-ounce)\n"
                                   + "- Lid or Cover for Pitcher";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("sweet_tea_step1.jpg"); // Placeholder - replace with actual image path
        }

        protected override void BrewMainIngredient()
        {
            CurrentStepDescription = "1. Sprinkle a pinch of baking soda into the heat-proof glass pitcher.\n"
                                   + "2. Pour in the boiling water and add the tea bags.\n"
                                   + "This creates the base for the sweet tea.";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("sweet_tea_step2.jpg"); // Placeholder - replace with actual image path
        }

        protected override void AddCustomIngredients()
        {
            CurrentStepDescription = "1. Cover the pitcher and allow the tea to steep for 15 minutes.\n"
                                   + "This extracts the flavor from the tea bags.";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("sweet_tea_step3.jpg"); // Placeholder - replace with actual image path
        }

        protected override void FinishAndDecorate()
        {
            CurrentStepDescription = "1. Remove the tea bags from the pitcher and discard them.\n"
                                   + "2. Stir in the sugar until it is completely dissolved.\n"
                                   + "This sweetens the tea to the desired level.";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("sweet_tea_step4.jpg"); // Placeholder - replace with actual image path
        }

        protected override void Serve()
        {
            CurrentStepDescription = "- Pour in the cool water into the pitcher.\n"
                                   + "- Refrigerate the sweet tea until it is cold, about 3 hours.\n"
                                   + "- Serve over ice and enjoy! Garnish with a lemon slice, if desired.";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("sweet_tea_step5.jpg"); // Placeholder - replace with actual image path
        }
    }
}