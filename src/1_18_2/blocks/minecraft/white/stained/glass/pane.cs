using System.Collections.Generic;
namespace MinecraftData._1_18_2.blocks.minecraft
{
    [Block(BlockNameID.white_stained_glass_pane)]
    public class white_stained_glass_pane : IBlockData
    {
        public short DefaultStateID => 7112;
        public state DefaultState => States[31];
        public float Hardness => 0.3f;
        public float ExplosionResistance => 0.3f;
        public bool IsTransparent => true;
        public byte SoundGroup => 6;
        public short DroppedItem => 416;
        public MinecraftMaterial Material => MinecraftMaterial.glass;
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
                Id = 7081,
                Properties = new byte[] { 0,0,0,0,0 },
                CollisionShape = 297,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7082,
                Properties = new byte[] { 0,0,0,0,1 },
                CollisionShape = 298,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7083,
                Properties = new byte[] { 0,0,0,1,0 },
                CollisionShape = 297,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7084,
                Properties = new byte[] { 0,0,0,1,1 },
                CollisionShape = 298,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7085,
                Properties = new byte[] { 0,0,1,0,0 },
                CollisionShape = 299,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7086,
                Properties = new byte[] { 0,0,1,0,1 },
                CollisionShape = 300,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7087,
                Properties = new byte[] { 0,0,1,1,0 },
                CollisionShape = 299,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7088,
                Properties = new byte[] { 0,0,1,1,1 },
                CollisionShape = 300,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7089,
                Properties = new byte[] { 0,1,0,0,0 },
                CollisionShape = 301,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7090,
                Properties = new byte[] { 0,1,0,0,1 },
                CollisionShape = 302,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7091,
                Properties = new byte[] { 0,1,0,1,0 },
                CollisionShape = 301,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7092,
                Properties = new byte[] { 0,1,0,1,1 },
                CollisionShape = 302,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7093,
                Properties = new byte[] { 0,1,1,0,0 },
                CollisionShape = 303,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7094,
                Properties = new byte[] { 0,1,1,0,1 },
                CollisionShape = 304,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7095,
                Properties = new byte[] { 0,1,1,1,0 },
                CollisionShape = 303,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7096,
                Properties = new byte[] { 0,1,1,1,1 },
                CollisionShape = 304,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7097,
                Properties = new byte[] { 1,0,0,0,0 },
                CollisionShape = 305,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7098,
                Properties = new byte[] { 1,0,0,0,1 },
                CollisionShape = 306,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7099,
                Properties = new byte[] { 1,0,0,1,0 },
                CollisionShape = 305,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7100,
                Properties = new byte[] { 1,0,0,1,1 },
                CollisionShape = 306,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7101,
                Properties = new byte[] { 1,0,1,0,0 },
                CollisionShape = 307,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7102,
                Properties = new byte[] { 1,0,1,0,1 },
                CollisionShape = 308,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7103,
                Properties = new byte[] { 1,0,1,1,0 },
                CollisionShape = 307,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7104,
                Properties = new byte[] { 1,0,1,1,1 },
                CollisionShape = 308,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7105,
                Properties = new byte[] { 1,1,0,0,0 },
                CollisionShape = 309,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7106,
                Properties = new byte[] { 1,1,0,0,1 },
                CollisionShape = 310,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7107,
                Properties = new byte[] { 1,1,0,1,0 },
                CollisionShape = 309,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7108,
                Properties = new byte[] { 1,1,0,1,1 },
                CollisionShape = 310,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7109,
                Properties = new byte[] { 1,1,1,0,0 },
                CollisionShape = 311,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7110,
                Properties = new byte[] { 1,1,1,0,1 },
                CollisionShape = 312,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7111,
                Properties = new byte[] { 1,1,1,1,0 },
                CollisionShape = 311,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7112,
                Properties = new byte[] { 1,1,1,1,1 },
                CollisionShape = 312,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            }
        };
    }
}
