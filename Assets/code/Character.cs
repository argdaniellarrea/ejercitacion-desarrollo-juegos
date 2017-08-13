using System.Collections;using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
    [SerializeField]
    private float maxSpeed = 10f;

    public const float gravity = 9.8f;

    private float intensityJump = 9.8f;

    private Vector3 horizontal = Vector3.zero;

    [SerializeField]
    private float acceleration = 1f;

    private Vector3 directionToMove = Vector3.zero;

    private bool hasToJump = false;

    private bool isJumping = false;

    private Rigidbody rigidBody;

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
    }
	// p = v * t + 1/2 a * t^2
    // v = vi + a*t
	// Update is called once per frame
	void FixedUpdate () {

        if (!isJumping) {
            if (directionToMove != Vector3.zero)
            {
                rigidBody.AddForce(directionToMove * acceleration, ForceMode.Impulse);
                directionToMove = Vector3.zero;
            }
            else
            {
              //  rigidBody.AddForce(new Vector3(rigidBody.velocity.x, 0.0f, rigidBody.velocity.z).normalized * -acceleration, ForceMode.Impulse);
            }
            if (hasToJump)
            {
                rigidBody.AddForce(Vector3.up * intensityJump, ForceMode.Impulse);
                hasToJump = false;
                isJumping = true;
            }
        }

        //     if (verticalSpeed != Vector3.zero) {  Unity3d se encarga de esto, asignando a una propiedad del prefab (gameobject)
        //         verticalSpeed = verticalSpeed +  Vector3.down * gravity * Time.deltaTime;
        //     }

        rigidBody.velocity = Vector3.ClampMagnitude(new Vector3(rigidBody.velocity.x, 0.0f, rigidBody.velocity.z), maxSpeed) + new Vector3(0f, rigidBody.velocity.y, 0f);

    }


    public void move(Vector3 direction)
    {
        Debug.Assert(!direction.Equals(Vector3.zero), "Warning requesting movement with value zero.");

        directionToMove = direction;
        directionToMove.Normalize();
    }

    public void jump()
    {
        hasToJump = !isJumping;
    }

    private void OnCollisionEnter(Collision collision)
    {
        for(int i = 0; i< collision.contacts.Length; i++)
        {
            ContactPoint contactPoint = collision.contacts[i];
            
            if (Vector3.Dot(contactPoint.normal, Vector3.up) > 0)
            {
                //rigidBody.velocity = new Vector3(rigidBody.velocity.x, 0.0f, rigidBody.velocity.z);
                isJumping = false;
            }
            
        }
    }

}
