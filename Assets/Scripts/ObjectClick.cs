using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClick : MonoBehaviour
{

    private GameObject hitObject;

    void Update()
    {
        //On LeftMouseButton
        if (Input.GetMouseButtonDown(0) == true)
        {
            RaycastCube();
            rotSpeedChange(20);
        }

        //On RightMouseButton
        else if (Input.GetMouseButtonDown(1) == true)
        {
            rotSpeedChange(-20);
        }
    }

    //Raycast to detect objects with the "Cube" tag and changes color of the object
    void RaycastCube()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        
        if(Physics.Raycast(ray, out hit) && hit.collider.gameObject.CompareTag("Cube"))
        {
            hitObject = hit.collider.gameObject;
            RandColor();
        }
    }

    //Sets a new random color of object
    void RandColor()
    {
        var cubeRenderer = hitObject.GetComponent<Renderer>();
        cubeRenderer.material.SetColor("_Color", UnityEngine.Random.ColorHSV());
    }

    //Changes the Sphere rotation speed in the "Rotation" script
    void rotSpeedChange(int Speed)
    {
        GameObject sphere = GameObject.Find("Sphere");
        sphere.SendMessage("ChangeRotationSpeed", Speed);
    }

}
