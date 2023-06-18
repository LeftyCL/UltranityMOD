using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Ultranity.Items;

namespace Ultranity.NPCs
{
	public class Fenix : ModNPC
	{

        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[NPC.type] = Main.npcFrameCount[NPCID.Raven];
        }

        public override void SetDefaults()
        {
            NPC.width = 50;
            NPC.height = 50;
            NPC.damage = 50;
            NPC.defense = 7;
            NPC.lifeMax = 200;
            NPC.HitSound = SoundID.NPCHit3;
            NPC.DeathSound = SoundID.NPCDeath3;
            NPC.value = 100f;
            NPC.aiStyle = 17;
            AIType = NPCID.Raven;
            AnimationType = NPCID.Raven;
            NPC.noGravity = true;
        }

        public override void OnKill()
        {
            Item.NewItem(NPC.GetSource_Death(), NPC.getRect(), ModContent.ItemType<EssenciaFenix>(), Main.rand.Next(1, 1));
            Item.NewItem(NPC.GetSource_Death(), NPC.getRect(), ModContent.ItemType<Azufre>(), Main.rand.Next(1, 6));
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (spawnInfo.Player.ZoneUnderworldHeight) // Verificar si el jugador está en la altura del infierno
            {
                return 0.6f; // 6% de probabilidad de aparición en el infierno
            }
            else
            {
                return 0f; // No se generará en ninguna otra ubicación
            }
        }
        public override void AI()
        {
            NPC.TargetClosest(true);
            if (Main.rand.NextBool(5 ))
            {
                Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Torch); // Generar una partícula de fuego en la posición del enemigo
            }
            base.AI();
        }

        public override void OnHitPlayer(Player target, Player.HurtInfo hurtInfo)
        {
            {
                target.AddBuff(BuffID.OnFire, 250);
            }
        }
    }
}