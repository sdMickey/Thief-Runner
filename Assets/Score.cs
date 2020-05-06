using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score = 0;
    void Start()
    {
        score = 0;
    }

   
    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = "SCORE:" + score.ToString();
    }
}
