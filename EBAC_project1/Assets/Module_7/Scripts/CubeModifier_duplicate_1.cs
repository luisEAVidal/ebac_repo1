using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeModifier_duplicate_1 : MonoBehaviour
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

        bool isCapsuleWhite = false;
        var capsuleGo = GameObject.Find("Capsule");
        if (capsuleGo != null)
            isCapsuleWhite = capsuleGo.GetComponent<CapsuleModifier>().getIsWhite();

        bool isSphereWhite = false;
        var sphereGo = GameObject.Find("Sphere");
        if (sphereGo != null)
            isSphereWhite = sphereGo.GetComponent<SphereModifier>().getIsWhite();

        isWhite = isCapsuleWhite || isSphereWhite;
        prefabCube.GetComponent<MeshRenderer>().material.color = isWhite ? Color.white : Color.black;
    }
    public bool getIsWhite() { return isWhite; }
}
