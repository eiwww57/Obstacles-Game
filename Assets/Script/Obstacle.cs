using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    MeshRenderer render;
    Rigidbody rigidBody;
    [SerializeField] float waitedTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();

        render.enabled = false;
        rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        Down();
    }
     void Down()
    {
        if (Time.time > waitedTime)
        {
            render.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
