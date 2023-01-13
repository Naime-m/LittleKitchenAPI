using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LittleKitchenAPI.Models;

public class Recipe
{
    public int Id { get; set; }

    [Required]
    [StringLength(300, MinimumLength = 5)]
    public string Title { get; set; }

    [Required]
    [StringLength(500, MinimumLength = 10)]
    public string Description { get; set; }

    [Required]
    public string Ingredients { get; set; }

    [Required]
    public string Steps { get; set; }

    [DataType(DataType.Date)]
    public DateTime Date { get; set; }

    public CourseType? CourseType  { get; set;}

    public Category? Category { get; set; }
}

public enum CourseType
{
    Appetizer,
    [Display(Name = "Main Course")]
    MainCourse,
    Dessert,
    Beverage
}

public enum Category
{
    Vegan,
    Meat, 
    Fish,
    [Display(Name = "Gluten Free")]
    GlutenFree
}
