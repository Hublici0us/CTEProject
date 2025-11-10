using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ShootingWeapons : MonoBehaviour
{
    public Sprite image;
    public CollectScript weaponEquipped;
    public GameObject weaponProjectile;
    public int usesLeft;
    public double rarity;
    public GameObject pointer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while (weaponEquipped != null)
        {
            image = weaponEquipped.image;
            weaponProjectile = weaponEquipped.projectile;
        }
    }

    public void ShootProjectile(GameObject pointer)
    {
        Instantiate(weaponProjectile, transform.position, pointer.transform.localRotation);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (TryGetComponent(out CollectScript weapon))
        {
            if (weapon != null)
            {
                weaponEquipped = weapon;
            }

        }
    }
}
