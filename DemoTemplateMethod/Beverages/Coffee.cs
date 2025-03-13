namespace DemoTemplateMethod.Beverages
{
    // Class Coffee
    public class Coffee : Beverage
    {
        public Coffee()
        {
            Name = "Coffee with Milk";
            Description = "Traditional coffee with condensed milk";
            MenuImagePath = "images/coffee_menu.png";
        }

        protected override void PrepareIngredients()
        {
            // Specific implementation for coffee
        }

        protected override void BrewMainIngredient()
        {
            // Brew coffee using a phin filter
        }

        protected override void AddCustomIngredients()
        {
            // Add condensed milk
        }

        protected override void FinishAndDecorate()
        {
            // Stir well and decorate
        }

        public override string[] GetStepDescriptions()
        {
            return new string[]
            {
                "Prepare: Coffee filter, glass, ground coffee, and condensed milk",
                "Brew coffee: Add coffee to the filter, pour hot water and wait for it to drip",
                "Add ingredients: Add 2 spoons of condensed milk to the bottom of the glass",
                "Finish: Stir the condensed milk and coffee mixture well",
                "Serve: Add ice (optional) and enjoy"
            };
        }

        public override string[] GetStepImagePaths()
        {
            return new string[]
            {
                "images/coffee_step1.png",
                "images/coffee_step2.png",
                "images/coffee_step3.png",
                "images/coffee_step4.png",
                "images/coffee_step5.png"
            };
        }
    }
}