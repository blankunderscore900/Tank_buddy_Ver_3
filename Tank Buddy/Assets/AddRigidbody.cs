using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRigidbody : MonoBehaviour
{
    public GameObject WholeBlock;
    public bool isHit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isHit = WholeBlock.GetComponent<DetectBall>().isHit;

        if (isHit == true)
        {
            Rigidbody rb = gameObject.AddComponent(typeof(Rigidbody)) as Rigidbody;
        }
    }
}
