using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed = 120.0f;
    public float jumpForce = 10.0f;
    bool isGrounded; 
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    private void FixedUpdate()
    {
        float moveVertical = Input.GetAxis("Vertical");
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector3 movement = moveVertical * speed * Time.fixedDeltaTime * transform.forward;
        rb.MovePosition(rb.position + movement);

        float turn = moveHorizontal * rotationSpeed * Time.fixedDeltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        rb.MoveRotation(rb.rotation * turnRotation);

        
    }
    
    void OnCollisionStay()
    {
        isGrounded = true;
    }
}
