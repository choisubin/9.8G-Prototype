using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveManager : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 1.0f;

    private Vector3 movement = Vector3.zero;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        movement.Set(moveHorizontal, 0, moveVertical);
        movement = movement.normalized * speed * Time.deltaTime;

        //rb.MovePosition(transform.position + movement);

        transform.Translate(movement);
    }
}
