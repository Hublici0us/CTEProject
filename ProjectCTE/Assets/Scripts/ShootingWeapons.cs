using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootingWeapons : MonoBehaviour
{
    public Image image;
    public GameObject projectile;
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
        
    }

    public void ShootProjectile(GameObject pointer)
    {
        Instantiate(projectile, transform.position, pointer.transform.localRotation);
    }
}
