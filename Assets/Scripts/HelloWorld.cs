using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public int numberVariable;
    public bool isDoingSomething = false;
    public float speed = 10.0f;
    public float sprintSpeed = 50.0f;
    public float rotateSpeed = 100.0f;

    public Vector3 position;
    public string name = "Lucy";
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
        if (isDoingSomething)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                speed = sprintSpeed;
            }

            if (Input.GetKey(KeyCode.W))
            {
                cubeTransform.Translate(Vector3.left * Time.deltaTime * speed);
            }
            if (Input.GetKey(KeyCode.S))
            {
                cubeTransform.Translate(Vector3.right * Time.deltaTime * speed);
            }
            if (Input.GetKey(KeyCode.A))
            {
                cubeTransform.Translate(Vector3.back * Time.deltaTime * speed);
            }
            if (Input.GetKey(KeyCode.D))
            {
                cubeTransform.Translate(Vector3.forward * Time.deltaTime * speed);
            }
            if (Input.GetKey(KeyCode.R))
            {
                cubeTransform.Rotate(Vector3.up * Time.deltaTime * speed);
            }


        }

    }
}
