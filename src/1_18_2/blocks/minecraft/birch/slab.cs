using System.Collections.Generic;
namespace MinecraftData._1_18_2.blocks.minecraft
{
    [Block(BlockNameID.birch_slab)]
    public class birch_slab : IBlockData
    {
        public short DefaultStateID => 8565;
        public state DefaultState => States[3];
        public float Hardness => 2f;
        public float ExplosionResistance => 3f;
        public bool IsTransparent => false;
        public byte SoundGroup => 0;
        public short DroppedItem => 206;
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
                Id = 8562,
                Properties = new byte[] { 0,0 },
                CollisionShape = 80,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 8563,
                Properties = new byte[] { 0,1 },
                CollisionShape = 80,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 8564,
                Properties = new byte[] { 1,0 },
                CollisionShape = 7,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 8565,
                Properties = new byte[] { 1,1 },
                CollisionShape = 7,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 8566,
                Properties = new byte[] { 2,0 },
                CollisionShape = 0,
                Luminance = 0,
                LightCost = 15,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8567,
                Properties = new byte[] { 2,1 },
                CollisionShape = 0,
                Luminance = 0,
                LightCost = 15,
                HasSideTransparency = false,
            }
        };
    }
}
