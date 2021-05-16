using ModularRecipeManager.Models.Instructions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ModularRecipeManager.Models
{
    public interface IRecipe : IInstruction
    {
        int Id { get; }
        string TitleIdentifier { get; }

        [DataType(DataType.Date)]
        DateTime CreatedAt { get; }

        SortedList<int, IInstruction> Instructions { get; }
    }
}
