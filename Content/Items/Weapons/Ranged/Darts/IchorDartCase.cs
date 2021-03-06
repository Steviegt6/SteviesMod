﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SteviesMod.Content.Items.Weapons.Ranged.Darts
{
    public class IchorDartCase : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Poison Dart Case");
            Tooltip.SetDefault("Bursts into multiple darts");
        }

        public override void SetDefaults()
        {
            item.shoot = ProjectileID.IchorDart;
            item.damage = 12;
            item.width = 24;
            item.height = 28;
            item.ammo = AmmoID.Dart;
            item.knockBack = 2.5f;
            item.shootSpeed = 3f;
            item.value = Item.sellPrice(0, 2);
            item.ranged = true;
            item.rare = ItemRarityID.Orange;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IchorDart, 3996);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}