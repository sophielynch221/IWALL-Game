using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Player1Actions : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.E))
        {
            anim.SetTrigger("Block");
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            anim.SetTrigger("Duck");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetTrigger("RightKick");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetTrigger("LeftBox");
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetTrigger("LeftKick");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetTrigger("RightBox");
        }

    }

    //Animations
    public void rightKick()
    {
        anim.SetTrigger("RightKick");
    }

    public void LeftHit()
    {
        anim.SetTrigger("LeftBox");
    }

    public void RightHit()
    {
        anim.SetTrigger("RightBox");
    }

    public void LeftKick()
    {
        anim.SetTrigger("LeftKick");
    }

}
