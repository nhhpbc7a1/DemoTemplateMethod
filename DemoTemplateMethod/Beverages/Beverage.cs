namespace DemoTemplateMethod.Beverages
{
    // Base class Beverage
    public abstract class Beverage
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public string MenuImagePath { get; protected set; }

        // Template method
        public void Prepare()
        {
            PrepareIngredients();
            BrewMainIngredient();
            AddCustomIngredients();
            FinishAndDecorate();
            Serve();
        }

        protected virtual void PrepareIngredients()
        {
            // Common step for all beverages
        }

        protected abstract void BrewMainIngredient();
        protected abstract void AddCustomIngredients();

        protected virtual void FinishAndDecorate()
        {
            // Common step for all beverages
        }

        protected virtual void Serve()
        {
            // Common step for all beverages
        }

        // Method to get information about the steps
        public abstract string[] GetStepDescriptions();
        public abstract string[] GetStepImagePaths();
    }
}

