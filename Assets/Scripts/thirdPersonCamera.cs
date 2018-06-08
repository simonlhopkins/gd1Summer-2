using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thirdPersonCamera : MonoBehaviour {
    public Camera mainCamera;
    [SerializeField]
    private float speed;
    private Vector3 offset;
	// Use this for initialization
	void Start () {
        offset = new Vector3(1f, 1f, 3f);
	}
	
	// Update is called once per frame
	void Update () {
        
        moveCamera();
	}

	private void FixedUpdate()
	{
        Vector3 movementVec = new Vector3(Input.GetAxis("Horizontal") * speed, 0f, Input.GetAxis("Vertical")*speed);

        GetComponent<Rigidbody>().velocity = movementVec;
	}


    void moveCamera(){
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * 2f, Vector3.up) * offset;

        mainCamera.transform.position = transform.position + offset;
        mainCamera.transform.LookAt(transform.position);


    }

	
}
