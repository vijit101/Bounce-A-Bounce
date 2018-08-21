using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActor : MonoBehaviour
{
    Rigidbody rgbd;
    [SerializeField] float speed = 5;
    [SerializeField] float jumpfactor = 5;
    [SerializeField] float Gravityfactor = 1.5f;
    int i = 2;
    private void Awake()
    {
        rgbd = GetComponent<Rigidbody>();
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        jumpball();
        // shrinkball(); (experimental)
    }
    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        rgbd.AddForce(new Vector3(horizontal, 0, vertical) * speed);
    }
    private void jumpball()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (rgbd.velocity.y ==0)
            {
                rgbd.AddForce(Vector3.up * jumpfactor,ForceMode.Impulse);
            }
            /*if (rgbd.velocity.y < 0)
            {
                rgbd.velocity += Vector3.up * Physics.gravity.y * (Gravityfactor)*Time.deltaTime;
            }
            if (rgbd.velocity.y > 0 && !Input.GetKey(KeyCode.Space))
            {
                rgbd.velocity += Vector3.up * Physics.gravity.y * (Gravityfactor)*Time.deltaTime;
            }*/
        }

    }
    private void shrinkball()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (i % 2 == 0)
            {
                transform.localScale = new Vector3(.25f, .5f, .5f);
                i++;
            }
            else
            {
                transform.localScale = new Vector3(.5f, .5f, .5f);
                i--;
            }
        }
          
    }
}
    

