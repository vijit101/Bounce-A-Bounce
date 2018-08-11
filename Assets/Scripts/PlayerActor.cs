using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActor : MonoBehaviour {
    private void OnCollisionStay(Collision collidedfloor)
    {
        maxy = collidedfloor.transform.position.y + 1.3f;
    }

    Rigidbody rgbd;
    [SerializeField] float speed = 5;
    [SerializeField] float jumpfactor = 5;
    [SerializeField] float maxy;
    private void Awake()
    {
        rgbd = GetComponent<Rigidbody>();
    }
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        jumpball();  
	}
    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        rgbd.AddForce(new Vector3(horizontal, 0, vertical)*speed);
    }
    private void jumpball()
    {
       if (Input.GetKeyDown(KeyCode.Space))
       {
            if (transform.position.y < maxy)
            {
                rgbd.AddForce((Vector3.up)*jumpfactor,ForceMode.Impulse);
               
            }
       }
        
    }
}
