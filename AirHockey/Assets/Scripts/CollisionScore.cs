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
    private float yPosition = 0.03f;


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

        /*
        if (other.gameObject.tag == "Puck")
        {
            transform.position = new Vector3(0, yPosition, 0);
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
