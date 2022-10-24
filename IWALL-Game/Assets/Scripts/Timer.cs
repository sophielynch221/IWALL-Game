using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{

    float startingtime = 60f;
    float currenttime;
    public UnityEvent gameOver;

    [SerializeField] Text timertext;

    // Start is called before the first frame update
    void Start()
    {
        currenttime = startingtime;
    }

    // Update is called once per frame
    void Update()
    {
        currenttime -=1 * Time.deltaTime;
        timertext.text = currenttime.ToString("0.00");

        if (currenttime <= 20) { timertext.color = Color.yellow;}
        if (currenttime <= 10) { timertext.color = Color.red;}

        if(currenttime <= 0) { currenttime = 0; gameOver.Invoke(); }
    }

    public void restartGame()
    {
        currenttime = startingtime;
        Time.timeScale = 1f;
    }

    public void stopTimer()
    {
        Time.timeScale = 0f;
    }
}
