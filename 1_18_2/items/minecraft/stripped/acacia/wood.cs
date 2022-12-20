using System.Collections.Generic;
namespace MinecraftData._1_18_2.items.minecraft
{
    [Item(ItemNameID.stripped_acacia_wood)]
    public class stripped_acacia_wood : IBaseItem, IHasCategory, ICanPlaceBlock
    {
        public short id => 121;
        public Rarity rarity => Rarity.common;
        public byte max_stack_size => 64;
        public short max_damage => 0;
        public bool is_fire_resistant => false;
        public string translation_key => "block.minecraft.stripped_acacia_wood";
        public ItemClasses @class => ItemClasses.BlockItem;

        public byte category => 0;

        public BlockNameID block => BlockNameID.stripped_acacia_wood;
    }
}
