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
                ImagePathHelper.GetImagePath("coffee_step1.jpg"),
                ImagePathHelper.GetImagePath("coffee_step2.jpg"),
                ImagePathHelper.GetImagePath("coffee_step3.jpg"),
                ImagePathHelper.GetImagePath("coffee_step4.jpg"),
                ImagePathHelper.GetImagePath("coffee_step5.jpg"),
            };
        }
    }
}