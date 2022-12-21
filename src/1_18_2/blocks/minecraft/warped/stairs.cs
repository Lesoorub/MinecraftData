using System.Collections.Generic;
namespace MinecraftData._1_18_2.blocks.minecraft
{
    [Block(BlockNameID.warped_stairs)]
    public class warped_stairs : IBlockData
    {
        public short DefaultStateID => 15664;
        public state DefaultState => States[11];
        public float Hardness => 2f;
        public float ExplosionResistance => 3f;
        public bool IsTransparent => false;
        public byte SoundGroup => 0;
        public short DroppedItem => 322;
        public MinecraftMaterial Material => MinecraftMaterial.nether_wood;
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
                Id = 15653,
                Properties = new byte[] { 0,0,0,0 },
                CollisionShape = 78,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15654,
                Properties = new byte[] { 0,0,0,1 },
                CollisionShape = 78,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15655,
                Properties = new byte[] { 0,0,1,0 },
                CollisionShape = 81,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15656,
                Properties = new byte[] { 0,0,1,1 },
                CollisionShape = 81,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15657,
                Properties = new byte[] { 0,0,2,0 },
                CollisionShape = 84,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15658,
                Properties = new byte[] { 0,0,2,1 },
                CollisionShape = 84,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15659,
                Properties = new byte[] { 0,0,3,0 },
                CollisionShape = 87,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15660,
                Properties = new byte[] { 0,0,3,1 },
                CollisionShape = 87,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15661,
                Properties = new byte[] { 0,0,4,0 },
                CollisionShape = 89,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15662,
                Properties = new byte[] { 0,0,4,1 },
                CollisionShape = 89,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15663,
                Properties = new byte[] { 0,1,0,0 },
                CollisionShape = 91,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15664,
                Properties = new byte[] { 0,1,0,1 },
                CollisionShape = 91,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15665,
                Properties = new byte[] { 0,1,1,0 },
                CollisionShape = 92,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15666,
                Properties = new byte[] { 0,1,1,1 },
                CollisionShape = 92,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15667,
                Properties = new byte[] { 0,1,2,0 },
                CollisionShape = 94,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15668,
                Properties = new byte[] { 0,1,2,1 },
                CollisionShape = 94,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15669,
                Properties = new byte[] { 0,1,3,0 },
                CollisionShape = 96,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15670,
                Properties = new byte[] { 0,1,3,1 },
                CollisionShape = 96,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15671,
                Properties = new byte[] { 0,1,4,0 },
                CollisionShape = 97,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15672,
                Properties = new byte[] { 0,1,4,1 },
                CollisionShape = 97,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15673,
                Properties = new byte[] { 1,0,0,0 },
                CollisionShape = 98,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15674,
                Properties = new byte[] { 1,0,0,1 },
                CollisionShape = 98,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15675,
                Properties = new byte[] { 1,0,1,0 },
                CollisionShape = 100,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15676,
                Properties = new byte[] { 1,0,1,1 },
                CollisionShape = 100,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15677,
                Properties = new byte[] { 1,0,2,0 },
                CollisionShape = 102,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15678,
                Properties = new byte[] { 1,0,2,1 },
                CollisionShape = 102,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15679,
                Properties = new byte[] { 1,0,3,0 },
                CollisionShape = 104,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15680,
                Properties = new byte[] { 1,0,3,1 },
                CollisionShape = 104,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15681,
                Properties = new byte[] { 1,0,4,0 },
                CollisionShape = 106,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15682,
                Properties = new byte[] { 1,0,4,1 },
                CollisionShape = 106,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15683,
                Properties = new byte[] { 1,1,0,0 },
                CollisionShape = 108,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15684,
                Properties = new byte[] { 1,1,0,1 },
                CollisionShape = 108,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15685,
                Properties = new byte[] { 1,1,1,0 },
                CollisionShape = 109,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15686,
                Properties = new byte[] { 1,1,1,1 },
                CollisionShape = 109,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15687,
                Properties = new byte[] { 1,1,2,0 },
                CollisionShape = 110,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15688,
                Properties = new byte[] { 1,1,2,1 },
                CollisionShape = 110,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15689,
                Properties = new byte[] { 1,1,3,0 },
                CollisionShape = 111,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15690,
                Properties = new byte[] { 1,1,3,1 },
                CollisionShape = 111,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15691,
                Properties = new byte[] { 1,1,4,0 },
                CollisionShape = 112,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15692,
                Properties = new byte[] { 1,1,4,1 },
                CollisionShape = 112,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15693,
                Properties = new byte[] { 2,0,0,0 },
                CollisionShape = 83,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15694,
                Properties = new byte[] { 2,0,0,1 },
                CollisionShape = 83,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15695,
                Properties = new byte[] { 2,0,1,0 },
                CollisionShape = 102,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15696,
                Properties = new byte[] { 2,0,1,1 },
                CollisionShape = 102,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15697,
                Properties = new byte[] { 2,0,2,0 },
                CollisionShape = 81,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15698,
                Properties = new byte[] { 2,0,2,1 },
                CollisionShape = 81,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15699,
                Properties = new byte[] { 2,0,3,0 },
                CollisionShape = 106,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15700,
                Properties = new byte[] { 2,0,3,1 },
                CollisionShape = 106,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15701,
                Properties = new byte[] { 2,0,4,0 },
                CollisionShape = 87,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15702,
                Properties = new byte[] { 2,0,4,1 },
                CollisionShape = 87,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15703,
                Properties = new byte[] { 2,1,0,0 },
                CollisionShape = 93,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15704,
                Properties = new byte[] { 2,1,0,1 },
                CollisionShape = 93,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15705,
                Properties = new byte[] { 2,1,1,0 },
                CollisionShape = 110,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15706,
                Properties = new byte[] { 2,1,1,1 },
                CollisionShape = 110,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15707,
                Properties = new byte[] { 2,1,2,0 },
                CollisionShape = 92,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15708,
                Properties = new byte[] { 2,1,2,1 },
                CollisionShape = 92,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15709,
                Properties = new byte[] { 2,1,3,0 },
                CollisionShape = 112,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15710,
                Properties = new byte[] { 2,1,3,1 },
                CollisionShape = 112,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15711,
                Properties = new byte[] { 2,1,4,0 },
                CollisionShape = 96,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15712,
                Properties = new byte[] { 2,1,4,1 },
                CollisionShape = 96,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15713,
                Properties = new byte[] { 3,0,0,0 },
                CollisionShape = 86,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15714,
                Properties = new byte[] { 3,0,0,1 },
                CollisionShape = 86,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15715,
                Properties = new byte[] { 3,0,1,0 },
                CollisionShape = 84,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15716,
                Properties = new byte[] { 3,0,1,1 },
                CollisionShape = 84,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15717,
                Properties = new byte[] { 3,0,2,0 },
                CollisionShape = 100,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15718,
                Properties = new byte[] { 3,0,2,1 },
                CollisionShape = 100,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15719,
                Properties = new byte[] { 3,0,3,0 },
                CollisionShape = 89,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15720,
                Properties = new byte[] { 3,0,3,1 },
                CollisionShape = 89,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15721,
                Properties = new byte[] { 3,0,4,0 },
                CollisionShape = 104,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15722,
                Properties = new byte[] { 3,0,4,1 },
                CollisionShape = 104,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15723,
                Properties = new byte[] { 3,1,0,0 },
                CollisionShape = 95,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15724,
                Properties = new byte[] { 3,1,0,1 },
                CollisionShape = 95,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15725,
                Properties = new byte[] { 3,1,1,0 },
                CollisionShape = 94,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15726,
                Properties = new byte[] { 3,1,1,1 },
                CollisionShape = 94,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15727,
                Properties = new byte[] { 3,1,2,0 },
                CollisionShape = 109,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15728,
                Properties = new byte[] { 3,1,2,1 },
                CollisionShape = 109,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15729,
                Properties = new byte[] { 3,1,3,0 },
                CollisionShape = 97,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15730,
                Properties = new byte[] { 3,1,3,1 },
                CollisionShape = 97,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15731,
                Properties = new byte[] { 3,1,4,0 },
                CollisionShape = 111,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = true,
            },
            new state
            {
                Id = 15732,
                Properties = new byte[] { 3,1,4,1 },
                CollisionShape = 111,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = true,
            }
        };
    }
}
