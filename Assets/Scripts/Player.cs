using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 2.0f;
    public Weapon[] weapons;
    
    void Update()
    {
        //Vector3 velocity = Vector3.zero;

        //velocity.x = Input.GetAxis("Horizontal");
        //velocity.z = Input.GetAxis("Vertical");

        //if (Input.GetButtonDown("Jump")) velocity.y = 50;

        //transform.position += velocity * speed * Time.deltaTime;

        if (Input.GetButton("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            weapons[0].Fire(ray.origin, ray.direction);
        }
    }
}
