using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class DeadEnemy : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "dusman")
        {
            Destroy(collision.gameObject);
        }
        else
            Destroy(collision.gameObject);
    }
    



  
}





