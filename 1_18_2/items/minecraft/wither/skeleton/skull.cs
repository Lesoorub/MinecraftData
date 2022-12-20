using System.Collections.Generic;
namespace MinecraftData._1_18_2.items.minecraft
{
    [Item(ItemNameID.wither_skeleton_skull)]
    public class wither_skeleton_skull : IBaseItem, IHasCategory, ICanPlaceBlock
    {
        public short id => 954;
        public Rarity rarity => Rarity.uncommon;
        public byte max_stack_size => 64;
        public short max_damage => 0;
        public bool is_fire_resistant => false;
        public string translation_key => "block.minecraft.wither_skeleton_skull";
        public ItemClasses @class => ItemClasses.WallStandingBlockItem;

        public byte category => 1;

        public BlockNameID block => BlockNameID.wither_skeleton_skull;
    }
}
