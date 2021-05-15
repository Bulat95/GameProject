using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _speedMove = 10;
    [SerializeField] private float _jumpPower = 15;
    [SerializeField] private float _gravityForce = -9.8f;

    internal Vector3 _moveVector;
    internal CharacterController _characterController;
    internal Animator _characterAnimator;
    internal MobileController _mobileController;

    public float SpeedMove { get => _speedMove; set => _speedMove = value; }
    public float JumpPower { get => _jumpPower; set => _jumpPower = value; }
    public float GravityForce { get => _gravityForce; private set => _gravityForce = value;}


    public void Start()
    {
        _characterController = GetComponent<CharacterController>();
        _characterAnimator = GetComponent<Animator>();
        _mobileController = GameObject.FindGameObjectWithTag("Joystick").GetComponent<MobileController>();
    }

    public void Update()
    {
        CharacterMove();
        GamingGravity();
    }

    public void CharacterMove()
    {
        _moveVector = Vector3.zero;
        _moveVector.x = _mobileController.Horizontal() * SpeedMove;
        _moveVector.z = _mobileController.Vertical() * SpeedMove;

        if (_moveVector.x != 0 || _moveVector.z != 0)
            _characterAnimator.SetBool("Move", true);
        else _characterAnimator.SetBool("Move", false);
        if (Vector3.Angle(Vector3.forward, _moveVector) > 1f || Vector3.Angle(Vector3.forward, _moveVector) == 0)
        {
            Vector3 direct = Vector3.RotateTowards(transform.forward, _moveVector, SpeedMove, 0.0f);
            transform.rotation = Quaternion.LookRotation(direct);
        }
        _moveVector.y = GravityForce;
        _characterController.Move(_moveVector * Time.deltaTime);
    }

    public void GamingGravity()
    {
        if (!_characterController.isGrounded)
            GravityForce -= 20f * Time.deltaTime;
        else
            GravityForce = -1f;
        if (Input.GetKeyDown(KeyCode.Space) && _characterController.isGrounded)
            GravityForce = JumpPower;
    }
}
