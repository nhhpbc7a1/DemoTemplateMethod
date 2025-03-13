namespace DemoTemplateMethod.Beverages
{
    // Class Tea
    public class Tea : Beverage
    {
        public Tea()
        {
            Name = "Bubble Tea";
            Description = "Delicious black tea with milk and tapioca pearls";
            MenuImagePath = "images/tea_menu.png";
        }

        protected override void PrepareIngredients()
        {
            // Specific implementation for tea
        }

        protected override void BrewMainIngredient()
        {
            // Brew black tea
        }

        protected override void AddCustomIngredients()
        {
            // Add milk and tapioca pearls
        }

        public override string[] GetStepDescriptions()
        {
            return new string[]
            {
                "Prepare: Black tea, milk, tapioca pearls, glass and tools",
                "Brew tea: Steep tea in hot water for about 3-5 minutes",
                "Add ingredients: Add cooked tapioca pearls to the glass, then add milk",
                "Finish: Shake well or stir the mixture",
                "Serve: Add ice and enjoy with a large straw"
            };
        }

        public override string[] GetStepImagePaths()
        {
            return new string[]
            {
                "images/tea_step1.png",
                "images/tea_step2.png",
                "images/tea_step3.png",
                "images/tea_step4.png",
                "images/tea_step5.png"
            };
        }
    }
}