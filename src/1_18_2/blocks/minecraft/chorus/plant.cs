using System.Collections.Generic;
namespace MinecraftData._1_18_2.blocks.minecraft
{
    [Block(BlockNameID.chorus_plant)]
    public class chorus_plant : IBlockData
    {
        public short DefaultStateID => 9377;
        public state DefaultState => States[63];
        public float Hardness => 0.4f;
        public float ExplosionResistance => 0.4f;
        public bool IsTransparent => true;
        public byte SoundGroup => 0;
        public short DroppedItem => 238;
        public MinecraftMaterial Material => MinecraftMaterial.plant;
        public Dictionary<string, List<string>> Properties => new Dictionary<string, List<string>>()
        {
            { "down", new List<string>() { "True", "False" } },
            { "east", new List<string>() { "True", "False" } },
            { "north", new List<string>() { "True", "False" } },
            { "south", new List<string>() { "True", "False" } },
            { "up", new List<string>() { "True", "False" } },
            { "west", new List<string>() { "True", "False" } }
        };
        public state[] States => new state[]
        {
            new state
            {
                Id = 9314,
                Properties = new byte[] { 0,0,0,0,0,0 },
                CollisionShape = 607,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9315,
                Properties = new byte[] { 0,0,0,0,0,1 },
                CollisionShape = 608,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9316,
                Properties = new byte[] { 0,0,0,0,1,0 },
                CollisionShape = 609,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9317,
                Properties = new byte[] { 0,0,0,0,1,1 },
                CollisionShape = 610,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9318,
                Properties = new byte[] { 0,0,0,1,0,0 },
                CollisionShape = 611,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9319,
                Properties = new byte[] { 0,0,0,1,0,1 },
                CollisionShape = 612,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9320,
                Properties = new byte[] { 0,0,0,1,1,0 },
                CollisionShape = 613,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9321,
                Properties = new byte[] { 0,0,0,1,1,1 },
                CollisionShape = 614,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9322,
                Properties = new byte[] { 0,0,1,0,0,0 },
                CollisionShape = 615,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9323,
                Properties = new byte[] { 0,0,1,0,0,1 },
                CollisionShape = 616,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9324,
                Properties = new byte[] { 0,0,1,0,1,0 },
                CollisionShape = 617,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9325,
                Properties = new byte[] { 0,0,1,0,1,1 },
                CollisionShape = 618,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9326,
                Properties = new byte[] { 0,0,1,1,0,0 },
                CollisionShape = 619,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9327,
                Properties = new byte[] { 0,0,1,1,0,1 },
                CollisionShape = 620,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9328,
                Properties = new byte[] { 0,0,1,1,1,0 },
                CollisionShape = 621,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9329,
                Properties = new byte[] { 0,0,1,1,1,1 },
                CollisionShape = 622,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9330,
                Properties = new byte[] { 0,1,0,0,0,0 },
                CollisionShape = 623,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9331,
                Properties = new byte[] { 0,1,0,0,0,1 },
                CollisionShape = 624,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9332,
                Properties = new byte[] { 0,1,0,0,1,0 },
                CollisionShape = 625,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9333,
                Properties = new byte[] { 0,1,0,0,1,1 },
                CollisionShape = 626,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9334,
                Properties = new byte[] { 0,1,0,1,0,0 },
                CollisionShape = 627,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9335,
                Properties = new byte[] { 0,1,0,1,0,1 },
                CollisionShape = 628,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9336,
                Properties = new byte[] { 0,1,0,1,1,0 },
                CollisionShape = 629,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9337,
                Properties = new byte[] { 0,1,0,1,1,1 },
                CollisionShape = 630,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9338,
                Properties = new byte[] { 0,1,1,0,0,0 },
                CollisionShape = 631,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9339,
                Properties = new byte[] { 0,1,1,0,0,1 },
                CollisionShape = 632,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9340,
                Properties = new byte[] { 0,1,1,0,1,0 },
                CollisionShape = 633,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9341,
                Properties = new byte[] { 0,1,1,0,1,1 },
                CollisionShape = 634,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9342,
                Properties = new byte[] { 0,1,1,1,0,0 },
                CollisionShape = 635,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9343,
                Properties = new byte[] { 0,1,1,1,0,1 },
                CollisionShape = 636,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9344,
                Properties = new byte[] { 0,1,1,1,1,0 },
                CollisionShape = 637,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9345,
                Properties = new byte[] { 0,1,1,1,1,1 },
                CollisionShape = 638,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9346,
                Properties = new byte[] { 1,0,0,0,0,0 },
                CollisionShape = 639,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9347,
                Properties = new byte[] { 1,0,0,0,0,1 },
                CollisionShape = 640,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9348,
                Properties = new byte[] { 1,0,0,0,1,0 },
                CollisionShape = 641,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9349,
                Properties = new byte[] { 1,0,0,0,1,1 },
                CollisionShape = 642,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9350,
                Properties = new byte[] { 1,0,0,1,0,0 },
                CollisionShape = 643,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9351,
                Properties = new byte[] { 1,0,0,1,0,1 },
                CollisionShape = 644,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9352,
                Properties = new byte[] { 1,0,0,1,1,0 },
                CollisionShape = 645,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9353,
                Properties = new byte[] { 1,0,0,1,1,1 },
                CollisionShape = 646,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9354,
                Properties = new byte[] { 1,0,1,0,0,0 },
                CollisionShape = 647,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9355,
                Properties = new byte[] { 1,0,1,0,0,1 },
                CollisionShape = 648,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9356,
                Properties = new byte[] { 1,0,1,0,1,0 },
                CollisionShape = 649,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9357,
                Properties = new byte[] { 1,0,1,0,1,1 },
                CollisionShape = 650,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9358,
                Properties = new byte[] { 1,0,1,1,0,0 },
                CollisionShape = 651,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9359,
                Properties = new byte[] { 1,0,1,1,0,1 },
                CollisionShape = 652,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9360,
                Properties = new byte[] { 1,0,1,1,1,0 },
                CollisionShape = 653,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9361,
                Properties = new byte[] { 1,0,1,1,1,1 },
                CollisionShape = 654,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9362,
                Properties = new byte[] { 1,1,0,0,0,0 },
                CollisionShape = 655,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9363,
                Properties = new byte[] { 1,1,0,0,0,1 },
                CollisionShape = 656,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9364,
                Properties = new byte[] { 1,1,0,0,1,0 },
                CollisionShape = 657,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9365,
                Properties = new byte[] { 1,1,0,0,1,1 },
                CollisionShape = 658,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9366,
                Properties = new byte[] { 1,1,0,1,0,0 },
                CollisionShape = 659,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9367,
                Properties = new byte[] { 1,1,0,1,0,1 },
                CollisionShape = 660,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9368,
                Properties = new byte[] { 1,1,0,1,1,0 },
                CollisionShape = 661,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9369,
                Properties = new byte[] { 1,1,0,1,1,1 },
                CollisionShape = 662,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9370,
                Properties = new byte[] { 1,1,1,0,0,0 },
                CollisionShape = 663,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9371,
                Properties = new byte[] { 1,1,1,0,0,1 },
                CollisionShape = 664,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9372,
                Properties = new byte[] { 1,1,1,0,1,0 },
                CollisionShape = 665,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9373,
                Properties = new byte[] { 1,1,1,0,1,1 },
                CollisionShape = 666,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9374,
                Properties = new byte[] { 1,1,1,1,0,0 },
                CollisionShape = 667,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9375,
                Properties = new byte[] { 1,1,1,1,0,1 },
                CollisionShape = 668,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9376,
                Properties = new byte[] { 1,1,1,1,1,0 },
                CollisionShape = 669,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9377,
                Properties = new byte[] { 1,1,1,1,1,1 },
                CollisionShape = 670,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            }
        };
    }
}
