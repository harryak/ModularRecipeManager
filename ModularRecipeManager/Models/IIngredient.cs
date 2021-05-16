namespace ModularRecipeManager.Models
{
    public interface IIngredient
    {
        Measurement Amount { get; set; }
        IFoodItem Item { get; set; }
    }
}