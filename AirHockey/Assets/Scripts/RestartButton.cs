using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class RestartButton : MonoBehaviour
{
    private Button restart;
    public GameObject puck;
    public GameObject rPaddle;
    public GameObject bPaddle;
    public float speed = 0f;
    private float yPaddle = -0.14f;
    private float zRPaddle = -3.9f;
    private float zBPaddle = 3.9f;
    private float puckHeight = 0.03f;

    public int redPoint = 0;
    public int bluePoint = 0;
    public TextMeshProUGUI redText;
    public TextMeshProUGUI blueText;

    // Start is called before the first frame update
    void Start()
    {
        restart = GetComponent<Button>();
        restart.onClick.AddListener(RestartGame);
    }

    public void RestartGame()
    {
        speed = 0;
        rPaddle.transform.position = new Vector3(0, yPaddle, zRPaddle);
        bPaddle.transform.position = new Vector3(0, yPaddle, zBPaddle);
        puck.transform.position = new Vector3(0, puckHeight, 0);
        redPoint = 0;
        bluePoint = 0;
        redText.text = "Red Score : " + redPoint;
        blueText.text = "Blue Score :" + bluePoint;
    }
        
    // Update is called once per frame
    void Update()
    {
        
    }
}
