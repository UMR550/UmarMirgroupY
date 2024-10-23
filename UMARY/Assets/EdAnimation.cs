using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EdAnimation : MonoBehaviour
{
    Animator edAnimator;
    float Speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        edAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        edAnimator.SetBool("isRunning", false);
        if (Input.GetKey(KeyCode.W))
        {
            // Make Ed walk in animations and move forward
            edAnimator.SetBool("isRunning", true);
            transform.position += Speed * transform.forward * Time.deltaTime;
        }
    }
}
