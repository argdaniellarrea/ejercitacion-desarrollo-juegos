using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    private Character enemy1;
    

    public Character Enemy
    {
        get
        {
            return enemy1;
        }

        set
        {
            enemy1 = value;
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 MoveOrders = new Vector3(3f, 0f, 0f);
        enemy1.move(MoveOrders*3*Time.deltaTime);
        
	}
}
