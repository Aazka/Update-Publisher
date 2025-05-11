using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spine : MonoBehaviour
{
    //public float PlanetRotateSpeed = -0.005f;
    public float OrbitSpeed = 0.0005f;
    public GameObject capsule;

    
    void Update()
    {

        transform.RotateAround(capsule.transform.position, Vector3.forward, OrbitSpeed * Time.deltaTime);
    }
}
