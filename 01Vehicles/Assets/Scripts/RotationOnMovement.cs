using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationOnMovement : MonoBehaviour
{
    public bool horizontalRotation;
    public bool verticalRotation;
    [Range(100,1000), SerializeField, Tooltip("Max vertical edge rotation speed")] 
    private float verticalSpeed = 5f;
    [Range(0,90), SerializeField, Tooltip("Max horizontal edge speed")]
    private float horizontalSpeed = 5f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(verticalSpeed*Time.deltaTime*Vector3.forward);
        transform.Rotate(horizontalSpeed*Time.deltaTime*Vector3.up);
        
    }
}
