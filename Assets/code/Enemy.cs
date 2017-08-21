using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    [SerializeField]
    private GameObject enemyPrefab;
    private GameObject avatar;

    // Use this for initialization
    void Start () {
        if (enemyPrefab != null){
            avatar = GameObject.Instantiate(enemyPrefab);
            GetComponent<EnemyController>().Enemy = avatar.GetComponent<Character>();
        }else{
            GetComponent<EnemyController>().enabled = false;
        }
    }
    
	// Update is called once per frame
	void Update () {
		
	}
}
