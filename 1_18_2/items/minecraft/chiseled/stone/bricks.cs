using System.Collections.Generic;
namespace MinecraftData._1_18_2.items.minecraft
{
    [Item(ItemNameID.chiseled_stone_bricks)]
    public class chiseled_stone_bricks : IBaseItem, IHasCategory, ICanPlaceBlock
    {
        public short id => 286;
        public Rarity rarity => Rarity.common;
        public byte max_stack_size => 64;
        public short max_damage => 0;
        public bool is_fire_resistant => false;
        public string translation_key => "block.minecraft.chiseled_stone_bricks";
        public ItemClasses @class => ItemClasses.BlockItem;

        public byte category => 0;

        public BlockNameID block => BlockNameID.chiseled_stone_bricks;
    }
}
