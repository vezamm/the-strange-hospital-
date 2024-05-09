using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimation : MonoBehaviour
{
    public Animator animator;
    public bool opened;
    //public AudioSource open;

    void Start()
    {
        opened = animator.GetBool("open");

    }

    private void FixedUpdate()
    {
        opened = animator.GetBool("open");
    }

    public void Open()
    {
        if (!opened)
        {
            animator.SetBool("open", true);
            //if (open != null && !open.isPlaying)
            //{
            //    open.Play();
            //}
        }
        else
        {
            animator.SetBool("open", false);
        }
    }
}

