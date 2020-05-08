using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreMenu : MonoBehaviour
{

    public PlayerMovement pm;
    public Text highScoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        highScoreText.text = PlayerPrefs.GetInt("HIGHSCORE").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        pm.OnGameOver();
    }
}
