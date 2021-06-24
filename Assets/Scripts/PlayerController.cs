using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public float rotate;
    private Rigidbody rb;
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        Vector3 rotation = new Vector3(0.0f, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
        transform.Rotate(movement * rotate);
    }
}