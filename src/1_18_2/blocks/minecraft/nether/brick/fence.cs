using System.Collections.Generic;
namespace MinecraftData._1_18_2.blocks.minecraft
{
    [Block(BlockNameID.nether_brick_fence)]
    public class nether_brick_fence : IBlockData
    {
        public short DefaultStateID => 5248;
        public state DefaultState => States[31];
        public float Hardness => 2f;
        public float ExplosionResistance => 6f;
        public bool IsTransparent => false;
        public byte SoundGroup => 38;
        public short DroppedItem => 308;
        public MinecraftMaterial Material => MinecraftMaterial.stone;
        public Dictionary<string, List<string>> Properties => new Dictionary<string, List<string>>()
        {
            { "east", new List<string>() { "True", "False" } },
            { "north", new List<string>() { "True", "False" } },
            { "south", new List<string>() { "True", "False" } },
            { "waterlogged", new List<string>() { "True", "False" } },
            { "west", new List<string>() { "True", "False" } }
        };
        public state[] States => new state[]
        {
            new state
            {
                Id = 5217,
                Properties = new byte[] { 0,0,0,0,0 },
                CollisionShape = 249,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 5218,
                Properties = new byte[] { 0,0,0,0,1 },
                CollisionShape = 253,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 5219,
                Properties = new byte[] { 0,0,0,1,0 },
                CollisionShape = 249,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 5220,
                Properties = new byte[] { 0,0,0,1,1 },
                CollisionShape = 253,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 5221,
                Properties = new byte[] { 0,0,1,0,0 },
                CollisionShape = 255,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 5222,
                Properties = new byte[] { 0,0,1,0,1 },
                CollisionShape = 257,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 5223,
                Properties = new byte[] { 0,0,1,1,0 },
                CollisionShape = 255,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 5224,
                Properties = new byte[] { 0,0,1,1,1 },
                CollisionShape = 257,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 5225,
                Properties = new byte[] { 0,1,0,0,0 },
                CollisionShape = 259,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 5226,
                Properties = new byte[] { 0,1,0,0,1 },
                CollisionShape = 261,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 5227,
                Properties = new byte[] { 0,1,0,1,0 },
                CollisionShape = 259,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 5228,
                Properties = new byte[] { 0,1,0,1,1 },
                CollisionShape = 261,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 5229,
                Properties = new byte[] { 0,1,1,0,0 },
                CollisionShape = 263,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 5230,
                Properties = new byte[] { 0,1,1,0,1 },
                CollisionShape = 265,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 5231,
                Properties = new byte[] { 0,1,1,1,0 },
                CollisionShape = 263,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 5232,
                Properties = new byte[] { 0,1,1,1,1 },
                CollisionShape = 265,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 5233,
                Properties = new byte[] { 1,0,0,0,0 },
                CollisionShape = 267,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 5234,
                Properties = new byte[] { 1,0,0,0,1 },
                CollisionShape = 269,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 5235,
                Properties = new byte[] { 1,0,0,1,0 },
                CollisionShape = 267,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 5236,
                Properties = new byte[] { 1,0,0,1,1 },
                CollisionShape = 269,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 5237,
                Properties = new byte[] { 1,0,1,0,0 },
                CollisionShape = 271,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 5238,
                Properties = new byte[] { 1,0,1,0,1 },
                CollisionShape = 273,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 5239,
                Properties = new byte[] { 1,0,1,1,0 },
                CollisionShape = 271,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 5240,
                Properties = new byte[] { 1,0,1,1,1 },
                CollisionShape = 273,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 5241,
                Properties = new byte[] { 1,1,0,0,0 },
                CollisionShape = 275,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 5242,
                Properties = new byte[] { 1,1,0,0,1 },
                CollisionShape = 277,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 5243,
                Properties = new byte[] { 1,1,0,1,0 },
                CollisionShape = 275,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 5244,
                Properties = new byte[] { 1,1,0,1,1 },
                CollisionShape = 277,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 5245,
                Properties = new byte[] { 1,1,1,0,0 },
                CollisionShape = 279,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 5246,
                Properties = new byte[] { 1,1,1,0,1 },
                CollisionShape = 281,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 5247,
                Properties = new byte[] { 1,1,1,1,0 },
                CollisionShape = 279,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 5248,
                Properties = new byte[] { 1,1,1,1,1 },
                CollisionShape = 281,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            }
        };
    }
}
