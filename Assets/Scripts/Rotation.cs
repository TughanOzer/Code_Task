using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Rotation : MonoBehaviour
{
    //Set the value for the rotation speed in the Editor!
    [SerializeField] private float rotationSpeed;

    //Set the pivot for the Sphere in the Editor!
    [SerializeField] private GameObject cubePivot;

    //Controls on which Axis the Sphere rotates - Editor
    [SerializeField] private bool xAxis, yAxis, zAxis;

    void Update()
    {
        RotateSphere();
    }

    void RotateSphere()
    {
        //Rotates the Sphere arround the selected pivot point.
        transform.RotateAround(cubePivot.transform.position, new Vector3(Convert.ToInt32(xAxis), Convert.ToInt32(yAxis), Convert.ToInt32(zAxis)), rotationSpeed * Time.deltaTime);
    }


}
