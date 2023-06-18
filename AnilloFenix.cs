using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Ultranity.Items;

namespace Ultranity.Items
{
    public class AnilloFenix : ModItem
    {

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 24;
            Item.value = Item.sellPrice(silver: 105);
            Item.rare = ItemRarityID.Orange;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.moveSpeed += 0.05f; // Aumenta la velocidad de movimiento del jugador en un 5%
            player.GetAttackSpeed(DamageClass.Melee) += 0.05f; // Aumenta la velocidad de ataque cuerpo a cuerpo del jugador en un 10%
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<Azufre>(), 3);
            recipe.AddIngredient(ModContent.ItemType<EssenciaFenix>(), 5);
            recipe.AddTile(TileID.Hellforge);
            recipe.Register();
        }
    }
}