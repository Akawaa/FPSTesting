using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Target : MonoBehaviour
{ 
    public float range;
    public Transform checkTarget;
    public bool moving;
    public float speed;
    

    public void Start()
    {

    }

    public void LateUpdate()
    {
        float dist = Vector3.Distance(transform.position, checkTarget.transform.position);
        if(dist > range)
        {
            moving = true;
        }

        if (moving)
        {
            transform.position = Vector3.Lerp(transform.position, checkTarget.position, speed * Time.deltaTime);
            if(dist < 0.5f)
            {
                transform.position = checkTarget.position;
                moving = false;
            }
        }
    }

    void OnDrawGizmos()
    {
        Handles.color = Color.blue;
        GUI.color = Color.blue;
        Handles.Label(transform.position + Vector3.up * 2 , moving.ToString());
    }

}
