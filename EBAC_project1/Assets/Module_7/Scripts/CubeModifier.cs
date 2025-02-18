using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeModifier : MonoBehaviour
{
    public CapsuleModifier _CapsuleModifier;
    public SphereModifier _SphereModifier;

    private MeshRenderer _MeshRenderer;
    private bool isWhite;
    // Start is called before the first frame update
    void Start()    
    {
        _MeshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //prefabCube.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }

    private void FixedUpdate()
    {

        if (_CapsuleModifier != null && _SphereModifier != null)
        {
            isWhite = _CapsuleModifier.getIsWhite() && _SphereModifier.getIsWhite();
        }
        else
        {
            Debug.LogError("Invalid capsule or sphere modifier");
        }
        _MeshRenderer.material.color = isWhite ? Color.white : Color.black;
    }
    public bool getIsWhite() { return isWhite; }
}
