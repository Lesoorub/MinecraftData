using System.Collections.Generic;
namespace MinecraftData._1_18_2.blocks.minecraft
{
    [Block(BlockNameID.polished_andesite_slab)]
    public class polished_andesite_slab : IBlockData
    {
        public short DefaultStateID => 11108;
        public state DefaultState => States[3];
        public float Hardness => 1.5f;
        public float ExplosionResistance => 6f;
        public bool IsTransparent => false;
        public byte SoundGroup => 4;
        public short DroppedItem => 578;
        public MinecraftMaterial Material => MinecraftMaterial.stone;
        public Dictionary<string, List<string>> Properties => new Dictionary<string, List<string>>()
        {
            { "type", new List<string>() { "top", "bottom", "double" } },
            { "waterlogged", new List<string>() { "True", "False" } }
        };
        public state[] States => new state[]
        {
            new state
            {
                Id = 11105,
                Properties = new byte[] { 0,0 },
                CollisionShape = 80,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 11106,
                Properties = new byte[] { 0,1 },
                CollisionShape = 80,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 11107,
                Properties = new byte[] { 1,0 },
                CollisionShape = 7,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 11108,
                Properties = new byte[] { 1,1 },
                CollisionShape = 7,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 11109,
                Properties = new byte[] { 2,0 },
                CollisionShape = 0,
                Luminance = 0,
                LightCost = 15,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 11110,
                Properties = new byte[] { 2,1 },
                CollisionShape = 0,
                Luminance = 0,
                LightCost = 15,
                HasSideTransparency = false,
            }
        };
    }
}
