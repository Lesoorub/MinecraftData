using System.Collections.Generic;
namespace MinecraftData._1_18_2.blocks.minecraft
{
    [Block(BlockNameID.warped_fence)]
    public class warped_fence : IBlockData
    {
        public short DefaultStateID => 15380;
        public state DefaultState => States[31];
        public float Hardness => 2f;
        public float ExplosionResistance => 3f;
        public bool IsTransparent => false;
        public byte SoundGroup => 0;
        public short DroppedItem => 264;
        public MinecraftMaterial Material => MinecraftMaterial.nether_wood;
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
                Id = 15349,
                Properties = new byte[] { 0,0,0,0,0 },
                CollisionShape = 249,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 15350,
                Properties = new byte[] { 0,0,0,0,1 },
                CollisionShape = 253,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 15351,
                Properties = new byte[] { 0,0,0,1,0 },
                CollisionShape = 249,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 15352,
                Properties = new byte[] { 0,0,0,1,1 },
                CollisionShape = 253,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 15353,
                Properties = new byte[] { 0,0,1,0,0 },
                CollisionShape = 255,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 15354,
                Properties = new byte[] { 0,0,1,0,1 },
                CollisionShape = 257,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 15355,
                Properties = new byte[] { 0,0,1,1,0 },
                CollisionShape = 255,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 15356,
                Properties = new byte[] { 0,0,1,1,1 },
                CollisionShape = 257,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 15357,
                Properties = new byte[] { 0,1,0,0,0 },
                CollisionShape = 259,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 15358,
                Properties = new byte[] { 0,1,0,0,1 },
                CollisionShape = 261,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 15359,
                Properties = new byte[] { 0,1,0,1,0 },
                CollisionShape = 259,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 15360,
                Properties = new byte[] { 0,1,0,1,1 },
                CollisionShape = 261,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 15361,
                Properties = new byte[] { 0,1,1,0,0 },
                CollisionShape = 263,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 15362,
                Properties = new byte[] { 0,1,1,0,1 },
                CollisionShape = 265,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 15363,
                Properties = new byte[] { 0,1,1,1,0 },
                CollisionShape = 263,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 15364,
                Properties = new byte[] { 0,1,1,1,1 },
                CollisionShape = 265,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 15365,
                Properties = new byte[] { 1,0,0,0,0 },
                CollisionShape = 267,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 15366,
                Properties = new byte[] { 1,0,0,0,1 },
                CollisionShape = 269,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 15367,
                Properties = new byte[] { 1,0,0,1,0 },
                CollisionShape = 267,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 15368,
                Properties = new byte[] { 1,0,0,1,1 },
                CollisionShape = 269,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 15369,
                Properties = new byte[] { 1,0,1,0,0 },
                CollisionShape = 271,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 15370,
                Properties = new byte[] { 1,0,1,0,1 },
                CollisionShape = 273,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 15371,
                Properties = new byte[] { 1,0,1,1,0 },
                CollisionShape = 271,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 15372,
                Properties = new byte[] { 1,0,1,1,1 },
                CollisionShape = 273,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 15373,
                Properties = new byte[] { 1,1,0,0,0 },
                CollisionShape = 275,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 15374,
                Properties = new byte[] { 1,1,0,0,1 },
                CollisionShape = 277,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 15375,
                Properties = new byte[] { 1,1,0,1,0 },
                CollisionShape = 275,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 15376,
                Properties = new byte[] { 1,1,0,1,1 },
                CollisionShape = 277,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 15377,
                Properties = new byte[] { 1,1,1,0,0 },
                CollisionShape = 279,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 15378,
                Properties = new byte[] { 1,1,1,0,1 },
                CollisionShape = 281,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 15379,
                Properties = new byte[] { 1,1,1,1,0 },
                CollisionShape = 279,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 15380,
                Properties = new byte[] { 1,1,1,1,1 },
                CollisionShape = 281,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            }
        };
    }
}
