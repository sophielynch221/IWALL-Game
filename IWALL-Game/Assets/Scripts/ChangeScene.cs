using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] Text scoretext;
    public float score;
    public float startcount = 10f;
    public float currentcount;

    public UnityEvent disappear;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //changes the score as the person hits the cubes
        scoretext.text = score.ToString();

        //quit game
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    //to quit the game
    public void QuitGame()
    {
        Application.Quit();
    }

    //go to single player
    public void Singleplayer()
    {
        SceneManager.LoadScene("SinglePlayer");
    }

    //go to multiplayer
    public void multiplayer()
    {
        SceneManager.LoadScene("2player");
    }

    public void ResetScore()
    {
        score = 0;
    }

    public void StopShowingInstruction()
    {
        currentcount = startcount;
        currentcount -= Time.deltaTime * 1;
        if (currentcount <= 0) { disappear.Invoke(); }
    }
}
