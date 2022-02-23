using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour
{
    public Transform _lookAt;
    public float _boundx = 0.15f;
    public float _boundy = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        Vector3 delta = Vector3.zero;

        var deltaX = _lookAt.position.x - transform.position.x;

        if (deltaX > _boundx || deltaX < -_boundx)
        {
            if (transform.position.x < _lookAt.position.x)
            {
                delta.x = deltaX - _boundx;
            }
            else
            {
                delta.x = deltaX + _boundx;
            }
        }

        var deltaY = _lookAt.position.y - transform.position.y;

        if (deltaY > _boundy || deltaY < -_boundy)
        {
            if (transform.position.y < _lookAt.position.y)
            {
                delta.y = deltaY - _boundy;
            }
            else
            {
                delta.y = deltaY + _boundy;
            }
        }

        transform.position += new Vector3(delta.x, delta.y, 0);
    }
    }
