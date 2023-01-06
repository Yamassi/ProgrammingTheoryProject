using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//CAT CHILD CLASS
public class Cat : Animal  // INHERITANCE FROM ANIMAL
{
    private string _helloText = "Hello I am a Cat";
    public string HelloText { get => _helloText; } // ENCAPSULATION
    private void Update()
    {
        Move();
    }
    protected override void Move() // POLYMORPHISM
    {
        Vector3 pos = transform.localPosition;
        pos.x += Time.deltaTime * _speed;
        transform.localPosition = pos;
    }
}
