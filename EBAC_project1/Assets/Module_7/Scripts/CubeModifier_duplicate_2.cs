using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class CubeModifier_duplicate_2 : MonoBehaviour
{
    public GameObject prefabCube;
    public CubeModifier _CubeModifier;
    public CubeModifier_duplicate_1 _CubeModifier_1;

    private bool isWhite;
    private MeshRenderer _meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        _meshRenderer = prefabCube.GetComponent<MeshRenderer>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (_CubeModifier != null && _CubeModifier_1 != null)
        {
            isWhite = _CubeModifier.getIsWhite() || _CubeModifier_1.getIsWhite();
            _meshRenderer.material.color = isWhite ? Color.white : Color.black;
        }
        else
        {
            Debug.LogError("invalid Cube Modifier ");
        }
    }
}
