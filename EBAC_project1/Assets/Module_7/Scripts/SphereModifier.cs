using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereModifier : MonoBehaviour
{
    public GameObject prefabSphere;
    public bool isWhite;
    // Start is called before the first frame update
    void Start()
    {
        isWhite = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        //prefabSphere.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
        prefabSphere.GetComponent<MeshRenderer>().material.color = isWhite ? Color.white : Color.black;
        isWhite = !isWhite;
    }

    public bool getIsWhite() { return isWhite; }
}
