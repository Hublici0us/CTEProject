using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu]
public class WeaponData : ScriptableObject
{
    public float fireRate;
    public int uses;
    public Image image;
    public GameObject projectile;
}
