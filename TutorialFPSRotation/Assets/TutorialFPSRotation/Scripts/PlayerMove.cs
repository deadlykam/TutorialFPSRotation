using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [Header("PlayerMove Local Properties")]
    [SerializeField] private float _speed;
    [SerializeField] private float _speedJump;
    [SerializeField] private float _gravity;
    [SerializeField] private GroundDetector _collider;

    private CharacterController _player;
    private Vector3 _moveDir;
    private float _vertDir;

    private void Awake() => _player = GetComponent<CharacterController>();

    public void Move() 
    {
        _moveDir = ((transform.right * Input.GetAxis("Horizontal")) + (transform.forward * Input.GetAxis("Vertical"))) * _speed;
        Jump(); // Making player jump
        _player.Move(_moveDir * Time.deltaTime);
    }

    /// <summary>
    /// This method makes the player jump.
    /// </summary>
    private void Jump()
    {
        // Condition to make player jump
        if (Input.GetKeyDown(KeyCode.Space) && _collider.IsCollided()) _vertDir = Mathf.Sqrt(_speedJump * -2f * _gravity);

        if (_collider.IsCollided() && _vertDir < 0f) _vertDir = 0f; // Resetting gravity when stationary
        else if (!_collider.IsCollided()) _vertDir += _gravity * Time.deltaTime; // Gravity Multiplier
        _moveDir.y = _vertDir; // Setting vertical dir for jump or gravity
    }
}
