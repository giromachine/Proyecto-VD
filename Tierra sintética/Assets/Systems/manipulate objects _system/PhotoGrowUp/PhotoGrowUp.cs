using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoGrowUp : MonoBehaviour
{
    public Animator anim;
    public bool growUp;

    public void Grow()
    {
        if (growUp)
        {
            anim.SetTrigger("Decrease");
            growUp = false;
        }
        else
        {
            anim.SetTrigger("Grow");            
            growUp = true;
        }
    }
}
