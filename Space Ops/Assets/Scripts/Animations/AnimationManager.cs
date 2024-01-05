using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    [SerializeField] Animator animator;
    public bool compartmentAlreadyClosed = false;

    public void CompartmentOpen()
    {
        animator.SetBool("opening", true);        
        compartmentAlreadyClosed = false;
    }

    public void CompartmentClose()
    {        
        animator.SetBool("opening", false);
        animator.SetBool("closing", true);
    }

    
    public void ResetAnimatorParameters()
    {
        animator.SetBool("opening", false);
        animator.SetBool("closing", false);
        compartmentAlreadyClosed = true;
    }
}
