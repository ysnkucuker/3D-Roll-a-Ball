using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Vector3 _offset;

    private void LateUpdate()
    {   
        Vector3 _desiredPosition = _target.position + _offset;
        Vector3 _smoothPosition = Vector3.Lerp(transform.position, _desiredPosition, Time.deltaTime);

        transform.position = _smoothPosition;
    }
}
