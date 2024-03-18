using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
   // [HideInInspector] oculta la variable en el editor
   [Range(0,20), SerializeField, Tooltip("Max Vehicle linear speed")]  // asigna un rango en el editor , Permite que la variable se cambie en el editor, texto que aparecen en el editor
    private float speed = 5f;
    [Range(0,90), SerializeField, Tooltip("Max Vehicle linear turn speed")]
    private float turnSpeed = 5f;

    private float horizontalInput;
    private float verticalInput;
    // Start is called before the first frame update
    
   //primer metodo, frame 0
    private void Awake()
    {
        Debug.Log("Se despierta " +gameObject.name);
    }
    //activación de objeto
    private void OnEnable()
    {
        Debug.Log("Se activa " +gameObject.name);
    }

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
        transform.Translate(speed*Time.deltaTime*Vector3.forward*verticalInput);
        transform.Rotate(turnSpeed*Time.deltaTime*Vector3.up*horizontalInput);
    }
}
