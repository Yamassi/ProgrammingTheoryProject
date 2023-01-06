using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ANIMAL PARENT CLASS
public abstract class Animal : MonoBehaviour // ABSTRACTION
{
    [SerializeField] protected float _speed;

    protected virtual void Move()
    {
        Vector3 pos = transform.localPosition;
        pos.x += Time.deltaTime;
        transform.localPosition = pos;
    }
}
