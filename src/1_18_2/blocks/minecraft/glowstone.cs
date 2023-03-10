using System.Collections.Generic;
namespace MinecraftData._1_18_2.blocks.minecraft
{
    [Block(BlockNameID.glowstone)]
    public class glowstone : IBlockData
    {
        public short DefaultStateID => 4082;
        public state DefaultState => States[0];
        public float Hardness => 0.3f;
        public float ExplosionResistance => 0.3f;
        public bool IsTransparent => false;
        public byte SoundGroup => 6;
        public short DroppedItem => 275;
        public MinecraftMaterial Material => MinecraftMaterial.glass;
        public Dictionary<string, List<string>> Properties => new Dictionary<string, List<string>>()
        {
            
        };
        public state[] States => new state[]
        {
            new state
            {
                Id = 4082,
                Properties = new byte[] {  },
                CollisionShape = 0,
                Luminance = 15,
                LightCost = 15,
                HasSideTransparency = false,
            }
        };
    }
}
