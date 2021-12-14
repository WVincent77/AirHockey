using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Starter : MonoBehaviour
{
    private Button button;
    public GameObject titleScreen;
    public GameObject puck;
    public GameObject rPaddle;
    public GameObject bPaddle;
    public Rigidbody rb;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        button = GetComponent<Button>();       
        titleScreen.gameObject.SetActive(true);
        button.onClick.AddListener(BeginGame);
        puck.gameObject.SetActive(false);
        rPaddle.gameObject.SetActive(false);
        bPaddle.gameObject.SetActive(false);
        /*
        puck.gameObject.GetComponent<RigidBody>();
        rPaddle.gameObject.GetComponent<RigidBody>();
        bPaddle.gameObject.GetComponent<RigidBody>();
        puck.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY;
        rPaddle.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY;
        bPaddle.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY;
        */
    }

    public void BeginGame()
    {
          Debug.Log(gameObject.name + " was clicked");
          titleScreen.gameObject.SetActive(false);
          puck.gameObject.SetActive(true);
          rPaddle.gameObject.SetActive(true);
          bPaddle.gameObject.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {

    }
}
