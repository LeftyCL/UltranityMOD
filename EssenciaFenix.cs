using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Ultranity.Items
{
	public class EssenciaFenix : ModItem
	{
		public override void SetDefaults()
		{
            Item.width = 25;
            Item.height = 25;
            Item.maxStack = 999;
            Item.value = Item.sellPrice(silver: 130); // Precio de venta en plata
            Item.rare = ItemRarityID.Orange;
        }
	}
}