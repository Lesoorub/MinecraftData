using System.Collections.Generic;
namespace MinecraftData._1_18_2.items.minecraft
{
    [Item(ItemNameID.potato)]
    public class potato : IBaseItem, IHasCategory, IFood, ICanPlaceBlock
    {
        public short id => 948;
        public Rarity rarity => Rarity.common;
        public byte max_stack_size => 64;
        public short max_damage => 0;
        public bool is_fire_resistant => false;
        public string translation_key => "item.minecraft.potato";
        public ItemClasses @class => ItemClasses.AliasedBlockItem;

        public byte category => 7;

        public food_properties food_properties => new food_properties()
        {
            nutrition = 1,
            saturation_modifier = 0.3f,
            is_meat = false,
            can_always_eat = false,
            fast_food = false
        };

        public BlockNameID block => BlockNameID.potatoes;
    }
}
