using UnityEngine;

public class PlayerRotateSmooth : PlayerRotate
{
    [Header("PlayerRotateSmooth Properties")]
    [SerializeField] private float _smoothTime;
    [SerializeField] private Transform _horiRotHelper;

    private float _verOld;
    private float _vertAngularVelocity;
    private float _horiAngularVelocity;

    private void Start() => _horiRotHelper.localRotation = transform.localRotation;

    public override void Rotate()
    {
        _verOld = vertRot;
        base.Rotate();
    }

    protected override void RotateHorizontal()
    {
        _horiRotHelper.Rotate(Vector3.up * GetHorizontalValue(), Space.Self);
        transform.localRotation
            = Quaternion.Euler(
                0f,
                Mathf.SmoothDampAngle(transform.localEulerAngles.y,
                                      _horiRotHelper.localEulerAngles.y,
                                      ref _horiAngularVelocity,
                                      _smoothTime),
                0f);
    }

    protected override void RotateVertical()
    {
        vertRot = Mathf.SmoothDampAngle(_verOld, vertRot, ref _vertAngularVelocity, _smoothTime);
        base.RotateVertical();
    }
}
