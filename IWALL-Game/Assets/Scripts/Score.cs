using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] GameObject scorescript;

    // Start is called before the first frame update
    void Start()
    {
        scorescript.GetComponent<ChangeScene>().score++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
