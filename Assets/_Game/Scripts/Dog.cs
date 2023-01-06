using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//DOG CHILD CLASS
public class Dog : Animal // INHERITANCE FROM ANIMAL
{
    private string _helloText = "Hello I am a Dog";
    public string HelloText { get => _helloText; } // ENCAPSULATION
    private void Update()
    {
        Move(2.1f);
    }
    protected override void Move() // POLYMORPHISM
    {
        Vector3 pos = transform.localPosition;
        pos.x += Time.deltaTime * (_speed * 2);
        transform.localPosition = pos;
    }
    void Move(float number) // POLYMORPHISM
    {
        Vector3 pos = transform.localPosition;
        pos.x += Time.deltaTime * (_speed * number);
        transform.localPosition = pos;
    }
}
