using System.Collections.Generic;
namespace MinecraftData._1_18_2.blocks.minecraft
{
    [Block(BlockNameID.lime_candle)]
    public class lime_candle : IBlockData
    {
        public short DefaultStateID => 17457;
        public state DefaultState => States[3];
        public float Hardness => 0.1f;
        public float ExplosionResistance => 0.1f;
        public bool IsTransparent => true;
        public byte SoundGroup => 48;
        public short DroppedItem => 1085;
        public MinecraftMaterial Material => MinecraftMaterial.decoration;
        public Dictionary<string, List<string>> Properties => new Dictionary<string, List<string>>()
        {
            { "candles", new List<string>() { "1", "2", "3", "4" } },
            { "lit", new List<string>() { "True", "False" } },
            { "waterlogged", new List<string>() { "True", "False" } }
        };
        public state[] States => new state[]
        {
            new state
            {
                Id = 17454,
                Properties = new byte[] { 0,0,0 },
                CollisionShape = 322,
                Luminance = 3,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 17455,
                Properties = new byte[] { 0,0,1 },
                CollisionShape = 322,
                Luminance = 3,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 17456,
                Properties = new byte[] { 0,1,0 },
                CollisionShape = 322,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 17457,
                Properties = new byte[] { 0,1,1 },
                CollisionShape = 322,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 17458,
                Properties = new byte[] { 1,0,0 },
                CollisionShape = 737,
                Luminance = 6,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 17459,
                Properties = new byte[] { 1,0,1 },
                CollisionShape = 737,
                Luminance = 6,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 17460,
                Properties = new byte[] { 1,1,0 },
                CollisionShape = 737,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 17461,
                Properties = new byte[] { 1,1,1 },
                CollisionShape = 737,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 17462,
                Properties = new byte[] { 2,0,0 },
                CollisionShape = 738,
                Luminance = 9,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 17463,
                Properties = new byte[] { 2,0,1 },
                CollisionShape = 738,
                Luminance = 9,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 17464,
                Properties = new byte[] { 2,1,0 },
                CollisionShape = 738,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 17465,
                Properties = new byte[] { 2,1,1 },
                CollisionShape = 738,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 17466,
                Properties = new byte[] { 3,0,0 },
                CollisionShape = 739,
                Luminance = 12,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 17467,
                Properties = new byte[] { 3,0,1 },
                CollisionShape = 739,
                Luminance = 12,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 17468,
                Properties = new byte[] { 3,1,0 },
                CollisionShape = 739,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 17469,
                Properties = new byte[] { 3,1,1 },
                CollisionShape = 739,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            }
        };
    }
}
