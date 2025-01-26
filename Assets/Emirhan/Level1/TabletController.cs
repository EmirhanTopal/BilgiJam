using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabletController : MonoBehaviour
{
    [SerializeField] private int DirectionSpeed;
    [SerializeField] private int RotateSpeed;
    [SerializeField] private int speed;

    [SerializeField] private HealthController HealthController;
    void Update()
    {
        Controller();   
    }
    
    private void Controller()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * DirectionSpeed);
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * vertical * Time.deltaTime * speed);        
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed * horizontal * -1);
            transform.rotation = Quaternion.Euler(0, 180, RotateSpeed * horizontal);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * horizontal);
            transform.rotation = Quaternion.Euler(0, 180, RotateSpeed * horizontal);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * vertical  * Time.deltaTime * speed * -1); 
        }
    }


    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("sa");
        if (other.gameObject.CompareTag("alyuvar"))
        { 
            Destroy(other.gameObject);
            HealthController.ChangeHealth(-10);
        }
        if (other.gameObject.CompareTag("corona"))
        {
            Destroy(other.gameObject);
            HealthController.ChangeHealth(10);
        }
    }
}
