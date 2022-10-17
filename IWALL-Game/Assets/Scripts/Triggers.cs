using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers : MonoBehaviour
{
    public enum timing { TooEarly, Perfect, TooLate, LoseALife};

    public timing timingscore;

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Target>().enabled = true;

        
    }
}
