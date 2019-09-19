using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class platformz : MonoBehaviour
{
    public GameObject platform;
    public int numberOfPlatformz = 7;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < numberOfPlatformz; i++)
        {
            Instantiate(platform, new Vector3(i * 7, 0, 0), Quaternion.identity);

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
