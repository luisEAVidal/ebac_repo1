using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner_Awake : MonoBehaviour
{
    public GameObject cubePrefab;
    private void Awake()
    {
        GameObject tempGameObject = Instantiate<GameObject>(cubePrefab);
        tempGameObject.name = "cube_awake";
        tempGameObject.AddComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
