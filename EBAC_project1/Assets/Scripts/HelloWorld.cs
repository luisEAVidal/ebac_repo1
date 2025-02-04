using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    private void Awake()
    {
        Debug.LogError("Awake method has been called");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogError("Start method has been called");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update method has been called");
    }

    private void FixedUpdate()
    {
        Debug.LogWarning("FixedUpdate has been called");
    }

    private void LateUpdate()
    {
        Debug.Log("LateUpdate has been called");
    }
}
