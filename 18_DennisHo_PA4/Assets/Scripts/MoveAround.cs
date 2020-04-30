using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAround : MonoBehaviour
{
    public float moveSpeed = 150;
    private Rigidbody thisRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        thisRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveX = Input.GetAxis("Horizontal") * Vector3.right;
        Vector3 moveZ = Input.GetAxis("Vertical") * Vector3.forward;

        Vector3 moveDirection = moveX + moveZ;

        thisRigidbody.AddForce(moveDirection * moveSpeed * Time.deltaTime);
    }
}
