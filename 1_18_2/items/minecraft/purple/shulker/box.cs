using System.Collections.Generic;
namespace MinecraftData._1_18_2.items.minecraft
{
    [Item(ItemNameID.purple_shulker_box)]
    public class purple_shulker_box : IBaseItem, IHasCategory, ICanPlaceBlock
    {
        public short id => 462;
        public Rarity rarity => Rarity.common;
        public byte max_stack_size => 1;
        public short max_damage => 0;
        public bool is_fire_resistant => false;
        public string translation_key => "block.minecraft.purple_shulker_box";
        public ItemClasses @class => ItemClasses.BlockItem;

        public byte category => 1;

        public BlockNameID block => BlockNameID.purple_shulker_box;
    }
}
