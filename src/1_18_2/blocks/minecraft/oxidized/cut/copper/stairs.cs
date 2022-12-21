using System.Collections.Generic;
namespace MinecraftData._1_18_2.blocks.minecraft
{
    [Block(BlockNameID.oxidized_cut_copper_stairs)]
    public class oxidized_cut_copper_stairs : IBlockData
    {
        public short DefaultStateID => 17835;
        public state DefaultState => States[11];
        public float Hardness => 3f;
        public float ExplosionResistance => 6f;
        public bool IsTransparent => false;
        public byte SoundGroup => 58;
        public short DroppedItem => 80;
        public MinecraftMaterial Material => MinecraftMaterial.metal;
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
                Id = 17824,
                Properties = new byte[] { 0,0,0,0 },
                CollisionShape = 78,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17825,
                Properties = new byte[] { 0,0,0,1 },
                CollisionShape = 78,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17826,
                Properties = new byte[] { 0,0,1,0 },
                CollisionShape = 81,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17827,
                Properties = new byte[] { 0,0,1,1 },
                CollisionShape = 81,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17828,
                Properties = new byte[] { 0,0,2,0 },
                CollisionShape = 84,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17829,
                Properties = new byte[] { 0,0,2,1 },
                CollisionShape = 84,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17830,
                Properties = new byte[] { 0,0,3,0 },
                CollisionShape = 87,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17831,
                Properties = new byte[] { 0,0,3,1 },
                CollisionShape = 87,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17832,
                Properties = new byte[] { 0,0,4,0 },
                CollisionShape = 89,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17833,
                Properties = new byte[] { 0,0,4,1 },
                CollisionShape = 89,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17834,
                Properties = new byte[] { 0,1,0,0 },
                CollisionShape = 91,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17835,
                Properties = new byte[] { 0,1,0,1 },
                CollisionShape = 91,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17836,
                Properties = new byte[] { 0,1,1,0 },
                CollisionShape = 92,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17837,
                Properties = new byte[] { 0,1,1,1 },
                CollisionShape = 92,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17838,
                Properties = new byte[] { 0,1,2,0 },
                CollisionShape = 94,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17839,
                Properties = new byte[] { 0,1,2,1 },
                CollisionShape = 94,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17840,
                Properties = new byte[] { 0,1,3,0 },
                CollisionShape = 96,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17841,
                Properties = new byte[] { 0,1,3,1 },
                CollisionShape = 96,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17842,
                Properties = new byte[] { 0,1,4,0 },
                CollisionShape = 97,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17843,
                Properties = new byte[] { 0,1,4,1 },
                CollisionShape = 97,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17844,
                Properties = new byte[] { 1,0,0,0 },
                CollisionShape = 98,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17845,
                Properties = new byte[] { 1,0,0,1 },
                CollisionShape = 98,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17846,
                Properties = new byte[] { 1,0,1,0 },
                CollisionShape = 100,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17847,
                Properties = new byte[] { 1,0,1,1 },
                CollisionShape = 100,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17848,
                Properties = new byte[] { 1,0,2,0 },
                CollisionShape = 102,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17849,
                Properties = new byte[] { 1,0,2,1 },
                CollisionShape = 102,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17850,
                Properties = new byte[] { 1,0,3,0 },
                CollisionShape = 104,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17851,
                Properties = new byte[] { 1,0,3,1 },
                CollisionShape = 104,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17852,
                Properties = new byte[] { 1,0,4,0 },
                CollisionShape = 106,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17853,
                Properties = new byte[] { 1,0,4,1 },
                CollisionShape = 106,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17854,
                Properties = new byte[] { 1,1,0,0 },
                CollisionShape = 108,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17855,
                Properties = new byte[] { 1,1,0,1 },
                CollisionShape = 108,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17856,
                Properties = new byte[] { 1,1,1,0 },
                CollisionShape = 109,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17857,
                Properties = new byte[] { 1,1,1,1 },
                CollisionShape = 109,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17858,
                Properties = new byte[] { 1,1,2,0 },
                CollisionShape = 110,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17859,
                Properties = new byte[] { 1,1,2,1 },
                CollisionShape = 110,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17860,
                Properties = new byte[] { 1,1,3,0 },
                CollisionShape = 111,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17861,
                Properties = new byte[] { 1,1,3,1 },
                CollisionShape = 111,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17862,
                Properties = new byte[] { 1,1,4,0 },
                CollisionShape = 112,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17863,
                Properties = new byte[] { 1,1,4,1 },
                CollisionShape = 112,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17864,
                Properties = new byte[] { 2,0,0,0 },
                CollisionShape = 83,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17865,
                Properties = new byte[] { 2,0,0,1 },
                CollisionShape = 83,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17866,
                Properties = new byte[] { 2,0,1,0 },
                CollisionShape = 102,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17867,
                Properties = new byte[] { 2,0,1,1 },
                CollisionShape = 102,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17868,
                Properties = new byte[] { 2,0,2,0 },
                CollisionShape = 81,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17869,
                Properties = new byte[] { 2,0,2,1 },
                CollisionShape = 81,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17870,
                Properties = new byte[] { 2,0,3,0 },
                CollisionShape = 106,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17871,
                Properties = new byte[] { 2,0,3,1 },
                CollisionShape = 106,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17872,
                Properties = new byte[] { 2,0,4,0 },
                CollisionShape = 87,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17873,
                Properties = new byte[] { 2,0,4,1 },
                CollisionShape = 87,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17874,
                Properties = new byte[] { 2,1,0,0 },
                CollisionShape = 93,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17875,
                Properties = new byte[] { 2,1,0,1 },
                CollisionShape = 93,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17876,
                Properties = new byte[] { 2,1,1,0 },
                CollisionShape = 110,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17877,
                Properties = new byte[] { 2,1,1,1 },
                CollisionShape = 110,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17878,
                Properties = new byte[] { 2,1,2,0 },
                CollisionShape = 92,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17879,
                Properties = new byte[] { 2,1,2,1 },
                CollisionShape = 92,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17880,
                Properties = new byte[] { 2,1,3,0 },
                CollisionShape = 112,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17881,
                Properties = new byte[] { 2,1,3,1 },
                CollisionShape = 112,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17882,
                Properties = new byte[] { 2,1,4,0 },
                CollisionShape = 96,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17883,
                Properties = new byte[] { 2,1,4,1 },
                CollisionShape = 96,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17884,
                Properties = new byte[] { 3,0,0,0 },
                CollisionShape = 86,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17885,
                Properties = new byte[] { 3,0,0,1 },
                CollisionShape = 86,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17886,
                Properties = new byte[] { 3,0,1,0 },
                CollisionShape = 84,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17887,
                Properties = new byte[] { 3,0,1,1 },
                CollisionShape = 84,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17888,
                Properties = new byte[] { 3,0,2,0 },
                CollisionShape = 100,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17889,
                Properties = new byte[] { 3,0,2,1 },
                CollisionShape = 100,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17890,
                Properties = new byte[] { 3,0,3,0 },
                CollisionShape = 89,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17891,
                Properties = new byte[] { 3,0,3,1 },
                CollisionShape = 89,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17892,
                Properties = new byte[] { 3,0,4,0 },
                CollisionShape = 104,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17893,
                Properties = new byte[] { 3,0,4,1 },
                CollisionShape = 104,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17894,
                Properties = new byte[] { 3,1,0,0 },
                CollisionShape = 95,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17895,
                Properties = new byte[] { 3,1,0,1 },
                CollisionShape = 95,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17896,
                Properties = new byte[] { 3,1,1,0 },
                CollisionShape = 94,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17897,
                Properties = new byte[] { 3,1,1,1 },
                CollisionShape = 94,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17898,
                Properties = new byte[] { 3,1,2,0 },
                CollisionShape = 109,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17899,
                Properties = new byte[] { 3,1,2,1 },
                CollisionShape = 109,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17900,
                Properties = new byte[] { 3,1,3,0 },
                CollisionShape = 97,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17901,
                Properties = new byte[] { 3,1,3,1 },
                CollisionShape = 97,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17902,
                Properties = new byte[] { 3,1,4,0 },
                CollisionShape = 111,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 17903,
                Properties = new byte[] { 3,1,4,1 },
                CollisionShape = 111,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            }
        };
    }
}
