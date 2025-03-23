using System;

namespace DemoTemplateMethod.Beverages
{
    // Class FrozenHotChocolate
    public class FrozenHotChocolate : Beverage
    {
        public FrozenHotChocolate()
        {
            Name = "Frozen Hot Chocolate";
            Description = "A rich and refreshing frozen treat made with real melted chocolate";
            MenuImagePath = ImagePathHelper.GetImagePath("frozen_hot_chocolate_menu.jpg"); // Placeholder - replace with actual image path
        }

        protected override void PrepareIngredients()
        {
            CurrentStepDescription = "- Semi-Sweet Chocolate (or your favorite chocolate)\n"
                                   + "- Sugar\n"
                                   + "- Cocoa Powder\n"
                                   + "- Salt\n"
                                   + "- Milk\n"
                                   + "- Ice Cubes\n"
                                   + "- Blender\n"
                                   + "- Microwave-Safe Bowl";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("frozen_hot_chocolate_step1.jpg"); // Placeholder - replace with actual image path
        }

        protected override void BrewMainIngredient()
        {
            CurrentStepDescription = "1. Chop the chocolate into small pieces.\n"
                                   + "2. Melt the chocolate in the microwave on half power, stirring every 20 seconds, until melted and smooth.";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("frozen_hot_chocolate_step2.jpg"); // Placeholder - replace with actual image path
        }

        protected override void AddCustomIngredients()
        {
            CurrentStepDescription = "1. Stir in sugar, cocoa powder, and salt into the melted chocolate.\n"
                                   + "2. Slowly stir in 1/2 cup of milk, ensuring a smooth mixture.";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("frozen_hot_chocolate_step3.jpg"); // Placeholder - replace with actual image path
        }

        protected override void FinishAndDecorate()
        {
            CurrentStepDescription = "1. Add the chocolate mixture to the blender.\n"
                                   + "2. Add the remaining 1 cup of milk and 1 cup of ice cubes.";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("frozen_hot_chocolate_step4.jpg"); // Placeholder - replace with actual image path
        }

        protected override void Serve()
        {
            CurrentStepDescription = "- Blend well until smooth.\n"
                                   + "- Add more ice if you prefer a thicker consistency.\n"
                                   + "- Serve immediately, topped with fresh whipped cream.";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("frozen_hot_chocolate_step5.jpg"); // Placeholder - replace with actual image path
        }

    }
}