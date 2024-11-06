using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explode : MonoBehaviour
{
    Rigidbody rb;
    float ExplosionRadius = 10;
    float ExplosionStrength = 1000;
    // Start is called before the first frame update
    void Start()
         
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(10 * transform.forward, ForceMode.Impulse);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Collider[] allVictimsColliders = Physics.OverlapSphere(transform.position, ExplosionRadius);
        foreach (Collider collider in allVictimsColliders)
        {
            Rigidbody rigidbody = collider.GetComponent<Rigidbody>();
            if (rigidbody != null)
                rigidbody.AddExplosionForce(ExplosionStrength, transform.position,
                    ExplosionRadius);
            

               }
        Destroy(gameObject);
    }
}
