using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explode : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
         
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(10 * transform.forward, ForceMode.Impulse);
        
    }
}
