using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float force = 20.0f;
    public float lBarrier = -1.7f;
    public float rBarrier = 1.7f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (transform.position.x < lBarrier)
        {
            transform.position = new Vector3(lBarrier, transform.position.y, transform.position.z);
        }

        if (transform.position.x > rBarrier)
        {
            transform.position = new Vector3(rBarrier, transform.position.y, transform.position.z);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * force);
        }
    }
}
