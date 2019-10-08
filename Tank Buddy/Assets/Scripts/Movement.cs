using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public Transform CameraHolder;
    public bool faceLeft;
    public bool faceRight;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        faceLeft = false;
        faceRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f);

        rb.AddForce(movement * speed);

        CameraHolder.transform.position = gameObject.transform.position;

        if (Input.GetKey(KeyCode.A) || Input.GetKey("left"))
        {
            faceLeft = true;
            faceRight = false;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey("right"))
        {
            faceRight = true;
            faceLeft = false;
        }
    }
}
