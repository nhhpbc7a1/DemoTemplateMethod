using System;

namespace DemoTemplateMethod.Beverages
{
    // Class MatchaLatte
    public class MatchaLatte : Beverage
    {
        public MatchaLatte()
        {
            Name = "Matcha Latte";
            Description = "A delicious and easy-to-make matcha latte with frothy milk";
            MenuImagePath = ImagePathHelper.GetImagePath("matcha_latte_menu.jpg"); // Placeholder - replace with actual image path
        }

        protected override void PrepareIngredients()
        {
            CurrentStepDescription = "- Matcha Powder (1 1/2 teaspoons)\n"
                                   + "- Hot Water (1 tablespoon)\n"
                                   + "- Honey (2 teaspoons, or to taste)\n"
                                   + "- Hot Milk (3/4 cup, dairy or plant-based)\n"
                                   + "- Sifter\n"
                                   + "- Whisk (bamboo or metal)\n"
                                   + "- Mug\n"
                                   + "- Milk Frother (optional)";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("matcha_latte_step1.jpg"); // Placeholder - replace with actual image path
        }

        protected override void BrewMainIngredient()
        {
            CurrentStepDescription = "1. Sift the matcha powder into a mug to remove any lumps.\n"
                                   + "This ensures a smoother latte.";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("matcha_latte_step2.jpg"); // Placeholder - replace with actual image path
        }

        protected override void AddCustomIngredients()
        {
            CurrentStepDescription = "1. Add the hot water to the sifted matcha powder.\n"
                                   + "2. Whisk until no lumps remain, creating a smooth, dark green paste.";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("matcha_latte_step3.jpg"); // Placeholder - replace with actual image path
        }

        protected override void FinishAndDecorate()
        {
            CurrentStepDescription = "1. Stir in the honey (or your preferred sweetener) into the matcha mixture.\n"
                                   + "Adjust the amount of honey to your desired sweetness level.";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("matcha_latte_step4.jpg"); // Placeholder - replace with actual image path
        }

        protected override void Serve()
        {
            CurrentStepDescription = "- Add the hot milk to the matcha mixture.\n"
                                   + "- Whisk to combine, or use a milk frother to create a frothy top.\n"
                                   + "- Serve immediately and enjoy your delicious matcha latte!";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("matcha_latte_step5.jpg"); // Placeholder - replace with actual image path
        }

    }
}