using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D myRigidbody;


    // Use this for initialization
    void Start()
    {

        myRigidbody = GetComponent<Rigidbody2D>();

        float movementSpeed;

    }

    // Update is called once per frame
    void Update()
    {
        bool right = Input.GetKey(KeyCode.D);


        if (right)
        {


        }
    }
}
