using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Actions : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play("Idle");
    }

    // Update is called once per frame
    void Update()
    {
        //animations
        if (Input.GetKeyDown(KeyCode.M))
        {
            anim.SetTrigger("Block");
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            anim.SetTrigger("Duck");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            anim.SetTrigger("RightKick");
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetTrigger("LeftBox");
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            anim.SetTrigger("LeftKick");
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.SetTrigger("RightBox");
        }

    }
}
