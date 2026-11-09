using UnityEngine;

public class WeaponData : ScriptableObject
{
    public string weaponName;
    public Sprite icon;
    public GameObject prefab;

    public float damage = 10f;
    public float attackSpeed = 1f;
    public float attackRange = 1f;
    [Range(0, 1)] public float critChance = 0.1f;
    public float critDamage = 15f;
    public int maxDurability = 50;

    public float Cooldown => 1f / attackSpeed;
}

[CreateAssetMenu(menuName = "Items/Melee Weapon")]
public class MeleeWeaponData : WeaponData { }

[CreateAssetMenu(menuName = "Items/Ranged Weapon")]
public class RangedWeaponData : WeaponData {
    public float projectileSpeed = 10f;
    public GameObject projectilePrefab;
}  
