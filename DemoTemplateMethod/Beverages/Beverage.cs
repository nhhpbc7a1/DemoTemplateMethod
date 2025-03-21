using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DemoTemplateMethod.Beverages
{
    // Base class Beverage
    public abstract class Beverage
    {
        public int currentStep = 0;
        public string CurrentStepDescription = "";
        public string CurrentStepImagePath = "";
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public string MenuImagePath { get; protected set; }

        public List<string> StepDescriptions { get; private set; } = new List<string>();
        public List<string> StepImagePaths { get; private set; } = new List<string>();


        // Template method
        public void Prepare()
        {

            PrepareIngredients();
            AddStepDescriptionAndImage();

            BrewMainIngredient();
            AddStepDescriptionAndImage();

            AddCustomIngredients();
            AddStepDescriptionAndImage();

            FinishAndDecorate();
            AddStepDescriptionAndImage();

            Serve();
            AddStepDescriptionAndImage();

        }

        private void AddStepDescriptionAndImage()
        {
            StepDescriptions.Add(CurrentStepDescription);
            StepImagePaths.Add(CurrentStepImagePath);
        }

        protected abstract void PrepareIngredients();

        protected abstract void BrewMainIngredient();
        protected abstract void AddCustomIngredients();

        protected abstract void FinishAndDecorate();

        protected abstract void Serve();





    }
}