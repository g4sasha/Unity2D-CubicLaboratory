using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private GroundCheck _gc;
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    private void Update()
    {
        _rb.velocity = new Vector2(Input.GetAxis("Horizontal") * _speed, _rb.velocity.y);

        if (Input.GetKey(KeyCode.Space) && _gc.IsGrounded)
        {
            _rb.velocity = new Vector2(_rb.velocity.x, 0f);
            _rb.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
        }
    }
}
