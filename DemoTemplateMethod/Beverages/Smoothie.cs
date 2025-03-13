namespace DemoTemplateMethod.Beverages
{
    // Class Smoothie
    public class Smoothie : Beverage
    {
        public Smoothie()
        {
            Name = "Strawberry Smoothie";
            Description = "Fresh strawberry smoothie with yogurt and honey";
            MenuImagePath = "images/smoothie_menu.png";
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
                "images/smoothie_step1.png",
                "images/smoothie_step2.png",
                "images/smoothie_step3.png",
                "images/smoothie_step4.png",
                "images/smoothie_step5.png"
            };
        }
    }
}