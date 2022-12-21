using System.Collections.Generic;
namespace MinecraftData._1_18_2.blocks.minecraft
{
    [Block(BlockNameID.acacia_fence)]
    public class acacia_fence : IBlockData
    {
        public short DefaultStateID => 8955;
        public state DefaultState => States[31];
        public float Hardness => 2f;
        public float ExplosionResistance => 3f;
        public bool IsTransparent => false;
        public byte SoundGroup => 0;
        public short DroppedItem => 261;
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
                Id = 8924,
                Properties = new byte[] { 0,0,0,0,0 },
                CollisionShape = 249,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8925,
                Properties = new byte[] { 0,0,0,0,1 },
                CollisionShape = 253,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8926,
                Properties = new byte[] { 0,0,0,1,0 },
                CollisionShape = 249,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8927,
                Properties = new byte[] { 0,0,0,1,1 },
                CollisionShape = 253,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8928,
                Properties = new byte[] { 0,0,1,0,0 },
                CollisionShape = 255,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8929,
                Properties = new byte[] { 0,0,1,0,1 },
                CollisionShape = 257,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8930,
                Properties = new byte[] { 0,0,1,1,0 },
                CollisionShape = 255,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8931,
                Properties = new byte[] { 0,0,1,1,1 },
                CollisionShape = 257,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8932,
                Properties = new byte[] { 0,1,0,0,0 },
                CollisionShape = 259,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8933,
                Properties = new byte[] { 0,1,0,0,1 },
                CollisionShape = 261,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8934,
                Properties = new byte[] { 0,1,0,1,0 },
                CollisionShape = 259,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8935,
                Properties = new byte[] { 0,1,0,1,1 },
                CollisionShape = 261,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8936,
                Properties = new byte[] { 0,1,1,0,0 },
                CollisionShape = 263,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8937,
                Properties = new byte[] { 0,1,1,0,1 },
                CollisionShape = 265,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8938,
                Properties = new byte[] { 0,1,1,1,0 },
                CollisionShape = 263,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8939,
                Properties = new byte[] { 0,1,1,1,1 },
                CollisionShape = 265,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8940,
                Properties = new byte[] { 1,0,0,0,0 },
                CollisionShape = 267,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8941,
                Properties = new byte[] { 1,0,0,0,1 },
                CollisionShape = 269,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8942,
                Properties = new byte[] { 1,0,0,1,0 },
                CollisionShape = 267,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8943,
                Properties = new byte[] { 1,0,0,1,1 },
                CollisionShape = 269,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8944,
                Properties = new byte[] { 1,0,1,0,0 },
                CollisionShape = 271,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8945,
                Properties = new byte[] { 1,0,1,0,1 },
                CollisionShape = 273,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8946,
                Properties = new byte[] { 1,0,1,1,0 },
                CollisionShape = 271,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8947,
                Properties = new byte[] { 1,0,1,1,1 },
                CollisionShape = 273,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8948,
                Properties = new byte[] { 1,1,0,0,0 },
                CollisionShape = 275,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8949,
                Properties = new byte[] { 1,1,0,0,1 },
                CollisionShape = 277,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8950,
                Properties = new byte[] { 1,1,0,1,0 },
                CollisionShape = 275,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8951,
                Properties = new byte[] { 1,1,0,1,1 },
                CollisionShape = 277,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8952,
                Properties = new byte[] { 1,1,1,0,0 },
                CollisionShape = 279,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8953,
                Properties = new byte[] { 1,1,1,0,1 },
                CollisionShape = 281,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8954,
                Properties = new byte[] { 1,1,1,1,0 },
                CollisionShape = 279,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8955,
                Properties = new byte[] { 1,1,1,1,1 },
                CollisionShape = 281,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            }
        };
    }
}
