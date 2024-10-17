using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class myheroscript : MonoBehaviour
{
    float runningSpeed = 3f;
    float turningspeed = 45f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += runningSpeed * transform.forward * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))

            transform.position -= runningSpeed * transform.forward * Time.deltaTime;

        if (Input.GetKey(KeyCode.D))


        {
            transform.Rotate(Vector3.up, turningspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))

        {
            transform.position += runningSpeed * transform.up * Time.deltaTime;
        }
    }
}
            

   