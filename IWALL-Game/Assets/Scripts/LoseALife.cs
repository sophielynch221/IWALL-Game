using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseALife : MonoBehaviour
{
    float lives = 3;
    [SerializeField] Text livestext;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        livestext.text = lives.ToString();
        if(lives == 0)
        {
            Debug.Log("Game Over");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("block"))
        {
            lives = lives - 1;
        }
    }
}
