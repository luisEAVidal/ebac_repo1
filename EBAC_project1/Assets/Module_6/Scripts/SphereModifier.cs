using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereModifier : MonoBehaviour
{
    public GameObject prefabSphere;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        prefabSphere.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }
}
