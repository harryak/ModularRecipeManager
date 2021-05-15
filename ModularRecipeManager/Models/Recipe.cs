using System;
using System.ComponentModel.DataAnnotations;

namespace ModularRecipeManager.Models
{
    public class Recipe
    {
        public int Id { get; private set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }
    }
}