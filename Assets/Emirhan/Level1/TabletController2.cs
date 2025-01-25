using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabletController2 : MonoBehaviour
{
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
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * vertical * Time.deltaTime * speed);        
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed * horizontal * -1);
            //transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, RotateSpeed * horizontal * 2);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * horizontal);
            //transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, RotateSpeed * horizontal * 2);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * vertical  * Time.deltaTime * speed * -1); 
        }
    }
}
