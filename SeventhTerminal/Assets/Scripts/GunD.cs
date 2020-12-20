using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunD : MonoBehaviour
{

    private GameObject Target;
    private bool SeeTarget;
    public GameObject Bspawner;
    public GameObject Projectile;
    public string TargetString;
    public float FireRate;
    private float LastShot;
      
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }

        
    }

    // fire the weapon at specific intervals 
    void Fire()
    {
        if(Time.time > FireRate + LastShot)
        {
            Instantiate(Projectile, Bspawner.transform.position, Bspawner.transform.rotation);
            LastShot = Time.time;

        }
    }

}
