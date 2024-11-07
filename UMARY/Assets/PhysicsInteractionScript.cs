using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsInteractionScript : MonoBehaviour
{
    Rigidbody rb;
    float explosionRadius = 10;
    float explosionStrength = 1000;

    // Start is called before the first frame update
    void Start()

    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(100 * transform.forward, ForceMode.Impulse);

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, 10, 0),ForceMode.Impulse);
        }
       
        
    }
}
