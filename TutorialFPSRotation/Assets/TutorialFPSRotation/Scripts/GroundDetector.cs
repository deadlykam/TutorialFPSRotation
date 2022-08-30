using UnityEngine;

public class GroundDetector : MonoBehaviour
{
    [Header("GroundDetector Properties")]
    [SerializeField, Tooltip("The point from which the physical sphere will be generated.")] private Vector3 _offset;
    [SerializeField, Tooltip("The radius of the physical sphere.")] private float _radius;
    [SerializeField, Tooltip("The layers that will be detected by the physical sphere.")] private LayerMask _detectLayers;

    private bool _isCollided = false; // Flag to check if any collision have happened
    private Collider[] _hitColliders; // The collider objects found through collision

    private void Start() => _hitColliders = new Collider[1]; // Setting the collider storage size

    /// <summary>
    /// This method resets the collision.
    /// </summary>
    public void ResetCollision() => _isCollided = false;

    /// <summary>
    /// This method checks if there has been a collision.
    /// </summary>
    /// <returns>True means collision happened, false otherwise, of type bool</returns>
    public bool IsCollided() => _isCollided;

    private void Update() => _isCollided = Physics.OverlapSphereNonAlloc(transform.position + _offset, 
                                                                         _radius, 
                                                                         _hitColliders, 
                                                                         _detectLayers) != 0;
}
