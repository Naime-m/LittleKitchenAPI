﻿using LittleKitchenAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LittleKitchenAPI.Data;

public class RecipeDbContext : DbContext
{
	public RecipeDbContext(DbContextOptions<RecipeDbContext> options) : base(options)
	{
	}

	DbSet<Recipe> Recipes { get; set; }

}
