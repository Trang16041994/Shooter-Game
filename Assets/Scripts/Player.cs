using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform point;
    public GameObject bullet;
    

    void Start()
    {

    }
    public void Update()
    {
        Shoot();
    }
    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(bullet, point.position, point.rotation);
        }

    }
    public void Move()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {

        }
    }

}

