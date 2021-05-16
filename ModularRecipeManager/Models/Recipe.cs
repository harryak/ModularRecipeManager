using ModularRecipeManager.Models.Instructions;
using System;
using System.Collections.Generic;

namespace ModularRecipeManager.Models
{
    public class Recipe : IRecipe
    {
        public Recipe(int id, string titleIdentifier, DateTime createdAt, SortedList<int, IInstruction> instructions, List<IIngredient> inputIngredients, List<IIngredient> outputIngredients)
        {
            Id = id;
            TitleIdentifier = titleIdentifier;
            CreatedAt = createdAt;
            Instructions = instructions;
            InputIngredients = inputIngredients;
            OutputIngredients = outputIngredients;
        }

        public int Id { get; }

        public string TitleIdentifier { get; }
        public DateTime CreatedAt { get; }
        public SortedList<int, IInstruction> Instructions { get; }

        public List<IIngredient> InputIngredients { get; }

        public List<IIngredient> OutputIngredients { get; }
    }
}
