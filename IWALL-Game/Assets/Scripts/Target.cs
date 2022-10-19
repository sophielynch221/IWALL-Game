using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Target : MonoBehaviour
{
    public enum type { yellow, red, orange, blue};  //for cubes 

    [SerializeField] UnityEvent add10toscore;
    [SerializeField] UnityEvent add50toscore;
    [SerializeField] UnityEvent Losealife;

    public ParticleSystem boxParticles;
    public type colour;  //enum group name

    public void GotCube()  //destroys cube
    {
        Instantiate(boxParticles, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    public bool hit;

    private void Start()
    {
        hit = false;
    }

    private void Update()
    {
        if(colour == type.yellow)  // have to press w to destroy yellow cubes
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                Instantiate(boxParticles, transform.position, transform.rotation);
                Destroy(gameObject);
                hit = true;


                /*/if it hits the first trigger the player gets ten points because they were too early
                  if(triggercollider.GetComponent<Triggers>().timingscore == Triggers.timing.TooEarly)
                  {
                      add10toscore.Invoke();
                      Debug.Log("Too early");
                      
                  }
                   
                  // if it hits the second trigger the player gets fifty points because they were perfect
                  if (triggercollider.GetComponent<Triggers>().timingscore == Triggers.timing.Perfect)
                  {
                      add50toscore.Invoke();
                      Debug.Log("Perfect, well done");
                   
                  } 
                   
                  // if it hits the third trigger the player gets ten points because they were too late
                  if (triggercollider.GetComponent<Triggers>().timingscore == Triggers.timing.TooLate)
                  {
                      add10toscore.Invoke();
                      Debug.Log("Too Late");
                  
                  } 
                  
                  // if it hits the last trigger the player loses a life
                  if (triggercollider.GetComponent<Triggers>().timingscore == Triggers.timing.LoseALife)
                  {
                     Losealife.Invoke();
                     Debug.Log("Hard luck, maybe next time");
                  }
                  */
            }
        }

        if (colour == type.red)  // have to press a to destroy red cubes
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                Instantiate(boxParticles, transform.position, transform.rotation);
                Destroy(gameObject);
                hit = true;

                /*/if it hits the first trigger the player gets ten points because they were too early
                if (triggercollider.GetComponent<Triggers>().timingscore == Triggers.timing.TooEarly)
                {
                    add10toscore.Invoke();
                    Debug.Log("Too early");

                }

                // if it hits the second trigger the player gets fifty points because they were perfect
                if (triggercollider.GetComponent<Triggers>().timingscore == Triggers.timing.Perfect)
                {
                    add50toscore.Invoke();
                    Debug.Log("Perfect, well done");

                }

                // if it hits the third trigger the player gets ten points because they were too late
                if (triggercollider.GetComponent<Triggers>().timingscore == Triggers.timing.TooLate)
                {
                    add10toscore.Invoke();
                    Debug.Log("Too Late");

                }

                // if it hits the last trigger the player loses a life
                if (triggercollider.GetComponent<Triggers>().timingscore == Triggers.timing.LoseALife)
                {
                    Losealife.Invoke();
                    Debug.Log("Hard luck, maybe next time");
                }
                */

            }
        }

        if (colour == type.blue)  // have to press s to destroy blue cubes
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                Instantiate(boxParticles, transform.position, transform.rotation);
                Destroy(gameObject);
                hit = true;

                /*/if it hits the first trigger the player gets ten points because they were too early
                if (triggercollider.GetComponent<Triggers>().timingscore == Triggers.timing.TooEarly)
                {
                    add10toscore.Invoke();
                    Debug.Log("Too early");

                }

                // if it hits the second trigger the player gets fifty points because they were perfect
                if (triggercollider.GetComponent<Triggers>().timingscore == Triggers.timing.Perfect)
                {
                    add50toscore.Invoke();
                    Debug.Log("Perfect, well done");

                }

                // if it hits the third trigger the player gets ten points because they were too late
                if (triggercollider.GetComponent<Triggers>().timingscore == Triggers.timing.TooLate)
                {
                    add10toscore.Invoke();
                    Debug.Log("Too Late");

                }

                // if it hits the last trigger the player loses a life
                if (triggercollider.GetComponent<Triggers>().timingscore == Triggers.timing.LoseALife)
                {
                    Losealife.Invoke();
                    Debug.Log("Hard luck, maybe next time");
                }*/

            }
        }

        if (colour == type.orange)  // have to press d to destroy orange cubes
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                Instantiate(boxParticles, transform.position, transform.rotation);
                Destroy(gameObject);
                hit = true;

                /*/if it hits the first trigger the player gets ten points because they were too early
                if (triggercollider.GetComponent<Triggers>().timingscore == Triggers.timing.TooEarly)
                {
                    add10toscore.Invoke();
                    Debug.Log("Too early");

                }

                // if it hits the second trigger the player gets fifty points because they were perfect
                if (triggercollider.GetComponent<Triggers>().timingscore == Triggers.timing.Perfect)
                {
                    add50toscore.Invoke();
                    Debug.Log("Perfect, well done");

                }

                // if it hits the third trigger the player gets ten points because they were too late
                if (triggercollider.GetComponent<Triggers>().timingscore == Triggers.timing.TooLate)
                {
                    add10toscore.Invoke();
                    Debug.Log("Too Late");

                }

                // if it hits the last trigger the player loses a life
                if (triggercollider.GetComponent<Triggers>().timingscore == Triggers.timing.LoseALife)
                {
                    Losealife.Invoke();
                    Debug.Log("Hard luck, maybe next time");
                }*/

            }
        }


    }

}
