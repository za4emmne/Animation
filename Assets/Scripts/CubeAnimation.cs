using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAnimation : MonoBehaviour
{
    [SerializeField] private float _speed;

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(0, _speed, 0);
    }
}
