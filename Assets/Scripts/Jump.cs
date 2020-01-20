using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    public float jumpHeight = 5f;
    // public GameObject _gameObject;
    // public static bool isJumping = false;
    // bool moveAround = false;
    int counter = 0;
    // void Update()
    // {
    //     if (Input.GetButtonDown("Jump"))
    //     {
    //         Debug.Log("1");
    //         _gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpHeight), ForceMode2D.Impulse);
    //         _gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpHeight), ForceMode2D.Impulse);

    //         moveAround = true;
    //         counter = 0;
    //     }
    //     if (moveAround && counter < 100)
    //     {
    //         counter++;
    //         if (counter >= 100)
    //         {
    //             moveAround = false;
    //         }
    //         _gameObject.transform.Rotate(Vector3.forward * -1);

    //     }
    // }
    GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("fish");

    public void oriented(int lr)
    {
        Debug.Log("2");
        for (int i = 0; i < gameObjects.Length; i++)
        {
            gameObjects[i].GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpHeight), ForceMode2D.Impulse);
            if (lr == 1)
            {
                 gameObjects[i].GetComponent<Rigidbody2D>().AddForce(-Vector2.right * 500 * Time.deltaTime);
                 gameObjects[i].transform.Rotate(Vector3.forward * -20);
            }
            else
            {
                 gameObjects[i].GetComponent<Rigidbody2D>().AddForce(-Vector2.left * 500 * Time.deltaTime);
                 gameObjects[i].transform.Rotate(Vector3.forward * 20);
            }
        }

    }

}
