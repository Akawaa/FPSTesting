using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralMovement : MonoBehaviour
{
    public int speed;
    public int feetspeed;
    public GameObject finishtarget;
    public Target[] targets;
    public Transform[] checktargets;
    public GameObject spidertargets;

    public Target targetscript;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void LateUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);
        movement.Normalize(); // Ensures diagonal movement isn't faster

        // Move the player
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
