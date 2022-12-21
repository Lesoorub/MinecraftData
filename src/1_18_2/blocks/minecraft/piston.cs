using System.Collections.Generic;
namespace MinecraftData._1_18_2.blocks.minecraft
{
    [Block(BlockNameID.piston)]
    public class piston : IBlockData
    {
        public short DefaultStateID => 1410;
        public state DefaultState => States[6];
        public float Hardness => 1.5f;
        public float ExplosionResistance => 1.5f;
        public bool IsTransparent => false;
        public byte SoundGroup => 4;
        public short DroppedItem => 590;
        public MinecraftMaterial Material => MinecraftMaterial.piston;
        public Dictionary<string, List<string>> Properties => new Dictionary<string, List<string>>()
        {
            { "extended", new List<string>() { "True", "False" } },
            { "facing", new List<string>() { "north", "east", "south", "west", "up", "down" } }
        };
        public state[] States => new state[]
        {
            new state
            {
                Id = 1404,
                Properties = new byte[] { 0,0 },
                CollisionShape = 8,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 1405,
                Properties = new byte[] { 0,1 },
                CollisionShape = 10,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 1406,
                Properties = new byte[] { 0,2 },
                CollisionShape = 11,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 1407,
                Properties = new byte[] { 0,3 },
                CollisionShape = 12,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 1408,
                Properties = new byte[] { 0,4 },
                CollisionShape = 13,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 1409,
                Properties = new byte[] { 0,5 },
                CollisionShape = 14,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 1410,
                Properties = new byte[] { 1,0 },
                CollisionShape = 0,
                Luminance = 0,
                LightCost = 15,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 1411,
                Properties = new byte[] { 1,1 },
                CollisionShape = 0,
                Luminance = 0,
                LightCost = 15,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 1412,
                Properties = new byte[] { 1,2 },
                CollisionShape = 0,
                Luminance = 0,
                LightCost = 15,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 1413,
                Properties = new byte[] { 1,3 },
                CollisionShape = 0,
                Luminance = 0,
                LightCost = 15,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 1414,
                Properties = new byte[] { 1,4 },
                CollisionShape = 0,
                Luminance = 0,
                LightCost = 15,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 1415,
                Properties = new byte[] { 1,5 },
                CollisionShape = 0,
                Luminance = 0,
                LightCost = 15,
                HasSideTransparency = false,
            }
        };
    }
}
