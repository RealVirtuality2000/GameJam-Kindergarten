using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadBehaviour : StateMachineBehaviour
{
    private BossAttack BossA;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        BossA = GameObject.Find("Teacher").GetComponent<BossAttack>();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        

        if (!BossA.playerInAttackRange)
        {
            animator.SetBool(("CharInRange"), false);
        }
        
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }


}
