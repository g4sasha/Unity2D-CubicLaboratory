using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private GroundCheck _groundCheck;
    [SerializeField] private SpriteRenderer _spriteRender;
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    private float _horizontal;

    private void Update()
    {
        // Movement
        _horizontal = Input.GetAxis("Horizontal");
        _rigidbody.velocity = new Vector2(_horizontal * _speed, _rigidbody.velocity.y);

        // Flip
        if (_horizontal > 0f)
        {
            _spriteRender.flipX = false;
        }
        else if (_horizontal < 0f)
        {
            _spriteRender.flipX = true;
        }

        // Jump
        if (Input.GetKey(KeyCode.Space) && _groundCheck.IsGrounded)
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, 0f);
            _rigidbody.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
        }
    }
}