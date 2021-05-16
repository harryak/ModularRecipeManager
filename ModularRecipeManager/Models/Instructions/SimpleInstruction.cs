using System.Collections.Generic;
using System.Linq;

namespace ModularRecipeManager.Models.Instructions
{
    public class SimpleInstruction : BaseInstruction, IInstruction
    {
        public SimpleInstruction(List<IIngredient> inputIngredients, List<IIngredient> outputIngredients) : base(inputIngredients, outputIngredients)
        {
        }

        public IInstructionAction Action { get; set; }

        public IInstructionQualifier Qualifier { get; set; }

        public string GetIngredientString()
        {
            return string.Join(", ", InputIngredients.SelectMany(ingredientEntry => ingredientEntry.ToString()));
        }

        public override string ToString()
        {
            return Action.ToString() + " " + GetIngredientString() + Qualifier.ToString();
        }
    }
}