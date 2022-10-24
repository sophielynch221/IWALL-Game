using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Triggers : MonoBehaviour
{
    public UnityEvent addtoscore;


    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Target>().enabled = true;
        
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<Target>().triggerscore++;
    }

    private void Start()
    {

    }

}
