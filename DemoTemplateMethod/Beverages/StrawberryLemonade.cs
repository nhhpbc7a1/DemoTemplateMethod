using System;

namespace DemoTemplateMethod.Beverages
{
    // Class StrawberryLemonade
    public class StrawberryLemonade : Beverage
    {
        public StrawberryLemonade()
        {
            Name = "Strawberry Lemonade";
            Description = "Fresh and delicious homemade strawberry lemonade";
            MenuImagePath = ImagePathHelper.GetImagePath("strawberry_lemonade_menu.jpg"); // Placeholder - replace with actual image path
        }

        protected override void PrepareIngredients()
        {
            CurrentStepDescription = "- Fresh Strawberries (1/2 lb)\n"
                                   + "- Lemons (6-8 medium)\n"
                                   + "- Sugar\n"
                                   + "- Water\n"
                                   + "- Blender/Food Processor\n"
                                   + "- Fine Mesh Sieve";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("strawberry_lemonade_step1.jpg"); // Placeholder - replace with actual image path
        }

        protected override void BrewMainIngredient()
        {
            CurrentStepDescription = "1. Hull strawberries (remove green stems).\n"
                                   + "2. Puree strawberries in a blender or food processor.\n"
                                   + "3. Strain strawberry puree through a fine mesh sieve (optional, to remove seeds).";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("strawberry_lemonade_step2.jpg"); // Placeholder - replace with actual image path
        }

        protected override void AddCustomIngredients()
        {
            CurrentStepDescription = "1. Juice 6-8 lemons to obtain 1 1/2 cups of lemon juice.\n"
                                   + "2. Strain lemon juice through a fine mesh sieve into a pitcher.\n"
                                   + "3. In a saucepan, combine sugar and 2 cups of water. Simmer and stir until sugar is dissolved.  Cool to room temperature (simple syrup).";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("strawberry_lemonade_step3.jpg"); // Placeholder - replace with actual image path
        }

        protected override void FinishAndDecorate()
        {
            CurrentStepDescription = "1.  In the pitcher, combine cooled simple syrup, strained lemon juice, and pureed strawberries.\n"
                                   + "2.  Stir well to combine all ingredients.";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("strawberry_lemonade_step4.jpg"); // Placeholder - replace with actual image path
        }

        protected override void Serve()
        {
            CurrentStepDescription = "- Chill completely before serving. Garnish with lemon slices and fresh strawberries if desired.\n"
                                   + "- Enjoy your refreshing Strawberry Lemonade!";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("strawberry_lemonade_step5.jpg"); // Placeholder - replace with actual image path
        }

    }
}