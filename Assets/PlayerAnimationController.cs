using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : StateMachineBehaviour
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetFloat("IdleOffset", Random.Range(0, 0.5f));
    }
}
