using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenDevice : MonoBehaviour
{
    [SerializeField] private Vector3 doorPosition;
    private bool _open;

    public void Operate()
    {
        if (_open)
        {
            Vector3 position = transform.position - doorPosition;
            transform.position = position;
        }
        else
        {
            Vector3 position = transform.position + doorPosition;
            transform.position = position;
        }
        _open = !_open;

    }
    public void Activate()
    {
        if (!_open)
        {
            Vector3 position = transform.position + doorPosition;
            transform.position = position;
            _open = true;
        }
    }

    public void Deactivate()
    {
        Vector3 pos = transform.position - doorPosition;
        transform.position = pos;
        _open = false;
    }
}
