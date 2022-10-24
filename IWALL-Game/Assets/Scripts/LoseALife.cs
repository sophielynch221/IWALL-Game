using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class LoseALife : MonoBehaviour
{
    float lives = 3;
    [SerializeField] Text livestext;
    public UnityEvent youlose;

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
            youlose.Invoke();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("block"))
        {
            lives = lives - 1;
        }
    }

    public void ResetLives()
    {
        lives = 3;
    }
}
