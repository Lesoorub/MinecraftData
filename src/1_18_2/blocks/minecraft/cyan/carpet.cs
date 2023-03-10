using System.Collections.Generic;
namespace MinecraftData._1_18_2.blocks.minecraft
{
    [Block(BlockNameID.cyan_carpet)]
    public class cyan_carpet : IBlockData
    {
        public short DefaultStateID => 8125;
        public state DefaultState => States[0];
        public float Hardness => 0.1f;
        public float ExplosionResistance => 0.1f;
        public bool IsTransparent => false;
        public byte SoundGroup => 7;
        public short DroppedItem => 382;
        public MinecraftMaterial Material => MinecraftMaterial.carpet;
        public Dictionary<string, List<string>> Properties => new Dictionary<string, List<string>>()
        {
            
        };
        public state[] States => new state[]
        {
            new state
            {
                Id = 8125,
                Properties = new byte[] {  },
                CollisionShape = 77,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            }
        };
    }
}
