﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SteviesMod.Content.Items.Consumables
{
    public class BeenadeCrate : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Beenade Crate");
            Tooltip.SetDefault("Explodes into a swarm of bees");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.Beenade);
            item.consumable = false;
            item.width = 18;
            item.height = 28;
            item.value = Item.sellPrice(0, 2);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Beenade, 60);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}