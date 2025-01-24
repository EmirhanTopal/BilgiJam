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
        transform.Translate(Vector3.forward * Time.deltaTime * DirectionSpeed);
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);            
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed); 
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed); 
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed); 
        }
    }
    
}
