using System.Collections.Generic;
namespace MinecraftData._1_18_2.items.minecraft
{
    [Item(ItemNameID.powder_snow_bucket)]
    public class powder_snow_bucket : IBaseItem, IHasCategory, ICanPlaceBlock
    {
        public short id => 779;
        public Rarity rarity => Rarity.common;
        public byte max_stack_size => 1;
        public short max_damage => 0;
        public bool is_fire_resistant => false;
        public string translation_key => "item.minecraft.powder_snow_bucket";
        public ItemClasses @class => ItemClasses.PowderSnowBucketItem;

        public byte category => 6;

        public BlockNameID block => BlockNameID.powder_snow;
    }
}
