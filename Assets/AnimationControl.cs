using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class AnimationControl : MonoBehaviour
{

    public Animator animator;
    public string triggerParameter;

    private void OnTriggerEnter(Collider other)
    {
        animator.SetTrigger(triggerParameter);
    }
}
