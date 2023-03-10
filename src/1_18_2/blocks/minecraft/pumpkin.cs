using System.Collections.Generic;
namespace MinecraftData._1_18_2.blocks.minecraft
{
    [Block(BlockNameID.pumpkin)]
    public class pumpkin : IBlockData
    {
        public short DefaultStateID => 4067;
        public state DefaultState => States[0];
        public float Hardness => 1f;
        public float ExplosionResistance => 1f;
        public bool IsTransparent => false;
        public byte SoundGroup => 0;
        public short DroppedItem => 265;
        public MinecraftMaterial Material => MinecraftMaterial.gourd;
        public Dictionary<string, List<string>> Properties => new Dictionary<string, List<string>>()
        {
            
        };
        public state[] States => new state[]
        {
            new state
            {
                Id = 4067,
                Properties = new byte[] {  },
                CollisionShape = 0,
                Luminance = 0,
                LightCost = 15,
                HasSideTransparency = false,
            }
        };
    }
}
