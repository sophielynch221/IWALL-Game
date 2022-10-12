using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Target>().Work();
    }
}
