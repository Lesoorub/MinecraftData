using System.Collections.Generic;
namespace MinecraftData._1_18_2.blocks.minecraft
{
    [Block(BlockNameID.acacia_stairs)]
    public class acacia_stairs : IBlockData
    {
        public short DefaultStateID => 7604;
        public state DefaultState => States[11];
        public float Hardness => 2f;
        public float ExplosionResistance => 3f;
        public bool IsTransparent => false;
        public byte SoundGroup => 0;
        public short DroppedItem => 391;
        public MinecraftMaterial Material => MinecraftMaterial.wood;
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
                Id = 7593,
                Properties = new byte[] { 0,0,0,0 },
                CollisionShape = 78,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7594,
                Properties = new byte[] { 0,0,0,1 },
                CollisionShape = 78,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7595,
                Properties = new byte[] { 0,0,1,0 },
                CollisionShape = 81,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7596,
                Properties = new byte[] { 0,0,1,1 },
                CollisionShape = 81,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7597,
                Properties = new byte[] { 0,0,2,0 },
                CollisionShape = 84,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7598,
                Properties = new byte[] { 0,0,2,1 },
                CollisionShape = 84,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7599,
                Properties = new byte[] { 0,0,3,0 },
                CollisionShape = 87,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7600,
                Properties = new byte[] { 0,0,3,1 },
                CollisionShape = 87,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7601,
                Properties = new byte[] { 0,0,4,0 },
                CollisionShape = 89,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7602,
                Properties = new byte[] { 0,0,4,1 },
                CollisionShape = 89,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7603,
                Properties = new byte[] { 0,1,0,0 },
                CollisionShape = 91,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7604,
                Properties = new byte[] { 0,1,0,1 },
                CollisionShape = 91,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7605,
                Properties = new byte[] { 0,1,1,0 },
                CollisionShape = 92,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7606,
                Properties = new byte[] { 0,1,1,1 },
                CollisionShape = 92,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7607,
                Properties = new byte[] { 0,1,2,0 },
                CollisionShape = 94,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7608,
                Properties = new byte[] { 0,1,2,1 },
                CollisionShape = 94,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7609,
                Properties = new byte[] { 0,1,3,0 },
                CollisionShape = 96,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7610,
                Properties = new byte[] { 0,1,3,1 },
                CollisionShape = 96,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7611,
                Properties = new byte[] { 0,1,4,0 },
                CollisionShape = 97,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7612,
                Properties = new byte[] { 0,1,4,1 },
                CollisionShape = 97,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7613,
                Properties = new byte[] { 1,0,0,0 },
                CollisionShape = 98,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7614,
                Properties = new byte[] { 1,0,0,1 },
                CollisionShape = 98,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7615,
                Properties = new byte[] { 1,0,1,0 },
                CollisionShape = 100,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7616,
                Properties = new byte[] { 1,0,1,1 },
                CollisionShape = 100,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7617,
                Properties = new byte[] { 1,0,2,0 },
                CollisionShape = 102,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7618,
                Properties = new byte[] { 1,0,2,1 },
                CollisionShape = 102,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7619,
                Properties = new byte[] { 1,0,3,0 },
                CollisionShape = 104,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7620,
                Properties = new byte[] { 1,0,3,1 },
                CollisionShape = 104,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7621,
                Properties = new byte[] { 1,0,4,0 },
                CollisionShape = 106,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7622,
                Properties = new byte[] { 1,0,4,1 },
                CollisionShape = 106,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7623,
                Properties = new byte[] { 1,1,0,0 },
                CollisionShape = 108,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7624,
                Properties = new byte[] { 1,1,0,1 },
                CollisionShape = 108,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7625,
                Properties = new byte[] { 1,1,1,0 },
                CollisionShape = 109,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7626,
                Properties = new byte[] { 1,1,1,1 },
                CollisionShape = 109,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7627,
                Properties = new byte[] { 1,1,2,0 },
                CollisionShape = 110,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7628,
                Properties = new byte[] { 1,1,2,1 },
                CollisionShape = 110,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7629,
                Properties = new byte[] { 1,1,3,0 },
                CollisionShape = 111,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7630,
                Properties = new byte[] { 1,1,3,1 },
                CollisionShape = 111,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7631,
                Properties = new byte[] { 1,1,4,0 },
                CollisionShape = 112,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7632,
                Properties = new byte[] { 1,1,4,1 },
                CollisionShape = 112,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7633,
                Properties = new byte[] { 2,0,0,0 },
                CollisionShape = 83,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7634,
                Properties = new byte[] { 2,0,0,1 },
                CollisionShape = 83,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7635,
                Properties = new byte[] { 2,0,1,0 },
                CollisionShape = 102,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7636,
                Properties = new byte[] { 2,0,1,1 },
                CollisionShape = 102,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7637,
                Properties = new byte[] { 2,0,2,0 },
                CollisionShape = 81,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7638,
                Properties = new byte[] { 2,0,2,1 },
                CollisionShape = 81,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7639,
                Properties = new byte[] { 2,0,3,0 },
                CollisionShape = 106,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7640,
                Properties = new byte[] { 2,0,3,1 },
                CollisionShape = 106,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7641,
                Properties = new byte[] { 2,0,4,0 },
                CollisionShape = 87,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7642,
                Properties = new byte[] { 2,0,4,1 },
                CollisionShape = 87,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7643,
                Properties = new byte[] { 2,1,0,0 },
                CollisionShape = 93,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7644,
                Properties = new byte[] { 2,1,0,1 },
                CollisionShape = 93,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7645,
                Properties = new byte[] { 2,1,1,0 },
                CollisionShape = 110,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7646,
                Properties = new byte[] { 2,1,1,1 },
                CollisionShape = 110,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7647,
                Properties = new byte[] { 2,1,2,0 },
                CollisionShape = 92,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7648,
                Properties = new byte[] { 2,1,2,1 },
                CollisionShape = 92,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7649,
                Properties = new byte[] { 2,1,3,0 },
                CollisionShape = 112,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7650,
                Properties = new byte[] { 2,1,3,1 },
                CollisionShape = 112,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7651,
                Properties = new byte[] { 2,1,4,0 },
                CollisionShape = 96,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7652,
                Properties = new byte[] { 2,1,4,1 },
                CollisionShape = 96,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7653,
                Properties = new byte[] { 3,0,0,0 },
                CollisionShape = 86,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7654,
                Properties = new byte[] { 3,0,0,1 },
                CollisionShape = 86,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7655,
                Properties = new byte[] { 3,0,1,0 },
                CollisionShape = 84,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7656,
                Properties = new byte[] { 3,0,1,1 },
                CollisionShape = 84,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7657,
                Properties = new byte[] { 3,0,2,0 },
                CollisionShape = 100,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7658,
                Properties = new byte[] { 3,0,2,1 },
                CollisionShape = 100,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7659,
                Properties = new byte[] { 3,0,3,0 },
                CollisionShape = 89,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7660,
                Properties = new byte[] { 3,0,3,1 },
                CollisionShape = 89,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7661,
                Properties = new byte[] { 3,0,4,0 },
                CollisionShape = 104,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7662,
                Properties = new byte[] { 3,0,4,1 },
                CollisionShape = 104,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7663,
                Properties = new byte[] { 3,1,0,0 },
                CollisionShape = 95,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7664,
                Properties = new byte[] { 3,1,0,1 },
                CollisionShape = 95,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7665,
                Properties = new byte[] { 3,1,1,0 },
                CollisionShape = 94,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7666,
                Properties = new byte[] { 3,1,1,1 },
                CollisionShape = 94,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7667,
                Properties = new byte[] { 3,1,2,0 },
                CollisionShape = 109,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7668,
                Properties = new byte[] { 3,1,2,1 },
                CollisionShape = 109,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7669,
                Properties = new byte[] { 3,1,3,0 },
                CollisionShape = 97,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7670,
                Properties = new byte[] { 3,1,3,1 },
                CollisionShape = 97,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7671,
                Properties = new byte[] { 3,1,4,0 },
                CollisionShape = 111,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 7672,
                Properties = new byte[] { 3,1,4,1 },
                CollisionShape = 111,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            }
        };
    }
}
