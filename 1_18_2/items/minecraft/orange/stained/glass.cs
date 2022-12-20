using System.Collections.Generic;
namespace MinecraftData._1_18_2.items.minecraft
{
    [Item(ItemNameID.orange_stained_glass)]
    public class orange_stained_glass : IBaseItem, IHasCategory, ICanPlaceBlock
    {
        public short id => 401;
        public Rarity rarity => Rarity.common;
        public byte max_stack_size => 64;
        public short max_damage => 0;
        public bool is_fire_resistant => false;
        public string translation_key => "block.minecraft.orange_stained_glass";
        public ItemClasses @class => ItemClasses.BlockItem;

        public byte category => 0;

        public BlockNameID block => BlockNameID.orange_stained_glass;
    }
}
