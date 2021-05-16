using System.Collections.Generic;

namespace ModularRecipeManager.Models.Instructions
{
    public interface IInstruction
    {
        List<IIngredient> InputIngredients { get; }
        List<IIngredient> OutputIngredients { get; }

        string ToString();
    }
}