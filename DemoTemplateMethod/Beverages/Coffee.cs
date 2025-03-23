using System;

namespace DemoTemplateMethod.Beverages
{
    // Class Coffee
    public class Coffee : Beverage
    {
        public Coffee()
        {
            Name = "Coffee with Milk";
            Description = "Traditional coffee with condensed milk";
            MenuImagePath = ImagePathHelper.GetImagePath("coffee_menu.jpg");
        }

        protected override void PrepareIngredients()
        {
            CurrentStepDescription = "- Coffee filter, glass\n"
                                   + "- Ground coffee\n"
                                   + "- Condensed milk\n"
                                   + "- Hot water";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("coffee_step1.jpg");
        }

        protected override void BrewMainIngredient()
        {
            CurrentStepDescription = "1. Add ground coffee to the filter (about 20g).\n"
                                   + "2. Gently shake to level the surface.\n"
                                   + "3. Pour a little hot water to let the coffee bloom (30 seconds).\n"
                                   + "4. Slowly add 60ml more hot water and cover.\n"
                                   + "5. Wait for the coffee to drip completely into the glass.";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("coffee_step2.jpg");
        }

        protected override void AddCustomIngredients()
        {
            CurrentStepDescription = "1. Pour 2 spoons of condensed milk into the glass.\n"
                                   + "2. Adjust sweetness according to taste.";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("coffee_step3.jpg");
        }

        protected override void FinishAndDecorate()
        {
            CurrentStepDescription = "1. Stir the condensed milk and coffee mixture well.\n"
                                   + "2. If desired, sprinkle a little cocoa powder on top for decoration.\n"
                                   + "3. Serve hot, or add ice cubes for iced coffee.\n";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("coffee_step4.jpg");
        }

        protected override void Serve()
        {
            CurrentStepDescription =  "- Stir well before drinking and enjoy!";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("coffee_step5.jpg");
        }

    }
}