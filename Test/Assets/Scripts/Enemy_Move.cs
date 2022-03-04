using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Move : MonoBehaviour
{
    public int _speed;

    private void FixedUpdate()
    {
        transform.Translate(Vector2.right * _speed * Time.deltaTime);
    }
}
