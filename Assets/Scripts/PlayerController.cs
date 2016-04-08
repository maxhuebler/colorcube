using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [HideInInspector] public bool jump = false;

    public float moveSpeed = 5f;
    public float jumpForce = 500f;

    public Transform top_left;
    public Transform bottom_right;
    public LayerMask ground;

    private Rigidbody2D rb;
    private bool grounded;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") + Input.acceleration.x;

        rb.velocity = new Vector2(x * moveSpeed,rb.velocity.y);

        if (jump)
        {
            rb.AddForce(new Vector2(0f, jumpForce));
            jump = false;
        }
    }

    void Update()
    {
        grounded = Physics2D.OverlapArea(top_left.position, bottom_right.position, ground);

        if ((rb.velocity.y == 0f) && grounded)
        {
            jump = true;
            //Debug.Log("Grounded and jumped");
        }

    }
}