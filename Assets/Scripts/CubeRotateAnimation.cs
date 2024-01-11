using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class СubeRotateAnimation : MonoBehaviour
{
    [SerializeField] private float _speedRotation;
    [SerializeField] private float _speedScale;
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Rotate(0, _speedRotation, 0);
        transform.localScale += new Vector3(_speedScale, _speedScale, _speedScale);
        transform.Translate(Vector3.forward*_speed);
    }
}
