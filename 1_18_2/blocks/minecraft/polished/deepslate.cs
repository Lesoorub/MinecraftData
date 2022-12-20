using System.Collections.Generic;
namespace MinecraftData._1_18_2.blocks.minecraft
{
    [Block(BlockNameID.polished_deepslate)]
    public class polished_deepslate : IBlockData
    {
        public short DefaultStateID => 19097;
        public state DefaultState => States[0];
        public float Hardness => 3.5f;
        public float ExplosionResistance => 6f;
        public bool IsTransparent => false;
        public byte SoundGroup => 75;
        public short DroppedItem => 10;
        public MinecraftMaterial Material => MinecraftMaterial.stone;
        public Dictionary<string, List<string>> Properties => new Dictionary<string, List<string>>()
        {
            
        };
        public state[] States => new state[]
        {
            new state
            {
                Id = 19097,
                Properties = new byte[] {  },
                CollisionShape = 0,
                LightCost = 15,
                HasSideTransparency = false,
            }
        };
    }
}
