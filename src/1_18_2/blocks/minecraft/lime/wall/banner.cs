using System.Collections.Generic;
namespace MinecraftData._1_18_2.blocks.minecraft
{
    [Block(BlockNameID.lime_wall_banner)]
    public class lime_wall_banner : IBlockData
    {
        public short DefaultStateID => 8423;
        public state DefaultState => States[0];
        public float Hardness => 1f;
        public float ExplosionResistance => 1f;
        public bool IsTransparent => true;
        public byte SoundGroup => 0;
        public short DroppedItem => 987;
        public MinecraftMaterial Material => MinecraftMaterial.wood;
        public Dictionary<string, List<string>> Properties => new Dictionary<string, List<string>>()
        {
            { "facing", new List<string>() { "north", "south", "west", "east" } }
        };
        public state[] States => new state[]
        {
            new state
            {
                Id = 8423,
                Properties = new byte[] { 0 },
                CollisionShape = null,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8424,
                Properties = new byte[] { 1 },
                CollisionShape = null,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8425,
                Properties = new byte[] { 2 },
                CollisionShape = null,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 8426,
                Properties = new byte[] { 3 },
                CollisionShape = null,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            }
        };
    }
}
