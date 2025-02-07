using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeModifier : MonoBehaviour
{
    public GameObject prefabCube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        prefabCube.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }
}
