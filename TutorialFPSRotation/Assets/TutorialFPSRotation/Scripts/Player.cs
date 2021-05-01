using UnityEngine;

[RequireComponent(typeof(CharacterController), typeof(PlayerMove), typeof(PlayerRotate))]
public class Player : MonoBehaviour
{
    private PlayerMove _move;
    private PlayerRotate _rotate;
    private PlayerRotate _rotateSmooth;
    private PlayerRotate _currentRotate;

    private void Awake()
    {
        _move = GetComponent<PlayerMove>();
        _rotate = GetComponents<PlayerRotate>()[0];
        _rotateSmooth = GetComponents<PlayerRotate>()[1];
        Cursor.lockState = CursorLockMode.Locked;

#if UNITY_EDITOR
        _currentRotate = _rotate;
#else
        _currentRotate = _rotateSmooth;
#endif
    }

    private void Update()
    {
        _move.Move();
        _currentRotate.Rotate();
    }
}
