using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class CollisionScore : MonoBehaviour
{

    public int scorePoint = 0;
    public int MaxScore;
    public TextMeshProUGUI scoreText;


    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Blue Score: " + scorePoint;
    }

    void OnCollisionEnter (Collision other)
    {
        if (other.gameObject.tag == "RedGoal")
        {
            Debug.Log("Blue Scored!");
            scorePoint += 1;
            scoreText.text = "Blue Score: " + scorePoint;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
