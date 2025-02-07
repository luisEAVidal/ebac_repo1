using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CubeSpawner_EnableDisable : MonoBehaviour
{
    public GameObject cubePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        GameObject tempGameObject = Instantiate<GameObject>(cubePrefab);
        tempGameObject.name = "cube_onEnable";
        tempGameObject.transform.localScale = Vector3.one * 2; //bigger cube to not confuse it
        tempGameObject.AddComponent<Rigidbody>();
    }

    private void OnDisable()
    {
        GameObject tempGameObject = Instantiate<GameObject>(cubePrefab);
        tempGameObject.name = "cube_onDisable";
        tempGameObject.transform.localScale = Vector3.one * 2; //bigger cube to not confuse it
        tempGameObject.AddComponent<Rigidbody>();
    }
}
