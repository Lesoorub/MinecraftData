using System.Collections.Generic;
namespace MinecraftData._1_18_2.blocks.minecraft
{
    [Block(BlockNameID.tube_coral_fan)]
    public class tube_coral_fan : IBlockData
    {
        public short DefaultStateID => 9800;
        public state DefaultState => States[0];
        public float Hardness => 0f;
        public float ExplosionResistance => 0f;
        public bool IsTransparent => true;
        public byte SoundGroup => 15;
        public short DroppedItem => 537;
        public MinecraftMaterial Material => MinecraftMaterial.underwater_plant;
        public Dictionary<string, List<string>> Properties => new Dictionary<string, List<string>>()
        {
            { "waterlogged", new List<string>() { "True", "False" } }
        };
        public state[] States => new state[]
        {
            new state
            {
                Id = 9800,
                Properties = new byte[] { 0 },
                CollisionShape = null,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9801,
                Properties = new byte[] { 1 },
                CollisionShape = null,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            }
        };
    }
}
