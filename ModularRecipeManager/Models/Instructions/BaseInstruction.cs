using System.Collections.Generic;

namespace ModularRecipeManager.Models.Instructions
{
    public class BaseInstruction : IInstruction
    {
        public List<IIngredient> InputIngredients { get; }

        public List<IIngredient> OutputIngredients { get; }

        public BaseInstruction(List<IIngredient> inputIngredients, List<IIngredient> outputIngredients)
        {
            InputIngredients = inputIngredients;
            OutputIngredients = outputIngredients;
        }
    }
}