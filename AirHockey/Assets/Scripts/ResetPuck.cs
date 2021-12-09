using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPuck : MonoBehaviour
{

    private float yPosition = 0.03f;
    private Rigidbody puckRb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "RedGoal")
        {
            transform.position = new Vector3(0, yPosition, 0);
            puckRb.isKinematic = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
