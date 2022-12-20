using System.Collections.Generic;
namespace MinecraftData._1_18_2.items.minecraft
{
    [Item(ItemNameID.purple_glazed_terracotta)]
    public class purple_glazed_terracotta : IBaseItem, IHasCategory, ICanPlaceBlock
    {
        public short id => 478;
        public Rarity rarity => Rarity.common;
        public byte max_stack_size => 64;
        public short max_damage => 0;
        public bool is_fire_resistant => false;
        public string translation_key => "block.minecraft.purple_glazed_terracotta";
        public ItemClasses @class => ItemClasses.BlockItem;

        public byte category => 1;

        public BlockNameID block => BlockNameID.purple_glazed_terracotta;
    }
}
