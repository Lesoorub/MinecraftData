using System.Collections.Generic;
namespace MinecraftData._1_18_2.blocks.minecraft
{
    [Block(BlockNameID.black_stained_glass_pane)]
    public class black_stained_glass_pane : IBlockData
    {
        public short DefaultStateID => 7592;
        public state DefaultState => States[31];
        public float Hardness => 0.3f;
        public float ExplosionResistance => 0.3f;
        public bool IsTransparent => true;
        public byte SoundGroup => 6;
        public short DroppedItem => 431;
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
                Id = 7561,
                Properties = new byte[] { 0,0,0,0,0 },
                CollisionShape = 297,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7562,
                Properties = new byte[] { 0,0,0,0,1 },
                CollisionShape = 298,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7563,
                Properties = new byte[] { 0,0,0,1,0 },
                CollisionShape = 297,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7564,
                Properties = new byte[] { 0,0,0,1,1 },
                CollisionShape = 298,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7565,
                Properties = new byte[] { 0,0,1,0,0 },
                CollisionShape = 299,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7566,
                Properties = new byte[] { 0,0,1,0,1 },
                CollisionShape = 300,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7567,
                Properties = new byte[] { 0,0,1,1,0 },
                CollisionShape = 299,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7568,
                Properties = new byte[] { 0,0,1,1,1 },
                CollisionShape = 300,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7569,
                Properties = new byte[] { 0,1,0,0,0 },
                CollisionShape = 301,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7570,
                Properties = new byte[] { 0,1,0,0,1 },
                CollisionShape = 302,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7571,
                Properties = new byte[] { 0,1,0,1,0 },
                CollisionShape = 301,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7572,
                Properties = new byte[] { 0,1,0,1,1 },
                CollisionShape = 302,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7573,
                Properties = new byte[] { 0,1,1,0,0 },
                CollisionShape = 303,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7574,
                Properties = new byte[] { 0,1,1,0,1 },
                CollisionShape = 304,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7575,
                Properties = new byte[] { 0,1,1,1,0 },
                CollisionShape = 303,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7576,
                Properties = new byte[] { 0,1,1,1,1 },
                CollisionShape = 304,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7577,
                Properties = new byte[] { 1,0,0,0,0 },
                CollisionShape = 305,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7578,
                Properties = new byte[] { 1,0,0,0,1 },
                CollisionShape = 306,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7579,
                Properties = new byte[] { 1,0,0,1,0 },
                CollisionShape = 305,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7580,
                Properties = new byte[] { 1,0,0,1,1 },
                CollisionShape = 306,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7581,
                Properties = new byte[] { 1,0,1,0,0 },
                CollisionShape = 307,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7582,
                Properties = new byte[] { 1,0,1,0,1 },
                CollisionShape = 308,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7583,
                Properties = new byte[] { 1,0,1,1,0 },
                CollisionShape = 307,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7584,
                Properties = new byte[] { 1,0,1,1,1 },
                CollisionShape = 308,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7585,
                Properties = new byte[] { 1,1,0,0,0 },
                CollisionShape = 309,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7586,
                Properties = new byte[] { 1,1,0,0,1 },
                CollisionShape = 310,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7587,
                Properties = new byte[] { 1,1,0,1,0 },
                CollisionShape = 309,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7588,
                Properties = new byte[] { 1,1,0,1,1 },
                CollisionShape = 310,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7589,
                Properties = new byte[] { 1,1,1,0,0 },
                CollisionShape = 311,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7590,
                Properties = new byte[] { 1,1,1,0,1 },
                CollisionShape = 312,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7591,
                Properties = new byte[] { 1,1,1,1,0 },
                CollisionShape = 311,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 7592,
                Properties = new byte[] { 1,1,1,1,1 },
                CollisionShape = 312,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            }
        };
    }
}
