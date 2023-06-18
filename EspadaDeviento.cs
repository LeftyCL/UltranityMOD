using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;

namespace Ultranity.Items.Viento
{
    public class EspadaDeviento : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Ultranity.hjson file.

        public override void SetDefaults()
        {
            Item.damage = 21;
            Item.DamageType = DamageClass.Magic;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 30;
            Item.useAnimation = 30;
            Item.useStyle = 1;
            Item.knockBack = 6;
            Item.value = 10000;
            Item.UseSound = SoundID.Item20;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.White;
            Item.shoot = 969;
            Item.shootSpeed = 10f;
            Item.mana = 10;
        }
    }
}