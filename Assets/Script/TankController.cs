using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class TankController : MonoBehaviour
{

    public float moveSpeed = 5f;
    public float rotationSpeed = 50f;
    RaycastHit hit;
     

    public GameObject bullet;
    public GameObject pozisyon;

    void FixedUpdate()
    {
        // Klavye giriþini al
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Hareket ve dönme fonksiyonlarý
        MoveTank(verticalInput);
        RotateTank(horizontalInput, verticalInput);
    }

    void MoveTank(float input)
    {
        // Ýleri veya geri hareket
        Vector3 moveDirection = transform.forward * input;
        float moveAmount = moveSpeed * Time.deltaTime;
        transform.Translate(moveDirection * moveAmount, Space.World);
    }

    void RotateTank(float horizontalInput, float verticalInput)
    {
        // Y ekseninde dönme
        float rotationAmount = horizontalInput * rotationSpeed * Time.deltaTime;

        // Tank geri gidiyorsa, dönme miktarýný ters yönde ayarla
        if (verticalInput < 0f)
        {
            rotationAmount = -rotationAmount;
        }

        transform.Rotate(Vector3.up, rotationAmount);
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject new_bullet = Instantiate(bullet, pozisyon.transform.position, Quaternion.identity);
            new_bullet.GetComponent<Rigidbody>().AddForce(pozisyon.transform.forward * 5000);
        }
        
    }
}






