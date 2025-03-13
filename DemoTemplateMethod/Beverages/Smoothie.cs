namespace DemoTemplateMethod.Beverages
{
    // Class Smoothie
    public class Smoothie : Beverage
    {
        public Smoothie()
        {
            Name = "Strawberry Smoothie";
            Description = "Fresh strawberry smoothie with yogurt and honey";
            MenuImagePath = ImagePathHelper.GetImagePath("smoothie_menu.jpg");
        }

        protected override void PrepareIngredients()
        {
            // Prepare strawberries, yogurt, ice...
        }

        protected override void BrewMainIngredient()
        {
            // Blend strawberries with ice
        }

        protected override void AddCustomIngredients()
        {
            // Add yogurt and honey
        }

        public override string[] GetStepDescriptions()
        {
            return new string[]
            {
                "Prepare: Fresh strawberries, yogurt, honey, ice, and blender",
                "Blend ingredients: Add strawberries and ice to the blender and blend",
                "Add ingredients: Add yogurt and honey, blend lightly",
                "Finish: Pour the mixture into a glass, decorate with a strawberry slice",
                "Serve: Add a straw and enjoy immediately"
            };
        }

        public override string[] GetStepImagePaths()
        {
            return new string[]
            {
                ImagePathHelper.GetImagePath("smoothie_step1.jpg"),
                ImagePathHelper.GetImagePath("smoothie_step2.jpg"),
                ImagePathHelper.GetImagePath("smoothie_step3.jpg"),
                ImagePathHelper.GetImagePath("smoothie_step4.jpg"),
                ImagePathHelper.GetImagePath("smoothie_step5.jpg"),
            };
        }
    }
}