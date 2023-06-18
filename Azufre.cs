using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Ultranity.Items
{
	public class Azufre : ModItem
	{
		public override void SetDefaults()
		{
            Item.width = 25;
            Item.height = 25;
            Item.maxStack = 999;
            Item.value = Item.sellPrice(silver: 53); // Precio de venta en plata
            Item.rare = ItemRarityID.Orange;
        }
	}
}