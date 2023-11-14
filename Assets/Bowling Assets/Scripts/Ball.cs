using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    bool hasCollided = false;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        //Check for collision with ant object
        //Debug.Log("Ball has collided with " + collision.gameObject.name);

        if (collision.gameObject.CompareTag("Pin") && !hasCollided)
        {
            hasCollided = true;
            Debug.Log("The object we collided woith is " + collision.gameObject.name);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pit"))
        {
            gameManager.SetNextThrow();

            //Destroy Ball GameObject
            Destroy(gameObject);
        }
        else if (other.CompareTag("CloseUpCam"))
        {
            gameManager.SwitchCam();
        }


    }
}
