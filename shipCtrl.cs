using UnityEngine;
using System.Collections;

public class shipCtrl : MonoBehaviour {

    public Rigidbody rb;
    private float speed;
    private float rotateSpeed;

    // Use this for initialization
    void Start () {
        rb = gameObject.GetComponent<Rigidbody>();
        speed = 0.1f;
        rotateSpeed = 0;

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rotateSpeed = 0.2f;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rotateSpeed = -0.2f;
        }

    }

    void FixedUpdate()
    {
        rb.MovePosition(transform.position + speed * transform.forward.normalized);
        rb.MoveRotation(transform.rotation * Quaternion.Euler(0, rotateSpeed, 0));
        rotateSpeed = 0;

    }
}
