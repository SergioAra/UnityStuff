using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject objectToFollow;
    public Vector3 posOffset = new Vector3();
    public Vector3 rotOffset = new Vector3();
    
    void Update()
    {
        
        //aaaaaa
        var objectRot = objectToFollow.transform.rotation;
        var y = objectRot.eulerAngles.y;
        Debug.Log(y);
        var rotation = objectRot * Quaternion.Euler(rotOffset);
        transform.rotation = rotation;
    
        transform.position = objectToFollow.transform.position + Quaternion.AngleAxis(y, Vector3.up)*posOffset;
        
        
       // transform.RotateAround(objectToFollow.transform.position,transform.position,y);
        
        /*
            var magnitude = (objectToFollow.transform.position - transform.position).magnitude;
            
            var tetha = objectRot.eulerAngles.y;
            Debug.Log(tetha);
            var offX = magnitude * Mathf.Cos(tetha);
            var offY = magnitude * Mathf.Sin(tetha);
            transform.position += new Vector3(offX, 0, offY);
            */
    }
}
