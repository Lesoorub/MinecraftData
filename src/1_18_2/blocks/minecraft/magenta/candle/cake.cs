using System.Collections.Generic;
namespace MinecraftData._1_18_2.blocks.minecraft
{
    [Block(BlockNameID.magenta_candle_cake)]
    public class magenta_candle_cake : IBlockData
    {
        public short DefaultStateID => 17637;
        public state DefaultState => States[1];
        public float Hardness => 0.5f;
        public float ExplosionResistance => 0.5f;
        public bool IsTransparent => false;
        public byte SoundGroup => 7;
        public short DroppedItem => 0;
        public MinecraftMaterial Material => MinecraftMaterial.cake;
        public Dictionary<string, List<string>> Properties => new Dictionary<string, List<string>>()
        {
            { "lit", new List<string>() { "True", "False" } }
        };
        public state[] States => new state[]
        {
            new state
            {
                Id = 17636,
                Properties = new byte[] { 0 },
                CollisionShape = 740,
                Luminance = 3,
                LightCost = 0,
                HasSideTransparency = false,
            },
            new state
            {
                Id = 17637,
                Properties = new byte[] { 1 },
                CollisionShape = 740,
                Luminance = 0,
                LightCost = 0,
                HasSideTransparency = false,
            }
        };
    }
}
