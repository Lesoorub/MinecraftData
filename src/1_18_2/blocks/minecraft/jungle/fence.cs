using System.Collections.Generic;
namespace MinecraftData._1_18_2.blocks.minecraft
{
    [Block(BlockNameID.jungle_fence)]
    public class jungle_fence : IBlockData
    {
        public short DefaultStateID => 8923;
        public state DefaultState => States[31];
        public float Hardness => 2f;
        public float ExplosionResistance => 3f;
        public bool IsTransparent => false;
        public byte SoundGroup => 0;
        public short DroppedItem => 260;
        public MinecraftMaterial Material => MinecraftMaterial.wood;
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
                Id = 8892,
                Properties = new byte[] { 0,0,0,0,0 },
                CollisionShape = 249,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8893,
                Properties = new byte[] { 0,0,0,0,1 },
                CollisionShape = 253,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8894,
                Properties = new byte[] { 0,0,0,1,0 },
                CollisionShape = 249,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8895,
                Properties = new byte[] { 0,0,0,1,1 },
                CollisionShape = 253,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8896,
                Properties = new byte[] { 0,0,1,0,0 },
                CollisionShape = 255,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8897,
                Properties = new byte[] { 0,0,1,0,1 },
                CollisionShape = 257,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8898,
                Properties = new byte[] { 0,0,1,1,0 },
                CollisionShape = 255,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8899,
                Properties = new byte[] { 0,0,1,1,1 },
                CollisionShape = 257,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8900,
                Properties = new byte[] { 0,1,0,0,0 },
                CollisionShape = 259,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8901,
                Properties = new byte[] { 0,1,0,0,1 },
                CollisionShape = 261,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8902,
                Properties = new byte[] { 0,1,0,1,0 },
                CollisionShape = 259,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8903,
                Properties = new byte[] { 0,1,0,1,1 },
                CollisionShape = 261,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8904,
                Properties = new byte[] { 0,1,1,0,0 },
                CollisionShape = 263,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8905,
                Properties = new byte[] { 0,1,1,0,1 },
                CollisionShape = 265,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8906,
                Properties = new byte[] { 0,1,1,1,0 },
                CollisionShape = 263,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8907,
                Properties = new byte[] { 0,1,1,1,1 },
                CollisionShape = 265,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8908,
                Properties = new byte[] { 1,0,0,0,0 },
                CollisionShape = 267,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8909,
                Properties = new byte[] { 1,0,0,0,1 },
                CollisionShape = 269,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8910,
                Properties = new byte[] { 1,0,0,1,0 },
                CollisionShape = 267,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8911,
                Properties = new byte[] { 1,0,0,1,1 },
                CollisionShape = 269,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8912,
                Properties = new byte[] { 1,0,1,0,0 },
                CollisionShape = 271,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8913,
                Properties = new byte[] { 1,0,1,0,1 },
                CollisionShape = 273,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8914,
                Properties = new byte[] { 1,0,1,1,0 },
                CollisionShape = 271,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8915,
                Properties = new byte[] { 1,0,1,1,1 },
                CollisionShape = 273,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8916,
                Properties = new byte[] { 1,1,0,0,0 },
                CollisionShape = 275,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8917,
                Properties = new byte[] { 1,1,0,0,1 },
                CollisionShape = 277,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8918,
                Properties = new byte[] { 1,1,0,1,0 },
                CollisionShape = 275,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8919,
                Properties = new byte[] { 1,1,0,1,1 },
                CollisionShape = 277,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8920,
                Properties = new byte[] { 1,1,1,0,0 },
                CollisionShape = 279,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8921,
                Properties = new byte[] { 1,1,1,0,1 },
                CollisionShape = 281,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8922,
                Properties = new byte[] { 1,1,1,1,0 },
                CollisionShape = 279,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8923,
                Properties = new byte[] { 1,1,1,1,1 },
                CollisionShape = 281,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            }
        };
    }
}
