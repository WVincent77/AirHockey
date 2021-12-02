using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPU : MonoBehaviour
{

    public float speed = 5.0f;
    private Rigidbody cpuRb;
    private GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        cpuRb = GetComponent<Rigidbody>();
        enemy = GameObject.Find("Puck");
    }

    // Update is called once per frame
    void Update()
    {
        cpuRb.AddForce((enemy.transform.position - transform.position).normalized * speed);
    }
}
