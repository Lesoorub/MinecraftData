using System.Collections.Generic;
namespace MinecraftData._1_18_2.items.minecraft
{
    [Item(ItemNameID.flowering_azalea_leaves)]
    public class flowering_azalea_leaves : IBaseItem, IHasCategory, ICanPlaceBlock
    {
        public short id => 140;
        public Rarity rarity => Rarity.common;
        public byte max_stack_size => 64;
        public short max_damage => 0;
        public bool is_fire_resistant => false;
        public string translation_key => "block.minecraft.flowering_azalea_leaves";
        public ItemClasses @class => ItemClasses.BlockItem;

        public byte category => 1;

        public BlockNameID block => BlockNameID.flowering_azalea_leaves;
    }
}
