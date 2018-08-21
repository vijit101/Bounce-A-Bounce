using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endpad : MonoBehaviour {
    private void OnCollisionEnter(Collision col)
    {
        Utils.loadnextscene(); //i have not compared tag as in this game only possiblility to collide is for player
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
