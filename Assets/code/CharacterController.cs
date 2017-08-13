using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

    private Character caracter;
    private Vector3 direction = Vector3.zero;

    public Character Caracter
    {
        get
        {
            return caracter;
        }

        set
        {
            caracter = value;
        }
    }

    // Use this for initialization
    void Start () {
            
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 MoveOrders = new Vector3(0f,0f,0f);

        MoveOrders.x = (Input.GetKey(KeyCode.A) ? -1 : 0) + (Input.GetKey(KeyCode.D) ? 1 : 0);
        MoveOrders.z = (Input.GetKey(KeyCode.W) ? 1 : 0) + (Input.GetKey(KeyCode.S) ? -1 : 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            caracter.jump();
        }

        caracter.move(MoveOrders);
    }
}
