using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour {
    public GameObject playerreference;
    Vector3 offset;
	// Use this for initialization
	void Start () {
        offset = transform.position - playerreference.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = playerreference.transform.position + offset;
	}
}
