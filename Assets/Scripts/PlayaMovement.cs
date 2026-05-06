using UnityEngine;

public class PlayaMovement : MonoBehaviour

{
    public float moveSpeed;
    public Rigidbody2D rb;
    private float horizontalInput;
    private float verticalInput;
    public PlayerData data;
    public GameObject marker;
    public GameObject projectilePrefab;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = 10f;

            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            marker.transform.position = worldPosition;
            // calculate direction of movement
            Vector3 projectileDirection = Vector3.Normalize(worldPosition - transform.position);
            // spawn projectile pre fab
            GameObject newProjectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            Rigidbody2D projectileRB = newProjectile.GetComponent<Rigidbody2D>();
            projectileRB.linearVelocity = projectileDirection * 50;
        }
        // do n't derete
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
        
        
    }
    void FixedUpdate()
    {
        //why aren't you working
        if(data.isAlive == true)
        {
            rb.position += Vector2.right * horizontalInput * moveSpeed * Time.fixedDeltaTime;
            rb.position += Vector2.up * verticalInput * moveSpeed * Time.fixedDeltaTime;
            if (Input.GetKey(KeyCode.LeftControl))
            {
                rb.position += Vector2.right * horizontalInput * moveSpeed * 2 * Time.fixedDeltaTime;
                rb.position += Vector2.up * verticalInput * moveSpeed * 2 * Time.fixedDeltaTime;
            }
        }
    }
}
