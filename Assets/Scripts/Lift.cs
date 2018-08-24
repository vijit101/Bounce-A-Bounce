using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift : MonoBehaviour {
    bool translate = false;
    public GameObject cam1;
    public GameObject cam2;
    /*AudioListener cama1; // made due to there were two audio listners of cameras but as camera2 is set not active so its ausio listner too not active 
    AudioListener cama2;*/
    private void OnCollisionEnter(Collision coll)
    {
        translate = true;
    }
    private void Awake()
    {
        cam1.SetActive(true);
        cam2.SetActive(false);
        //cama1 = GetComponent<AudioListener>();
        //cama2 = GetComponent<AudioListener>();
        
    }
    // Use this for initialization
    void Start () {
        //cama1.enabled = true;
        //cama2.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (translate && transform.position.y <=11)
        {
            transform.Translate(0, 11 * Time.deltaTime, 0);
            cam2.SetActive(true);
            cam1.SetActive(false);
            //cama1.enabled = false;
        }
        
           
	}
}
