using System.Collections.Generic;
namespace MinecraftData._1_18_2.items.minecraft
{
    [Item(ItemNameID.stone_sword)]
    public class stone_sword : IBaseItem, IHasCategory, ITool
    {
        public short id => 704;
        public Rarity rarity => Rarity.common;
        public byte max_stack_size => 1;
        public short max_damage => 131;
        public bool is_fire_resistant => false;
        public string translation_key => "item.minecraft.stone_sword";
        public ItemClasses @class => ItemClasses.SwordItem;

        public byte category => 9;

        public short uses => 131;
        public float speed => 4f;
        public float attack_damage_bonus => 1f;
        public byte level => 1;
        public byte enchantment_value => 5;
        public float attack_damage => 4f;
    }
}
