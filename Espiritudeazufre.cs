using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Ultranity.Items;

namespace Ultranity.NPCs
{
	public class Espiritudeazufre : ModNPC
	{

        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[NPC.type] = Main.npcFrameCount[NPCID.Wraith];
        }

        public override void SetDefaults()
        {
            NPC.width = 32;
            NPC.height = 32;
            NPC.damage = 12;
            NPC.defense = 7;
            NPC.lifeMax = 100;
            NPC.HitSound = SoundID.NPCHit3;
            NPC.DeathSound = SoundID.NPCDeath3;
            NPC.value = 100f;
            NPC.aiStyle = 22;
            AIType = NPCID.Wraith;
            AnimationType = NPCID.Wraith;
            NPC.noGravity = true;
        }

        public override void OnKill()
        {
            Item.NewItem(NPC.GetSource_Death(), NPC.getRect(), ModContent.ItemType<Azufre>(), Main.rand.Next(1, 4));
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (spawnInfo.Player.ZoneUnderworldHeight) // Verificar si el jugador está en la altura del infierno
            {
                return 0.8f; // 8% de probabilidad de aparición en el infierno
            }
            else
            {
                return 0f; // No se generará en ninguna otra ubicación
            }
        }
        public override void AI()
        {
            NPC.TargetClosest(true);
            if (Main.rand.NextBool(5))
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