using System;

namespace DemoTemplateMethod.Beverages
{
    public class Tea : Beverage
    {
        private int currentStep = 0;

        public Tea()
        {
            Name = "Bubble Tea";
            Description = "Delicious black tea with milk and tapioca pearls";
            MenuImagePath = ImagePathHelper.GetImagePath("tea_menu.jpg");
        }

        protected override void PrepareIngredients()
        {
            CurrentStepDescription = "Prepare: Black tea, milk, tapioca pearls, glass and tools";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("tea_step1.jpg");
            // Thực hiện logic chuẩn bị nguyên liệu
        }

        protected override void BrewMainIngredient()
        {
            CurrentStepDescription = "Brew tea: Steep tea in hot water for about 3-5 minutes";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("tea_step2.jpg");
            // Thực hiện logic pha trà
        }

        protected override void AddCustomIngredients()
        {
            CurrentStepDescription = "Add ingredients: Add cooked tapioca pearls to the glass, then add milk";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("tea_step3.jpg");
            // Thực hiện logic thêm nguyên liệu
        }

        protected override void FinishAndDecorate()
        {
            CurrentStepDescription = "Finish: Shake well or stir the mixture";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("tea_step4.jpg");
            // Thực hiện logic hoàn thiện
        }

        protected override void Serve()
        {
            CurrentStepDescription = "Serve: Add ice and enjoy with a large straw";
            CurrentStepImagePath = ImagePathHelper.GetImagePath("tea_step5.jpg");
            // Thực hiện logic phục vụ
        }

        // Các phương thức này có thể giữ lại để tham khảo hoặc xóa đi nếu không cần
        //public override string[] GetStepDescriptions()
        //{
        //    return new string[]
        //    {
        //        "Prepare: Black tea, milk, tapioca pearls, glass and tools",
        //        "Brew tea: Steep tea in hot water for about 3-5 minutes",
        //        "Add ingredients: Add cooked tapioca pearls to the glass, then add milk",
        //        "Finish: Shake well or stir the mixture",
        //        "Serve: Add ice and enjoy with a large straw"
        //    };
        //}

        //public override string[] GetStepImagePaths()
        //{
        //    return new string[]
        //    {
        //        ImagePathHelper.GetImagePath("tea_step1.jpg"),
        //        ImagePathHelper.GetImagePath("tea_step2.jpg"),
        //        ImagePathHelper.GetImagePath("tea_step3.jpg"),
        //        ImagePathHelper.GetImagePath("tea_step4.jpg"),
        //        ImagePathHelper.GetImagePath("tea_step5.jpg"),
        //    };
        //}
    }
}