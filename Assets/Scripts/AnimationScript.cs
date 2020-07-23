using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{

    public Animator animator;

    // These are 'parameters' defined in my character animator. We want to change these parameters based on the input the character is receiving.
    // If the character were a top down view, vertical movement would be forward and backward. Horizontal is left and right.
    public float Vertical_f;
    public float Horizontal_f;

    void Start()
    {
        // Get Animator from game object and apply it to animator variable
        animator = this.gameObject.GetComponent<Animator>();
    }

    public float dampTime; // Basically how smooth the transition between animations is. 

    void Update()
    {
        Vertical_f = Input.GetAxisRaw("Vertical");
        Horizontal_f = Input.GetAxisRaw("Horizontal");

        animator.SetFloat("Vertical_f", Vertical_f, 0.1f, Time.deltaTime);
        animator.SetFloat("Horizontal_f", Horizontal_f, 0.1f, Time.deltaTime);
    }
}
