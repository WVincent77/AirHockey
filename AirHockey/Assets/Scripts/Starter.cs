using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Starter : MonoBehaviour
{
    private Button button;
    public GameObject titleScreen;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        titleScreen.gameObject.SetActive(true);
        button.onClick.AddListener(BeginGame);

    }

    public void BeginGame()
    {
          Debug.Log(gameObject.name + " was clicked");
          titleScreen.gameObject.SetActive(false);        
    }


    // Update is called once per frame
    void Update()
    {

    }
}
