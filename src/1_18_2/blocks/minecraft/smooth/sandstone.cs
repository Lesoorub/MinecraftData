using System.Collections.Generic;
namespace MinecraftData._1_18_2.blocks.minecraft
{
    [Block(BlockNameID.smooth_sandstone)]
    public class smooth_sandstone : IBlockData
    {
        public short DefaultStateID => 8665;
        public state DefaultState => States[0];
        public float Hardness => 2f;
        public float ExplosionResistance => 6f;
        public bool IsTransparent => false;
        public byte SoundGroup => 4;
        public short DroppedItem => 230;
        public MinecraftMaterial Material => MinecraftMaterial.stone;
        public Dictionary<string, List<string>> Properties => new Dictionary<string, List<string>>()
        {
            
        };
        public state[] States => new state[]
        {
            new state
            {
                Id = 8665,
                Properties = new byte[] {  },
                CollisionShape = 0,
                Luminance = 0,
                LightCost = 15,
                HasSideTransparency = false,
            }
        };
    }
}
