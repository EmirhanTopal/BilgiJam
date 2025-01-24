using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabletController : MonoBehaviour
{
    [SerializeField] private int DirectionSpeed;
    [SerializeField] private int speed;
    void Update()
    {
        Controller();   
    }
    
    private void Controller()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * DirectionSpeed);
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * vertical * Time.deltaTime * speed);            
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed * horizontal * -1); 
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * horizontal); 
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * vertical  * Time.deltaTime * speed * -1); 
        }
    }
    
}
