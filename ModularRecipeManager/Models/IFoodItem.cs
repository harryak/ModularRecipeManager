using System.Collections.Generic;

namespace ModularRecipeManager.Models
{
    public interface IFoodItem
    {
        int Id { get; }
        string TitleIdentifier { get; }

        List<IFoodCategory> FoodCategories { get; }
    }
}