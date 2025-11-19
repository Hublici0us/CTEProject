using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ShootingWeapons : MonoBehaviour
{
    public Sprite image;
    public GameObject weaponProjectile;
    public int usesLeft;
    public GameObject pointer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShootProjectile(GameObject pointer)
    {
        Instantiate(weaponProjectile, transform.position, pointer.transform.localRotation);
        usesLeft--;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("object");

        if (collision.TryGetComponent<CollectScript>(out CollectScript weapon))
        {
            Debug.Log("weapon");
            image = weapon.image;
            usesLeft = weapon.uses;
            weaponProjectile = weapon.projectile;
            pointer.GetComponent<SpriteRenderer>().sprite = image;
            Destroy(collision.gameObject);
            

        }
    }
}
