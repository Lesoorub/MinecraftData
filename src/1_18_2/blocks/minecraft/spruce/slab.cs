using System.Collections.Generic;
namespace MinecraftData._1_18_2.blocks.minecraft
{
    [Block(BlockNameID.spruce_slab)]
    public class spruce_slab : IBlockData
    {
        public short DefaultStateID => 8559;
        public state DefaultState => States[3];
        public float Hardness => 2f;
        public float ExplosionResistance => 3f;
        public bool IsTransparent => false;
        public byte SoundGroup => 0;
        public short DroppedItem => 205;
        public MinecraftMaterial Material => MinecraftMaterial.wood;
        public Dictionary<string, List<string>> Properties => new Dictionary<string, List<string>>()
        {
            { "type", new List<string>() { "top", "bottom", "double" } },
            { "waterlogged", new List<string>() { "True", "False" } }
        };
        public state[] States => new state[]
        {
            new state
            {
                Id = 8556,
                Properties = new byte[] { 0,0 },
                CollisionShape = 80,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 8557,
                Properties = new byte[] { 0,1 },
                CollisionShape = 80,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 8558,
                Properties = new byte[] { 1,0 },
                CollisionShape = 7,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 8559,
                Properties = new byte[] { 1,1 },
                CollisionShape = 7,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 8560,
                Properties = new byte[] { 2,0 },
                CollisionShape = 0,
                Luminance = 0,
                LightCost = 15,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8561,
                Properties = new byte[] { 2,1 },
                CollisionShape = 0,
                Luminance = 0,
                LightCost = 15,
                HasSideTransparency = false,
            }
        };
    }
}
