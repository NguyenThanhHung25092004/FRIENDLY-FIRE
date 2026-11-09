using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private string horizontalInput = "Horizontal";
    [SerializeField] private string verticalInput = "Vertical";

    private Vector2 movement;
    public Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    private void Update()
    {
        movement.x = Input.GetAxisRaw(horizontalInput);
        movement.y = Input.GetAxisRaw(verticalInput);
        movement = new Vector2(movement.x, movement.y).normalized;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
