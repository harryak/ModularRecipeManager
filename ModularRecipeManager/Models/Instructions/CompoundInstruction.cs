using System.Collections.Generic;
using System.Linq;

namespace ModularRecipeManager.Models.Instructions
{
    public class CompoundInstruction : BaseInstruction, IInstruction
    {
        public CompoundInstruction(List<IIngredient> inputIngredients, List<IIngredient> outputIngredients) : base(inputIngredients, outputIngredients)
        {
        }

        public SortedList<int, IInstruction> SubInstructions { get; set; }

        public override string ToString()
        {
            return string.Join(", ", SubInstructions.SelectMany(instructionEntry => instructionEntry.Key + ". " + instructionEntry.Value));
        }
    }
}