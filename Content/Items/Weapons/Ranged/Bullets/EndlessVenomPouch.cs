﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SteviesMod.Content.Items.Weapons.Ranged.Bullets
{
    public class EndlessVenomPouch : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Venom Pouch");
            Tooltip.SetDefault("Inflicts target with Venom");
            base.SetStaticDefaults();
        }
        public override void SetDefaults()
        {
            item.shootSpeed = 5.3f;
            item.shoot = ProjectileID.VenomBullet;
            item.damage = 14;
            item.width = 26;
            item.height = 26;
            item.ammo = AmmoID.Bullet;
            item.knockBack = 4.1f;
            item.value = Item.sellPrice(0, 2);
            item.ranged = true;
            item.rare = ItemRarityID.White;
            base.SetDefaults();
        }
        public override void AddRecipes()
        {
            base.AddRecipes();
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.VenomBullet, 3996);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
