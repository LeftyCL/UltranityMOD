using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;

namespace Ultranity.Items
{
    public class Espadadeazufre : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Ultranity.hjson file.

        public override void SetDefaults()
        {
            Item.damage = 28;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 30;
            Item.useAnimation = 30;
            Item.useStyle = 1;
            Item.knockBack = 6;
            Item.value = 10000;
            Item.rare = 2;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.Orange;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.HellstoneBar, 12);
            recipe.AddIngredient(ModContent.ItemType<Azufre>(), 6);
            recipe.AddIngredient(ModContent.ItemType<EssenciaFenix>(), 2);
            recipe.AddTile(TileID.Hellforge);
            recipe.Register();
        }

        public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
        {
            // Causar fuego al golpear
            target.AddBuff(BuffID.OnFire, 250);
        }

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                if (player.statMana >= 60) // Verificar si el jugador tiene suficiente maná
                {
                    player.statMana -= 60; // Reducir el maná del jugador en 20 unidades
                    Item.shoot = ProjectileID.DD2PhoenixBowShot;
                    Item.shootSpeed = 10f;
                    Item.autoReuse = true;
                }
                else
                {
                    return false; // El jugador no tiene suficiente maná para usar la habilidad especial
                }
            }
            else
            {
                Item.shoot = 0;
            }
            return base.CanUseItem(player);
        }
    }
}