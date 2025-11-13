using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    private Vector2 direction;
    public float speed;
    public GameObject pointer;
    public bool hasGun = true;
    [SerializeField] ShootingWeapons gun;

    private void OnMove(InputValue i)
    {
        direction = i.Get<Vector2>();
    }

    private void OnAim(InputValue i)
    {
        Vector2 dest = i.Get<Vector2>();
        if (dest != Vector2.zero)
        {

            
            pointer.transform.eulerAngles = new Vector3(0, 0, Mathf.Atan2(dest.y, dest.x) * Mathf.Rad2Deg);

            

        }

    }

    private void OnFire(InputValue i)
    {
        if (gun.weaponEquipped != null)
        {
            {
                gun.ShootProjectile(pointer);
            }


        }
    }

    private void Update()
    {
        rb.velocity = direction * speed;

       
    }
}
