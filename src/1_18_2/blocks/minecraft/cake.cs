using System.Collections.Generic;
namespace MinecraftData._1_18_2.blocks.minecraft
{
    [Block(BlockNameID.cake)]
    public class cake : IBlockData
    {
        public short DefaultStateID => 4093;
        public state DefaultState => States[0];
        public float Hardness => 0.5f;
        public float ExplosionResistance => 0.5f;
        public bool IsTransparent => false;
        public byte SoundGroup => 7;
        public short DroppedItem => 829;
        public MinecraftMaterial Material => MinecraftMaterial.cake;
        public Dictionary<string, List<string>> Properties => new Dictionary<string, List<string>>()
        {
            { "bites", new List<string>() { "0", "1", "2", "3", "4", "5", "6" } }
        };
        public state[] States => new state[]
        {
            new state
            {
                Id = 4093,
                Properties = new byte[] { 0 },
                CollisionShape = 282,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 4094,
                Properties = new byte[] { 1 },
                CollisionShape = 283,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 4095,
                Properties = new byte[] { 2 },
                CollisionShape = 285,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 4096,
                Properties = new byte[] { 3 },
                CollisionShape = 287,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 4097,
                Properties = new byte[] { 4 },
                CollisionShape = 289,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 4098,
                Properties = new byte[] { 5 },
                CollisionShape = 291,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 4099,
                Properties = new byte[] { 6 },
                CollisionShape = 293,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            }
        };
    }
}
