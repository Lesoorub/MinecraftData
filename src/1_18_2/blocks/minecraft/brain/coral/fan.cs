using System.Collections.Generic;
namespace MinecraftData._1_18_2.blocks.minecraft
{
    [Block(BlockNameID.brain_coral_fan)]
    public class brain_coral_fan : IBlockData
    {
        public short DefaultStateID => 9802;
        public state DefaultState => States[0];
        public float Hardness => 0f;
        public float ExplosionResistance => 0f;
        public bool IsTransparent => true;
        public byte SoundGroup => 15;
        public short DroppedItem => 538;
        public MinecraftMaterial Material => MinecraftMaterial.underwater_plant;
        public Dictionary<string, List<string>> Properties => new Dictionary<string, List<string>>()
        {
            { "waterlogged", new List<string>() { "True", "False" } }
        };
        public state[] States => new state[]
        {
            new state
            {
                Id = 9802,
                Properties = new byte[] { 0 },
                CollisionShape = null,
                Luminance = 0,
                LightCost = 1,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 9803,
                Properties = new byte[] { 1 },
                CollisionShape = null,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            }
        };
    }
}
