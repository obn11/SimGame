using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DController : MonoBehaviour
{
    Animator animator;
    public GameObject Over2;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Over2.activeSelf)
        {
            animator.SetBool("typing", true);
        }
    }
}
