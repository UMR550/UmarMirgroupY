using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class fpscontrol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        { if (Input.GetKey(KeyCode.W))
            {
                transform.position += transform.forward * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.S))
                    transform.position -= transform.forward * Time.deltaTime;

            transform.Rotate(Vector3.up, Input.GetAxis("Horizontal"));
            transform.Rotate(Vector3.right, Input.GetAxis("Vertical"));

        }
    } }
