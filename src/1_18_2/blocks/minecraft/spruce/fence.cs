using System.Collections.Generic;
namespace MinecraftData._1_18_2.blocks.minecraft
{
    [Block(BlockNameID.spruce_fence)]
    public class spruce_fence : IBlockData
    {
        public short DefaultStateID => 8859;
        public state DefaultState => States[31];
        public float Hardness => 2f;
        public float ExplosionResistance => 3f;
        public bool IsTransparent => false;
        public byte SoundGroup => 0;
        public short DroppedItem => 258;
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
                Id = 8828,
                Properties = new byte[] { 0,0,0,0,0 },
                CollisionShape = 249,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8829,
                Properties = new byte[] { 0,0,0,0,1 },
                CollisionShape = 253,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8830,
                Properties = new byte[] { 0,0,0,1,0 },
                CollisionShape = 249,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8831,
                Properties = new byte[] { 0,0,0,1,1 },
                CollisionShape = 253,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8832,
                Properties = new byte[] { 0,0,1,0,0 },
                CollisionShape = 255,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8833,
                Properties = new byte[] { 0,0,1,0,1 },
                CollisionShape = 257,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8834,
                Properties = new byte[] { 0,0,1,1,0 },
                CollisionShape = 255,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8835,
                Properties = new byte[] { 0,0,1,1,1 },
                CollisionShape = 257,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8836,
                Properties = new byte[] { 0,1,0,0,0 },
                CollisionShape = 259,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8837,
                Properties = new byte[] { 0,1,0,0,1 },
                CollisionShape = 261,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8838,
                Properties = new byte[] { 0,1,0,1,0 },
                CollisionShape = 259,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8839,
                Properties = new byte[] { 0,1,0,1,1 },
                CollisionShape = 261,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8840,
                Properties = new byte[] { 0,1,1,0,0 },
                CollisionShape = 263,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8841,
                Properties = new byte[] { 0,1,1,0,1 },
                CollisionShape = 265,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8842,
                Properties = new byte[] { 0,1,1,1,0 },
                CollisionShape = 263,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8843,
                Properties = new byte[] { 0,1,1,1,1 },
                CollisionShape = 265,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8844,
                Properties = new byte[] { 1,0,0,0,0 },
                CollisionShape = 267,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8845,
                Properties = new byte[] { 1,0,0,0,1 },
                CollisionShape = 269,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8846,
                Properties = new byte[] { 1,0,0,1,0 },
                CollisionShape = 267,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8847,
                Properties = new byte[] { 1,0,0,1,1 },
                CollisionShape = 269,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8848,
                Properties = new byte[] { 1,0,1,0,0 },
                CollisionShape = 271,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8849,
                Properties = new byte[] { 1,0,1,0,1 },
                CollisionShape = 273,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8850,
                Properties = new byte[] { 1,0,1,1,0 },
                CollisionShape = 271,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8851,
                Properties = new byte[] { 1,0,1,1,1 },
                CollisionShape = 273,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8852,
                Properties = new byte[] { 1,1,0,0,0 },
                CollisionShape = 275,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8853,
                Properties = new byte[] { 1,1,0,0,1 },
                CollisionShape = 277,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8854,
                Properties = new byte[] { 1,1,0,1,0 },
                CollisionShape = 275,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8855,
                Properties = new byte[] { 1,1,0,1,1 },
                CollisionShape = 277,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8856,
                Properties = new byte[] { 1,1,1,0,0 },
                CollisionShape = 279,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8857,
                Properties = new byte[] { 1,1,1,0,1 },
                CollisionShape = 281,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8858,
                Properties = new byte[] { 1,1,1,1,0 },
                CollisionShape = 279,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8859,
                Properties = new byte[] { 1,1,1,1,1 },
                CollisionShape = 281,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            }
        };
    }
}
