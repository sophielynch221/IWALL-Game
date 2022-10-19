using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] Text scoretext;
    public float score;
    public float lives;

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

    //hits the early trigger
    public void TooEarly()
    {
        score = score + 10;
        Debug.Log("Too Early");
    }

    //perfectly hits the trigger
    public void Perfect()
    {
        score = score + 50;
        Debug.Log("Perfect");
    }

    //hits the late trigger
    public void Losealife()
    {
        score = score + 10;
        Debug.Log("Too late");
    }

}
