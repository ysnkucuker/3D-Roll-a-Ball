using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementControl : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    private float _horizontalAxis, _verticalAxis;


    void Start()
    {

    }


    void Update()
    {

    }

    private void FixedUpdate()
    {
        _horizontalAxis = Input.GetAxis("Horizontal");
        _verticalAxis = Input.GetAxis("Vertical");

        transform.Translate(_horizontalAxis * Time.deltaTime * _movementSpeed, 0, _verticalAxis * Time.deltaTime * _movementSpeed);

    }
}
