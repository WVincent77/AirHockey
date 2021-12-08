using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class BlueGoal : MonoBehaviour
{

    public int scorePoint = 0;
    public int MaxScore;
    public TextMeshProUGUI scoreText;


    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Red Score: " + scorePoint;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "BlueGoal")
        {
            Debug.Log("Red Scored!");
            scorePoint += 1;
            scoreText.text = "Red Score: " + scorePoint;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
