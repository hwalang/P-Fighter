using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorScript : MonoBehaviour
{
    public GameObject m_cube;

    public void MoveAction()
    {
        Animator animator = m_cube.GetComponent<Animator>();
        animator.SetBool("isWalk", true);
    }

    public void ScaleRotateAction()
    {
        Animator animator = m_cube.GetComponent<Animator>();
        animator.SetBool("isWalk", false);
    }
}
