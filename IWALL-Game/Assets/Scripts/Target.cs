using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public ParticleSystem boxParticles;

    private void Update()
    {
        
    }

    public void Work()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Instantiate(boxParticles, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Instantiate(boxParticles, transform.position, transform.rotation);
            Destroy(gameObject);
        }

    }*/

}
