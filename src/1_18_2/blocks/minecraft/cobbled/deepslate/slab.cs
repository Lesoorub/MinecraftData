using System.Collections.Generic;
namespace MinecraftData._1_18_2.blocks.minecraft
{
    [Block(BlockNameID.cobbled_deepslate_slab)]
    public class cobbled_deepslate_slab : IBlockData
    {
        public short DefaultStateID => 18770;
        public state DefaultState => States[3];
        public float Hardness => 3.5f;
        public float ExplosionResistance => 6f;
        public bool IsTransparent => false;
        public byte SoundGroup => 72;
        public short DroppedItem => 580;
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
                Id = 18767,
                Properties = new byte[] { 0,0 },
                CollisionShape = 80,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 18768,
                Properties = new byte[] { 0,1 },
                CollisionShape = 80,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 18769,
                Properties = new byte[] { 1,0 },
                CollisionShape = 7,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 18770,
                Properties = new byte[] { 1,1 },
                CollisionShape = 7,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 18771,
                Properties = new byte[] { 2,0 },
                CollisionShape = 0,
                Luminance = 0,
                LightCost = 15,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 18772,
                Properties = new byte[] { 2,1 },
                CollisionShape = 0,
                Luminance = 0,
                LightCost = 15,
                HasSideTransparency = false,
            }
        };
    }
}
