using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeModifier_duplicate_1 : MonoBehaviour
{
    //public GameObject prefabCube;
    public CapsuleModifier _CapsuleModifier;
    public SphereModifier _SphereModifier;

    private bool isWhite;
    private MeshRenderer _MeshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        _MeshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {

        isWhite = _CapsuleModifier.getIsWhite() || _SphereModifier.getIsWhite();
        _MeshRenderer.material.color = isWhite ? Color.white : Color.black;
    }
    public bool getIsWhite() { return isWhite; }
}
