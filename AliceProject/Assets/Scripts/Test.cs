using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cube;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cube.transform.Translate(cube.transform.position.x, 10*Mathf.Sin(0.01f * Time.deltaTime), cube.transform.position.z, Space.World);
    }
}
