using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

    private Rigidbody rb;
    public float speed;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, 1) * speed;
    }
	
	// Update is called once per frame
}
