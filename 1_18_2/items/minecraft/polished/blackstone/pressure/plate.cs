using System.Collections.Generic;
namespace MinecraftData._1_18_2.items.minecraft
{
    [Item(ItemNameID.polished_blackstone_pressure_plate)]
    public class polished_blackstone_pressure_plate : IBaseItem, IHasCategory, ICanPlaceBlock
    {
        public short id => 620;
        public Rarity rarity => Rarity.common;
        public byte max_stack_size => 64;
        public short max_damage => 0;
        public bool is_fire_resistant => false;
        public string translation_key => "block.minecraft.polished_blackstone_pressure_plate";
        public ItemClasses @class => ItemClasses.BlockItem;

        public byte category => 2;

        public BlockNameID block => BlockNameID.polished_blackstone_pressure_plate;
    }
}