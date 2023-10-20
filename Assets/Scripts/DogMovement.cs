using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogMovement : MonoBehaviour
{
    public int numberVariable;
    public bool isDoingSomething = false;
    public float speed = 10.0f;
    public float rotateSpeed = 100.0f;
    public float endPosition;

    public Vector3 position;
    public string name = "Happydog";
    public Transform cubeTransform;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
        cubeTransform.position = position;
    }

    // Update is called once per frame
    void Update()
    {
        if (cubeTransform.position.x > endPosition)
        {
            //go straight
            cubeTransform.Translate(Vector3.left * Time.deltaTime * speed);
        }

    }
}
