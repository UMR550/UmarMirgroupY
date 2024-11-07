using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personscr : MonoBehaviour
{
    int Health = 100;
    int damage = 15;
    Rigidbody rb;
    // Start is called before the first frame update
    internal void ExplosionAt(Vector3 position, float explosionRadius, float explosionStrength)
    {
        Health -= damage;
        print("hhhhhhhh" + Health.ToString());





    }


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
