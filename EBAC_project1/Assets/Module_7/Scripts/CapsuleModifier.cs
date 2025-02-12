using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class CapsuleModifier : MonoBehaviour
{
    public GameObject capsulePrefab;
    private bool isWhite;

    private void Awake()
    {
        //capsulePrefab.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }
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
        capsulePrefab.GetComponent<MeshRenderer>().material.color = isWhite ? Color.white: Color.black;
        isWhite = !isWhite;
    }

    public bool getIsWhite() { return isWhite; }
}
