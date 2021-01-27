using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator animator;
    public Vector3 topos;
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical");
        float h= Input.GetAxis("Horizontal");
        if (h != 0 || v != 0)
        {
            Vector3 pos = new Vector3(h, 0, v);
            transform.LookAt(pos);
            transform.position +=pos;
            animator.SetBool("run", true);
        }
        else
        {
            animator.SetBool("run", false);
        }
        
    }
}
