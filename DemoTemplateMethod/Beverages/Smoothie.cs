using System;

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
            CurrentStepDescription = "Prepare: Fresh strawberries, yogurt, honey, ice, and blender";
            CurrentStepImage = ImagePathHelper.GetImagePath("tea_step1.jpg");
            // Thực hiện logic chuẩn bị nguyên liệu
        }

        protected override void BrewMainIngredient()
        {
            CurrentStepDescription = "Blend ingredients: Add strawberries and ice to the blender and blend";
            CurrentStepImage = ImagePathHelper.GetImagePath("tea_step2.jpg");
            // Thực hiện logic pha trà
        }

        protected override void AddCustomIngredients()
        {
            CurrentStepDescription = "Add ingredients: Add yogurt and honey, blend lightly";
            CurrentStepImage = ImagePathHelper.GetImagePath("tea_step3.jpg");
            // Thực hiện logic thêm nguyên liệu
        }

        protected override void FinishAndDecorate()
        {
            CurrentStepDescription = "Finish: Pour the mixture into a glass, decorate with a strawberry slice";
            CurrentStepImage = ImagePathHelper.GetImagePath("tea_step4.jpg");
            // Thực hiện logic hoàn thiện
        }

        protected override void Serve()
        {
            CurrentStepDescription = "Serve: Add a straw and enjoy immediately";
            CurrentStepImage = ImagePathHelper.GetImagePath("tea_step5.jpg");
            // Thực hiện logic phục vụ
        }

    }
}