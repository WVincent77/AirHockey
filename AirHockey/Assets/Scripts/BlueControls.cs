using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueControls : MonoBehaviour
{

    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("f"))
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
        }
        if (Input.GetKey("h"))
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
        }
        if (Input.GetKey("t"))
        {
            transform.position += Vector3.forward * Time.deltaTime * speed;
        }
        if (Input.GetKey("g"))
        {
            transform.position += Vector3.back * Time.deltaTime * speed;
        }
    }
}
