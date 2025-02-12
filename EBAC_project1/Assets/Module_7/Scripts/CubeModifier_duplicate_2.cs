using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class CubeModifier_duplicate_2 : MonoBehaviour
{
    public GameObject prefabCube;
    private bool isWhite;
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

        bool isCubeWhite = false;
        var cubeGo = GameObject.Find("Cube");
        if (cubeGo != null)
            isCubeWhite = cubeGo.GetComponent<CubeModifier>().getIsWhite();

        bool isCubeDuplicate1White = false;
        var cubeDuplicate1Go = GameObject.Find("Cube_duplicate_1");
        if (cubeDuplicate1Go != null)
            isCubeDuplicate1White = cubeDuplicate1Go.GetComponent<CubeModifier_duplicate_1>().getIsWhite();

        isWhite = isCubeWhite && isCubeDuplicate1White;
        prefabCube.GetComponent<MeshRenderer>().material.color = isWhite ? Color.white : Color.black;
    }
}
