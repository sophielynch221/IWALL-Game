using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public enum type { yellow, red, orange, blue};

    public ParticleSystem boxParticles;
    public type colour;

    private void Update()
    {
        if(colour == type.yellow)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                Instantiate(boxParticles, transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }

        if (colour == type.red)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                Instantiate(boxParticles, transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }

        if (colour == type.blue)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                Instantiate(boxParticles, transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }

        if (colour == type.orange)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                Instantiate(boxParticles, transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }


    }

}
