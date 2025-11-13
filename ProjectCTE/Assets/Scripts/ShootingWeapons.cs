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
        Debug.Log("object");

        if (collision.TryGetComponent<CollectScript>(out CollectScript weapon))
        {
            Debug.Log("weapon");
            if (weaponEquipped == null)
            {
                weaponEquipped = weapon;
                Destroy(collision.gameObject);
            }

        }
    }
}
