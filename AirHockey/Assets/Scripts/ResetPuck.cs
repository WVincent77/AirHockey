using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPuck : MonoBehaviour
{

    private float yPosition = 0.03f;
    private Rigidbody puckRb;
    public GameObject redPaddle;
    public GameObject bluePaddle;

    private float yPaddle = -0.14f;
    private float zRPaddle = -3.9f;
    private float zBPaddle = 3.9f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "RedGoal")
        {
            transform.position = new Vector3(0, yPosition, 0);
            redPaddle.transform.position = new Vector3(0, yPaddle, zRPaddle);
            bluePaddle.transform.position = new Vector3(0, yPaddle, zBPaddle);
        }

        if (other.gameObject.tag == "BlueGoal")
        {
            transform.position = new Vector3(0, yPosition, 0);
            redPaddle.transform.position = new Vector3(0, yPaddle, zRPaddle);
            bluePaddle.transform.position = new Vector3(0, yPaddle, zBPaddle);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
