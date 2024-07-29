using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 200f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Movement
        float moveInput = Input.GetAxis("Vertical");
        rb.velocity = transform.up * (moveInput * speed);

        // Rotation
        float rotateInput = Input.GetAxis("Horizontal");
        float rotationAmount = rotateInput * rotationSpeed * Time.deltaTime;
        rb.rotation -= rotationAmount;
    }
}
