namespace ModularRecipeManager.Models
{
    public class Ingredient : IIngredient
    {
        public Measurement Amount { get; set; }
        public IFoodItem Item { get; set; }
    }
}