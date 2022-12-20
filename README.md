# MinecraftData

Only for Minecraft: Java Edition.
At the moment, the project supports blocks and items only for version 1.18.2. Code generators located in the `CodeGenerators` folder are used to generate information. 
All data for the project was taken from [pixlyzer-data](https://gitlab.com/Bixilon/pixlyzer-data/-/tree/master/version/1.18.2).

To simplify access to the elements, partial partitioning into subdirectories was used. Instead of the `_` sign, the creation of a subdirectory was used.

# Dependencies Hell
Diagram getted by [Dependencies Viewer](https://github.com/Lesoorub/DependenciesViewer).
[](./images/all_dependencies.svg)

# Blocks

Each block inherits from a common interface - IBlockData.

## Block interface

```cs
public interface IBlockData
{
    short DefaultStateID { get; }
    state DefaultState { get; }
    float Hardness { get; }
    float ExplosionResistance { get; }
    bool IsTransparent { get; }
    MinecraftMaterial Material { get; }
    byte SoundGroup { get; }
    short DroppedItem { get; }
    Dictionary<string, List<string>> Properties { get; }
    state[] States { get; }
}
```

## Example block

```cs
[Block(BlockNameID.diamond_block)]
public class diamond_block : IBlockData
{
    public short DefaultStateID => 3412;
    public state DefaultState => States[0];
    public float Hardness => 5f;
    public float ExplosionResistance => 6f;
    public bool IsTransparent => false;
    public byte SoundGroup => 5;
    public short DroppedItem => 68;
    public MinecraftMaterial Material => MinecraftMaterial.metal;
    public Dictionary<string, List<string>> Properties => new Dictionary<string, List<string>>()
    {
        
    };
    public state[] States => new state[]
    {
        new state
        {
            Id = 3412,
            Properties = new byte[] {  },
            CollisionShape = 0,
            LightCost = 15,
            HasSideTransparency = false,
        }
    };
}
```
# Items
 Each item is described by several interfaces:
 - IArmor
 - IAxe
 - IBaseItem
 - IBucket
 - ICanPlaceBlock
 - IDye
 - IFood
 - IHasCategory
 - IHorseArmor
 - IHovel
 - IIsComplex
 - IMusicDisk
 - ISpawnEgg
 - ITool

## Item interfaces

```cs
public interface IArmor
{
    equipment_slot equipment_slot { get; }
    byte defense { get; }
    float toughness { get; }
    armor_material armor_material { get; }
    float knockback_resistance { get; }
}
```
```cs
public interface IAxe
{
    Dictionary<short, short> strippables_blocks { get; }
}
```
```cs
public interface IBaseItem
{
    short id { get; }
    Rarity rarity { get; }
    byte max_stack_size { get; }
    short max_damage { get; }
    bool is_fire_resistant { get; }
    string translation_key { get; }
    ItemClasses @class { get; }
}
```
```cs
public interface IBucket
{
    byte bucked_fluid_type { get; } // [0, 2, 4]. 0 - empty, 2 - water, 4 - lava
}
```
```cs
public interface ICanPlaceBlock
{
    BlockNameID block { get; }
}
```
```cs
public interface IDye
{
    string dye_color { get; }
}
```
```cs
public interface IFood
{
    food_properties food_properties { get; }
}
```
```cs
public interface IHasCategory
{
    byte category { get; }
}
```
```cs
public interface IHorseArmor
{
    byte horse_protection { get; } //[3, 5, 7, 11]. 3 - leather, ..., 11 - diamond
    string horse_texture { get; }
}
```
```cs
public interface IHovel
{
    Dictionary<short, short> flattenables_block_states { get; }
}
```
```cs
public interface IIsComplex
{
    bool is_complex { get; } //true only for maps
}
```
```cs
public interface IMusicDisk
{
    byte analog_output { get; } //[0, 1, ... , 13]
    short sound { get; }
}
```
```cs
public interface ISpawnEgg
{
    int spawn_egg_color_1 { get; }
    int spawn_egg_color_2 { get; }
    byte spawn_egg_entity_type { get; }
}
```
```cs
public interface ITool
{
    short uses { get; }
    float speed { get; } //Only tools and swords. Mine speed
    float attack_damage_bonus { get; } //Only tools and swords
    byte level { get; } //Tool level. 0 for wooden and golden, 4 for netherite
    byte enchantment_value { get; } //Only tools and swords. Enchant power. min 0, max 22
    float attack_damage { get; } //Only tools and swords
}
```