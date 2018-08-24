using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachCammove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (gameObject.activeSelf)
        {
            gameObject.GetComponent<CamMove>().enabled = true;
        }
	}
}
