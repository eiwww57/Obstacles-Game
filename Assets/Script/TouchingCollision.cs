using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchingCollision : MonoBehaviour
{
    int met = 0;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.tag == "Player")
       {
            met++;
            Debug.Log("You have met : " +met);
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit";
       }
     
    }
}
