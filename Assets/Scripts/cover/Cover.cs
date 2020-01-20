using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cover : MonoBehaviour
{

    public GameObject _gameObject;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        Vector3 pos = _gameObject.transform.position;
        if (pos.x > -2f )
        {
            pos.x -= 0.5f;
        }
        _gameObject.transform.position = pos;
    }
}
