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
    
    private void OnMove(InputValue i)
    {
        direction = i.Get<Vector2>();
    }

    private void OnAim(InputValue i)
    {
        Vector2 dest = i.Get<Vector2>();
        if (dest != Vector2.zero)
        {
            Debug.Log("x = " + dest.x + " y = " + dest.y);
            Debug.Log("Atan = " + Mathf.Atan(dest.y / dest.x) + " Degrees = " + Mathf.Atan(dest.y / dest.x) * Mathf.Rad2Deg);

            if (dest.x < 0)
            {
                pointer.transform.eulerAngles = new Vector3(0, 0, Mathf.Atan(dest.y / dest.x) * Mathf.Rad2Deg * Mathf.Sign(-dest.y));

            }
            else
            {
                pointer.transform.eulerAngles = new Vector3(0, 0, Mathf.Atan(dest.y / dest.x) * Mathf.Rad2Deg);

            }

        }

    }

    private void Update()
    {
        rb.velocity = direction * speed;
    }
}
