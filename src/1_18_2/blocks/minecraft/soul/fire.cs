using System.Collections.Generic;
namespace MinecraftData._1_18_2.blocks.minecraft
{
    [Block(BlockNameID.soul_fire)]
    public class soul_fire : IBlockData
    {
        public short DefaultStateID => 2008;
        public state DefaultState => States[0];
        public float Hardness => 0f;
        public float ExplosionResistance => 0f;
        public bool IsTransparent => true;
        public byte SoundGroup => 7;
        public short DroppedItem => 0;
        public MinecraftMaterial Material => MinecraftMaterial.fire;
        public Dictionary<string, List<string>> Properties => new Dictionary<string, List<string>>()
        {
            
        };
        public state[] States => new state[]
        {
            new state
            {
                Id = 2008,
                Properties = new byte[] {  },
                CollisionShape = null,
                Luminance = 10,
                LightCost = 0,
                HasSideTransparency = false,
            }
        };
    }
}
