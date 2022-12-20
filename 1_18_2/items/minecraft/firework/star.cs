using System.Collections.Generic;
namespace MinecraftData._1_18_2.items.minecraft
{
    [Item(ItemNameID.firework_star)]
    public class firework_star : IBaseItem, IHasCategory
    {
        public short id => 962;
        public Rarity rarity => Rarity.common;
        public byte max_stack_size => 64;
        public short max_damage => 0;
        public bool is_fire_resistant => false;
        public string translation_key => "item.minecraft.firework_star";
        public ItemClasses @class => ItemClasses.FireworkStarItem;

        public byte category => 6;
    }
}
