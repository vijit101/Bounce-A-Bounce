using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift : MonoBehaviour {
    
    public Camera camz;
    bool camrot = false;
    private void OnCollisionStay(Collision collision)
    {
        if (transform.position.y <= 11)
        {
            transform.Translate(0, 11 * Time.deltaTime, 0);
            camrot = true;
        }
    }
    private void Awake()
    {
        camz = GetComponent<Camera>();
    }
    // Use this for initialization
    void Start () {
      
    }
	
	// Update is called once per frame
	void Update () {
        if (camrot)
        {
            camz.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
	}
}
