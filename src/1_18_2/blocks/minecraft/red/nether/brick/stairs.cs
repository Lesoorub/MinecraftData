using System.Collections.Generic;
namespace MinecraftData._1_18_2.blocks.minecraft
{
    [Block(BlockNameID.red_nether_brick_stairs)]
    public class red_nether_brick_stairs : IBlockData
    {
        public short DefaultStateID => 10810;
        public state DefaultState => States[11];
        public float Hardness => 2f;
        public float ExplosionResistance => 6f;
        public bool IsTransparent => false;
        public byte SoundGroup => 38;
        public short DroppedItem => 560;
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
                Id = 10799,
                Properties = new byte[] { 0,0,0,0 },
                CollisionShape = 78,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10800,
                Properties = new byte[] { 0,0,0,1 },
                CollisionShape = 78,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10801,
                Properties = new byte[] { 0,0,1,0 },
                CollisionShape = 81,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10802,
                Properties = new byte[] { 0,0,1,1 },
                CollisionShape = 81,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10803,
                Properties = new byte[] { 0,0,2,0 },
                CollisionShape = 84,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10804,
                Properties = new byte[] { 0,0,2,1 },
                CollisionShape = 84,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10805,
                Properties = new byte[] { 0,0,3,0 },
                CollisionShape = 87,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10806,
                Properties = new byte[] { 0,0,3,1 },
                CollisionShape = 87,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10807,
                Properties = new byte[] { 0,0,4,0 },
                CollisionShape = 89,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10808,
                Properties = new byte[] { 0,0,4,1 },
                CollisionShape = 89,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10809,
                Properties = new byte[] { 0,1,0,0 },
                CollisionShape = 91,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10810,
                Properties = new byte[] { 0,1,0,1 },
                CollisionShape = 91,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10811,
                Properties = new byte[] { 0,1,1,0 },
                CollisionShape = 92,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10812,
                Properties = new byte[] { 0,1,1,1 },
                CollisionShape = 92,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10813,
                Properties = new byte[] { 0,1,2,0 },
                CollisionShape = 94,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10814,
                Properties = new byte[] { 0,1,2,1 },
                CollisionShape = 94,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10815,
                Properties = new byte[] { 0,1,3,0 },
                CollisionShape = 96,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10816,
                Properties = new byte[] { 0,1,3,1 },
                CollisionShape = 96,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10817,
                Properties = new byte[] { 0,1,4,0 },
                CollisionShape = 97,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10818,
                Properties = new byte[] { 0,1,4,1 },
                CollisionShape = 97,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10819,
                Properties = new byte[] { 1,0,0,0 },
                CollisionShape = 98,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10820,
                Properties = new byte[] { 1,0,0,1 },
                CollisionShape = 98,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10821,
                Properties = new byte[] { 1,0,1,0 },
                CollisionShape = 100,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10822,
                Properties = new byte[] { 1,0,1,1 },
                CollisionShape = 100,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10823,
                Properties = new byte[] { 1,0,2,0 },
                CollisionShape = 102,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10824,
                Properties = new byte[] { 1,0,2,1 },
                CollisionShape = 102,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10825,
                Properties = new byte[] { 1,0,3,0 },
                CollisionShape = 104,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10826,
                Properties = new byte[] { 1,0,3,1 },
                CollisionShape = 104,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10827,
                Properties = new byte[] { 1,0,4,0 },
                CollisionShape = 106,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10828,
                Properties = new byte[] { 1,0,4,1 },
                CollisionShape = 106,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10829,
                Properties = new byte[] { 1,1,0,0 },
                CollisionShape = 108,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10830,
                Properties = new byte[] { 1,1,0,1 },
                CollisionShape = 108,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10831,
                Properties = new byte[] { 1,1,1,0 },
                CollisionShape = 109,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10832,
                Properties = new byte[] { 1,1,1,1 },
                CollisionShape = 109,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10833,
                Properties = new byte[] { 1,1,2,0 },
                CollisionShape = 110,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10834,
                Properties = new byte[] { 1,1,2,1 },
                CollisionShape = 110,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10835,
                Properties = new byte[] { 1,1,3,0 },
                CollisionShape = 111,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10836,
                Properties = new byte[] { 1,1,3,1 },
                CollisionShape = 111,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10837,
                Properties = new byte[] { 1,1,4,0 },
                CollisionShape = 112,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10838,
                Properties = new byte[] { 1,1,4,1 },
                CollisionShape = 112,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10839,
                Properties = new byte[] { 2,0,0,0 },
                CollisionShape = 83,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10840,
                Properties = new byte[] { 2,0,0,1 },
                CollisionShape = 83,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10841,
                Properties = new byte[] { 2,0,1,0 },
                CollisionShape = 102,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10842,
                Properties = new byte[] { 2,0,1,1 },
                CollisionShape = 102,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10843,
                Properties = new byte[] { 2,0,2,0 },
                CollisionShape = 81,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10844,
                Properties = new byte[] { 2,0,2,1 },
                CollisionShape = 81,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10845,
                Properties = new byte[] { 2,0,3,0 },
                CollisionShape = 106,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10846,
                Properties = new byte[] { 2,0,3,1 },
                CollisionShape = 106,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10847,
                Properties = new byte[] { 2,0,4,0 },
                CollisionShape = 87,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10848,
                Properties = new byte[] { 2,0,4,1 },
                CollisionShape = 87,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10849,
                Properties = new byte[] { 2,1,0,0 },
                CollisionShape = 93,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10850,
                Properties = new byte[] { 2,1,0,1 },
                CollisionShape = 93,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10851,
                Properties = new byte[] { 2,1,1,0 },
                CollisionShape = 110,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10852,
                Properties = new byte[] { 2,1,1,1 },
                CollisionShape = 110,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10853,
                Properties = new byte[] { 2,1,2,0 },
                CollisionShape = 92,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10854,
                Properties = new byte[] { 2,1,2,1 },
                CollisionShape = 92,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10855,
                Properties = new byte[] { 2,1,3,0 },
                CollisionShape = 112,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10856,
                Properties = new byte[] { 2,1,3,1 },
                CollisionShape = 112,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10857,
                Properties = new byte[] { 2,1,4,0 },
                CollisionShape = 96,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10858,
                Properties = new byte[] { 2,1,4,1 },
                CollisionShape = 96,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10859,
                Properties = new byte[] { 3,0,0,0 },
                CollisionShape = 86,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10860,
                Properties = new byte[] { 3,0,0,1 },
                CollisionShape = 86,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10861,
                Properties = new byte[] { 3,0,1,0 },
                CollisionShape = 84,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10862,
                Properties = new byte[] { 3,0,1,1 },
                CollisionShape = 84,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10863,
                Properties = new byte[] { 3,0,2,0 },
                CollisionShape = 100,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10864,
                Properties = new byte[] { 3,0,2,1 },
                CollisionShape = 100,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10865,
                Properties = new byte[] { 3,0,3,0 },
                CollisionShape = 89,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10866,
                Properties = new byte[] { 3,0,3,1 },
                CollisionShape = 89,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10867,
                Properties = new byte[] { 3,0,4,0 },
                CollisionShape = 104,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10868,
                Properties = new byte[] { 3,0,4,1 },
                CollisionShape = 104,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10869,
                Properties = new byte[] { 3,1,0,0 },
                CollisionShape = 95,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10870,
                Properties = new byte[] { 3,1,0,1 },
                CollisionShape = 95,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10871,
                Properties = new byte[] { 3,1,1,0 },
                CollisionShape = 94,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10872,
                Properties = new byte[] { 3,1,1,1 },
                CollisionShape = 94,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10873,
                Properties = new byte[] { 3,1,2,0 },
                CollisionShape = 109,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10874,
                Properties = new byte[] { 3,1,2,1 },
                CollisionShape = 109,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10875,
                Properties = new byte[] { 3,1,3,0 },
                CollisionShape = 97,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10876,
                Properties = new byte[] { 3,1,3,1 },
                CollisionShape = 97,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10877,
                Properties = new byte[] { 3,1,4,0 },
                CollisionShape = 111,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 10878,
                Properties = new byte[] { 3,1,4,1 },
                CollisionShape = 111,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            }
        };
    }
}
