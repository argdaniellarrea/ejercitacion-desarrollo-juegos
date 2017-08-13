using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    [SerializeField]
    private GameObject characterPrefab;
    private GameObject avatar;

	// Use this for initialization
	void Start () {
        if (characterPrefab != null){
            avatar = GameObject.Instantiate(characterPrefab);
            GetComponent<CharacterController>().Caracter = avatar.GetComponent<Character>();
        }
        else {
            GetComponent<CameraController>().enabled = true;
            GetComponent<CharacterController>().enabled = false;

        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
