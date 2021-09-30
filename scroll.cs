using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll : MonoBehaviour
{
    public float speed;
    public float size;
    private Transform road;
        void Start()
    {
        road = GetComponent<Transform>();
    }
           void Update()
    {
        road.position = new Vector3(road.position.x, Mathf.Repeat(Time.time * speed, size), road.position.z);
     }
}
