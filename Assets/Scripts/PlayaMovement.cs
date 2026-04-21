using UnityEngine;

public class PlayaMovement : MonoBehaviour

{
    public float moveSpeed;
    public Rigidbody2D rb;
    private float horizontalInput;
    private float verticalInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        //why aren't you working
        rb.position += Vector2.right * horizontalInput * moveSpeed * Time.fixedDeltaTime;
        rb.position += Vector2.up * verticalInput * moveSpeed * Time.fixedDeltaTime;
        if (Input.GetKey(KeyCode.LeftControl))
        {
            rb.position += Vector2.right * horizontalInput * moveSpeed * 2 * Time.fixedDeltaTime;
            rb.position += Vector2.up * verticalInput * moveSpeed * 2 * Time.fixedDeltaTime;
        }
    }
}
