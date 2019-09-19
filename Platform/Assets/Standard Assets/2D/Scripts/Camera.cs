using UnityEngine;
using System.Collections;
using System;

public class Camera : MonoBehaviour
{
    public static Camera main { get; internal set; }
    public float fieldOfView { get; internal set; }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    internal object ScreenPointToRay(Vector3 mousePosition)
    {
        throw new NotImplementedException();
    }
}
