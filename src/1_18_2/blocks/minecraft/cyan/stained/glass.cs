using System.Collections.Generic;
namespace MinecraftData._1_18_2.blocks.minecraft
{
    [Block(BlockNameID.cyan_stained_glass)]
    public class cyan_stained_glass : IBlockData
    {
        public short DefaultStateID => 4173;
        public state DefaultState => States[0];
        public float Hardness => 0.3f;
        public float ExplosionResistance => 0.3f;
        public bool IsTransparent => true;
        public byte SoundGroup => 6;
        public short DroppedItem => 409;
        public MinecraftMaterial Material => MinecraftMaterial.glass;
        public Dictionary<string, List<string>> Properties => new Dictionary<string, List<string>>()
        {
            
        };
        public state[] States => new state[]
        {
            new state
            {
                Id = 4173,
                Properties = new byte[] {  },
                CollisionShape = 0,
                LightCost = 0,
                HasSideTransparency = false,
            }
        };
    }
}