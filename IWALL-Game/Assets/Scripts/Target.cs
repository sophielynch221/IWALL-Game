using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Target : MonoBehaviour
{
    public enum type { yellow, red, orange, blue};  //for cubes 

    public ParticleSystem boxParticles;
    public type colour;  //enum group name

    public void GotCube()  //destroys cube
    {
        Instantiate(boxParticles, transform.position, transform.rotation);
        Destroy(gameObject);
    }
    public float triggerscore;
    private GameObject forscript;

    private void Start()
    {
        forscript = GameObject.Find("ForScripts");
        triggerscore = 0;
    }

    private void Update()
    {
        if(colour == type.yellow)  // have to press w to destroy yellow cubes
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                Instantiate(boxParticles, transform.position, transform.rotation);
                Destroy(gameObject);

                if (triggerscore == 0) {forscript.GetComponent<ChangeScene>().score = forscript.GetComponent<ChangeScene>().score + 10;}
                if (triggerscore == 1) {forscript.GetComponent<ChangeScene>().score = forscript.GetComponent<ChangeScene>().score + 50;}
                if (triggerscore == 2) {forscript.GetComponent<ChangeScene>().score = forscript.GetComponent<ChangeScene>().score + 10;}
            }
        }

        if (colour == type.red)  // have to press a to destroy red cubes
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                Instantiate(boxParticles, transform.position, transform.rotation);
                Destroy(gameObject);

                if (triggerscore == 0) { forscript.GetComponent<ChangeScene>().score = forscript.GetComponent<ChangeScene>().score + 10; }
                if (triggerscore == 1) { forscript.GetComponent<ChangeScene>().score = forscript.GetComponent<ChangeScene>().score + 50; }
                if (triggerscore == 2) { forscript.GetComponent<ChangeScene>().score = forscript.GetComponent<ChangeScene>().score + 10; }
            }
        }

        if (colour == type.blue)  // have to press s to destroy blue cubes
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                Instantiate(boxParticles, transform.position, transform.rotation);
                Destroy(gameObject);

                if (triggerscore == 0) { forscript.GetComponent<ChangeScene>().score = forscript.GetComponent<ChangeScene>().score + 10; }
                if (triggerscore == 1) { forscript.GetComponent<ChangeScene>().score = forscript.GetComponent<ChangeScene>().score + 50; }
                if (triggerscore == 2) { forscript.GetComponent<ChangeScene>().score = forscript.GetComponent<ChangeScene>().score + 10; }
            }
        }

        if (colour == type.orange)  // have to press d to destroy orange cubes
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                Instantiate(boxParticles, transform.position, transform.rotation);
                Destroy(gameObject);

                if (triggerscore == 0) { forscript.GetComponent<ChangeScene>().score = forscript.GetComponent<ChangeScene>().score + 10; }
                if (triggerscore == 1) { forscript.GetComponent<ChangeScene>().score = forscript.GetComponent<ChangeScene>().score + 50; }
                if (triggerscore == 2) { forscript.GetComponent<ChangeScene>().score = forscript.GetComponent<ChangeScene>().score + 10; }
            }
        }


    }

}
