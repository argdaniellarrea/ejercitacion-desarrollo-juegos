using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    [SerializeField]
    private float cameraVelocity = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 movement = Vector3.zero;
        float deltaTime = Time.deltaTime;
        
        if (Input.GetKey(KeyCode.W))
        {
            movement = movement + Vector3.forward * deltaTime;
        }
        if(Input.GetKey(KeyCode.A))
        {
            movement = movement + Vector3.left * deltaTime;
        }
        if(Input.GetKey(KeyCode.S))
        {
            movement = movement + Vector3.back * deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movement = movement + Vector3.right * deltaTime;
        }
        
        if(!movement.Equals(Vector3.zero))
        {
            movement = movement * cameraVelocity;
            transform.SetPositionAndRotation(transform.position + movement, transform.rotation);
        }
    }
    
}
