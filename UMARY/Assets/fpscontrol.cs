using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class fpscontrol : MonoBehaviour

{
    public GameObject KnifeCloneTemplate;
    float speed= 3;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()

    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 fpsmovementDirection = new Vector3(transform.forward.x, 0, transform.forward.z);
            fpsmovementDirection.Normalize();
            transform.position += speed * fpsmovementDirection * Time.deltaTime;




            transform.position += speed * transform.forward * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
            transform.position -= speed * transform.forward * Time.deltaTime;

        transform.Rotate(Vector3.up, Input.GetAxis("Horizontal"), Space.World);
        transform.Rotate(transform.right, Input.GetAxis("Vertical"), Space.World);


        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(KnifeCloneTemplate, transform.position, transform.rotation);

        }
    }
}


        
    
