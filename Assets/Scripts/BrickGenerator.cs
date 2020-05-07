using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class BrickGenerator : MonoBehaviour
{

    public GameObject[] bricks;
    public float Speed = 10.0f;
    public Transform brickGeneratePoint;
    public float counter = 0f;



    void Start()
    {
        GenerateBricks();

    }



    void Update()
    {
        if (counter <= 0)
        {
            GenerateBricks();
        }
        else
        {
            counter -= Time.deltaTime;
        }



        GameObject CurrentChild;
        for (int i = 0; i < transform.childCount; i++)
        {
            CurrentChild = transform.GetChild(i).gameObject;
            MoveBricks(CurrentChild);
        }
    }



    void GenerateBricks()
    {
        GameObject newBrick = Instantiate(bricks[UnityEngine.Random.Range(0, bricks.Length)], brickGeneratePoint.position, Quaternion.identity);
        newBrick.transform.parent = transform;
        counter = 4f;



    }

    void MoveBricks(GameObject currentbrick)
    {
        currentbrick.transform.position += Vector3.left * Speed * Time.deltaTime;
    }

}