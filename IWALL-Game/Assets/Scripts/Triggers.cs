using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Triggers : MonoBehaviour
{
    public enum timing { TooEarly, Perfect, TooLate};
    public UnityEvent addtoscore;
    public timing timingscore;

    public bool tooearly;
    public bool toolate;
    public bool perfect;

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Target>().enabled = true;
        if(other.GetComponent<Target>().hit == true) { addtoscore.Invoke(); }
    }

    private void Start()
    {
        if(timingscore == timing.TooEarly)
        {
            tooearly = true;
            toolate = false;
            perfect = false;
        }

        if (timingscore == timing.TooLate)
        {
            tooearly = false;
            toolate = true;
            perfect = false;
        }

        if (timingscore == timing.Perfect)
        {
            tooearly = false;
            toolate = false;
            perfect = true;
        }

    }

}
