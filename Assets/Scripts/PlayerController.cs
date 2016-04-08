using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [HideInInspector] public bool jump = false;

    public float moveSpeed = 5f;
    public float jumpHeight = 500f;

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
        grounded = Physics2D.OverlapArea(top_left.position, bottom_right.position, ground);
        float x = Input.GetAxis("Horizontal") + Input.acceleration.x;

        rb.velocity = new Vector2(x * moveSpeed,rb.velocity.y);

        if ((Mathf.Approximately(rb.velocity.y,0f) && grounded))
        {
            jump = true;
            Debug.Log("Grounded and jumped");
        }

        if (jump)
        {
            rb.AddForce(new Vector2(0f, jumpHeight));
            jump = false;
        }
    }
}