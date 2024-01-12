using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TurretController : MonoBehaviour
{
    float towerAngel;
    public float towerSpeed = 500;




    private void Update()
    {
        towerAngel += Input.GetAxis("Mouse X") * towerSpeed * Time.deltaTime;
        //towerAngel = Mathf.Clamp(towerAngel, -65, 65);
        transform.rotation = Quaternion.Euler(new Vector3(0, towerAngel, 0));
       

    }


    

















}




    



