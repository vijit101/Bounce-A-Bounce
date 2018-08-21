using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falldetecter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y < -5)
        {
            Utils.reloadcurrentscene();
        }
	}
}
