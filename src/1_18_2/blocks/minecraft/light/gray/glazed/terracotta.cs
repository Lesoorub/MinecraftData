using System.Collections.Generic;
namespace MinecraftData._1_18_2.blocks.minecraft
{
    [Block(BlockNameID.light_gray_glazed_terracotta)]
    public class light_gray_glazed_terracotta : IBlockData
    {
        public short DefaultStateID => 9656;
        public state DefaultState => States[0];
        public float Hardness => 1.4f;
        public float ExplosionResistance => 1.4f;
        public bool IsTransparent => false;
        public byte SoundGroup => 4;
        public short DroppedItem => 476;
        public MinecraftMaterial Material => MinecraftMaterial.stone;
        public Dictionary<string, List<string>> Properties => new Dictionary<string, List<string>>()
        {
            { "facing", new List<string>() { "north", "south", "west", "east" } }
        };
        public state[] States => new state[]
        {
            new state
            {
                Id = 9656,
                Properties = new byte[] { 0 },
                CollisionShape = 0,
                Luminance = 0,
                LightCost = 15,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9657,
                Properties = new byte[] { 1 },
                CollisionShape = 0,
                Luminance = 0,
                LightCost = 15,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9658,
                Properties = new byte[] { 2 },
                CollisionShape = 0,
                Luminance = 0,
                LightCost = 15,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9659,
                Properties = new byte[] { 3 },
                CollisionShape = 0,
                Luminance = 0,
                LightCost = 15,
                HasSideTransparency = false,
            }
        };
    }
}
