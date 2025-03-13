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
            CurrentStepDescription = "Prepare: Coffee filter, glass, ground coffee, and condensed milk";
            CurrentStepImage = ImagePathHelper.GetImagePath("coffee_step1.jpg");
            // Thực hiện logic chuẩn bị nguyên liệu
        }

        protected override void BrewMainIngredient()
        {
            CurrentStepDescription = "Brew coffee: Add coffee to the filter, pour hot water and wait for it to drip";
            CurrentStepImage = ImagePathHelper.GetImagePath("coffee_step2.jpg");
            // Thực hiện logic pha trà
        }

        protected override void AddCustomIngredients()
        {
            CurrentStepDescription = "Add ingredients: Add 2 spoons of condensed milk to the bottom of the glass";
            CurrentStepImage = ImagePathHelper.GetImagePath("coffee_step3.jpg");
            // Thực hiện logic thêm nguyên liệu
        }

        protected override void FinishAndDecorate()
        {
            CurrentStepDescription = "Finish: Stir the condensed milk and coffee mixture well";
            CurrentStepImage = ImagePathHelper.GetImagePath("coffee_step4.jpg");
            // Thực hiện logic hoàn thiện
        }

        protected override void Serve()
        {
            CurrentStepDescription = "Serve: Add ice (optional) and enjoy";
            CurrentStepImage = ImagePathHelper.GetImagePath("coffee_step5.jpg");
            // Thực hiện logic phục vụ
        }

    }
}