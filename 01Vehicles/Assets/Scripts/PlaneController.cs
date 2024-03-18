using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    
    [Range(0,20), SerializeField, Tooltip("Max Vehicle linear speed")] 
    private float speed = 5f;
    [Range(0,90), SerializeField, Tooltip("Max Vehicle linear turn speed")]
    private float turnSpeed = 5f;

    private float horizontalInput;
    private float verticalInput;
    
    void Start()
    {
        Debug.Log("Esto es el método Start del PC de " +gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {// deltaTime = tiempo entre frames
        //valor dentro de GetAxis es el que se encuentra en el input del editor
        
        
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(speed*Time.deltaTime*Vector3.forward);
        transform.Rotate(turnSpeed*Time.deltaTime*Vector3.right*verticalInput);
        transform.Rotate(turnSpeed*Time.deltaTime*Vector3.forward*horizontalInput);
    }
}
