using System.Collections.Generic;
namespace MinecraftData._1_18_2.blocks.minecraft
{
    [Block(BlockNameID.polished_blackstone_brick_stairs)]
    public class polished_blackstone_brick_stairs : IBlockData
    {
        public short DefaultStateID => 16525;
        public state DefaultState => States[11];
        public float Hardness => 1.5f;
        public float ExplosionResistance => 6f;
        public bool IsTransparent => false;
        public byte SoundGroup => 4;
        public short DroppedItem => 1076;
        public MinecraftMaterial Material => MinecraftMaterial.stone;
        public Dictionary<string, List<string>> Properties => new Dictionary<string, List<string>>()
        {
            { "facing", new List<string>() { "north", "south", "west", "east" } },
            { "half", new List<string>() { "top", "bottom" } },
            { "shape", new List<string>() { "straight", "inner_left", "inner_right", "outer_left", "outer_right" } },
            { "waterlogged", new List<string>() { "True", "False" } }
        };
        public state[] States => new state[]
        {
            new state
            {
                Id = 16514,
                Properties = new byte[] { 0,0,0,0 },
                CollisionShape = 78,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16515,
                Properties = new byte[] { 0,0,0,1 },
                CollisionShape = 78,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16516,
                Properties = new byte[] { 0,0,1,0 },
                CollisionShape = 81,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16517,
                Properties = new byte[] { 0,0,1,1 },
                CollisionShape = 81,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16518,
                Properties = new byte[] { 0,0,2,0 },
                CollisionShape = 84,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16519,
                Properties = new byte[] { 0,0,2,1 },
                CollisionShape = 84,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16520,
                Properties = new byte[] { 0,0,3,0 },
                CollisionShape = 87,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16521,
                Properties = new byte[] { 0,0,3,1 },
                CollisionShape = 87,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16522,
                Properties = new byte[] { 0,0,4,0 },
                CollisionShape = 89,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16523,
                Properties = new byte[] { 0,0,4,1 },
                CollisionShape = 89,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16524,
                Properties = new byte[] { 0,1,0,0 },
                CollisionShape = 91,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16525,
                Properties = new byte[] { 0,1,0,1 },
                CollisionShape = 91,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16526,
                Properties = new byte[] { 0,1,1,0 },
                CollisionShape = 92,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16527,
                Properties = new byte[] { 0,1,1,1 },
                CollisionShape = 92,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16528,
                Properties = new byte[] { 0,1,2,0 },
                CollisionShape = 94,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16529,
                Properties = new byte[] { 0,1,2,1 },
                CollisionShape = 94,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16530,
                Properties = new byte[] { 0,1,3,0 },
                CollisionShape = 96,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16531,
                Properties = new byte[] { 0,1,3,1 },
                CollisionShape = 96,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16532,
                Properties = new byte[] { 0,1,4,0 },
                CollisionShape = 97,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16533,
                Properties = new byte[] { 0,1,4,1 },
                CollisionShape = 97,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16534,
                Properties = new byte[] { 1,0,0,0 },
                CollisionShape = 98,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16535,
                Properties = new byte[] { 1,0,0,1 },
                CollisionShape = 98,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16536,
                Properties = new byte[] { 1,0,1,0 },
                CollisionShape = 100,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16537,
                Properties = new byte[] { 1,0,1,1 },
                CollisionShape = 100,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16538,
                Properties = new byte[] { 1,0,2,0 },
                CollisionShape = 102,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16539,
                Properties = new byte[] { 1,0,2,1 },
                CollisionShape = 102,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16540,
                Properties = new byte[] { 1,0,3,0 },
                CollisionShape = 104,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16541,
                Properties = new byte[] { 1,0,3,1 },
                CollisionShape = 104,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16542,
                Properties = new byte[] { 1,0,4,0 },
                CollisionShape = 106,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16543,
                Properties = new byte[] { 1,0,4,1 },
                CollisionShape = 106,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16544,
                Properties = new byte[] { 1,1,0,0 },
                CollisionShape = 108,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16545,
                Properties = new byte[] { 1,1,0,1 },
                CollisionShape = 108,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16546,
                Properties = new byte[] { 1,1,1,0 },
                CollisionShape = 109,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16547,
                Properties = new byte[] { 1,1,1,1 },
                CollisionShape = 109,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16548,
                Properties = new byte[] { 1,1,2,0 },
                CollisionShape = 110,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16549,
                Properties = new byte[] { 1,1,2,1 },
                CollisionShape = 110,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16550,
                Properties = new byte[] { 1,1,3,0 },
                CollisionShape = 111,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16551,
                Properties = new byte[] { 1,1,3,1 },
                CollisionShape = 111,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16552,
                Properties = new byte[] { 1,1,4,0 },
                CollisionShape = 112,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16553,
                Properties = new byte[] { 1,1,4,1 },
                CollisionShape = 112,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16554,
                Properties = new byte[] { 2,0,0,0 },
                CollisionShape = 83,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16555,
                Properties = new byte[] { 2,0,0,1 },
                CollisionShape = 83,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16556,
                Properties = new byte[] { 2,0,1,0 },
                CollisionShape = 102,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16557,
                Properties = new byte[] { 2,0,1,1 },
                CollisionShape = 102,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16558,
                Properties = new byte[] { 2,0,2,0 },
                CollisionShape = 81,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16559,
                Properties = new byte[] { 2,0,2,1 },
                CollisionShape = 81,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16560,
                Properties = new byte[] { 2,0,3,0 },
                CollisionShape = 106,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16561,
                Properties = new byte[] { 2,0,3,1 },
                CollisionShape = 106,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16562,
                Properties = new byte[] { 2,0,4,0 },
                CollisionShape = 87,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16563,
                Properties = new byte[] { 2,0,4,1 },
                CollisionShape = 87,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16564,
                Properties = new byte[] { 2,1,0,0 },
                CollisionShape = 93,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16565,
                Properties = new byte[] { 2,1,0,1 },
                CollisionShape = 93,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16566,
                Properties = new byte[] { 2,1,1,0 },
                CollisionShape = 110,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16567,
                Properties = new byte[] { 2,1,1,1 },
                CollisionShape = 110,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16568,
                Properties = new byte[] { 2,1,2,0 },
                CollisionShape = 92,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16569,
                Properties = new byte[] { 2,1,2,1 },
                CollisionShape = 92,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16570,
                Properties = new byte[] { 2,1,3,0 },
                CollisionShape = 112,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16571,
                Properties = new byte[] { 2,1,3,1 },
                CollisionShape = 112,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16572,
                Properties = new byte[] { 2,1,4,0 },
                CollisionShape = 96,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16573,
                Properties = new byte[] { 2,1,4,1 },
                CollisionShape = 96,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16574,
                Properties = new byte[] { 3,0,0,0 },
                CollisionShape = 86,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16575,
                Properties = new byte[] { 3,0,0,1 },
                CollisionShape = 86,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16576,
                Properties = new byte[] { 3,0,1,0 },
                CollisionShape = 84,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16577,
                Properties = new byte[] { 3,0,1,1 },
                CollisionShape = 84,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16578,
                Properties = new byte[] { 3,0,2,0 },
                CollisionShape = 100,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16579,
                Properties = new byte[] { 3,0,2,1 },
                CollisionShape = 100,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16580,
                Properties = new byte[] { 3,0,3,0 },
                CollisionShape = 89,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16581,
                Properties = new byte[] { 3,0,3,1 },
                CollisionShape = 89,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16582,
                Properties = new byte[] { 3,0,4,0 },
                CollisionShape = 104,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16583,
                Properties = new byte[] { 3,0,4,1 },
                CollisionShape = 104,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16584,
                Properties = new byte[] { 3,1,0,0 },
                CollisionShape = 95,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16585,
                Properties = new byte[] { 3,1,0,1 },
                CollisionShape = 95,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16586,
                Properties = new byte[] { 3,1,1,0 },
                CollisionShape = 94,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16587,
                Properties = new byte[] { 3,1,1,1 },
                CollisionShape = 94,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16588,
                Properties = new byte[] { 3,1,2,0 },
                CollisionShape = 109,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16589,
                Properties = new byte[] { 3,1,2,1 },
                CollisionShape = 109,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16590,
                Properties = new byte[] { 3,1,3,0 },
                CollisionShape = 97,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16591,
                Properties = new byte[] { 3,1,3,1 },
                CollisionShape = 97,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16592,
                Properties = new byte[] { 3,1,4,0 },
                CollisionShape = 111,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 16593,
                Properties = new byte[] { 3,1,4,1 },
                CollisionShape = 111,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            }
        };
    }
}
