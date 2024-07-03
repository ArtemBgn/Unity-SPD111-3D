using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Geit2Script : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.PageUp))
        {
            animator.SetBool("IsRotate", false);
        }
        if (Input.GetKey(KeyCode.R))
        {
            animator.SetBool("IsRotate", true);
        }
    }
}
