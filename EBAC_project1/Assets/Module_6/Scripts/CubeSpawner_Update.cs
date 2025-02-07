using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner_Update : MonoBehaviour
{
    public GameObject cubePrefab;
    int cubeCount = 0;
    List<GameObject> cubeList = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject tempGameObject = Instantiate<GameObject>(cubePrefab);
        tempGameObject.name = "cube_update" + cubeCount;
        tempGameObject.AddComponent<Rigidbody>();
        tempGameObject.transform.position = Random.insideUnitSphere;
        cubeCount++;
        cubeList.Add(tempGameObject);
        if (cubeList.Count > 100) {
            Destroy(cubeList[0]);
            cubeList.RemoveAt(0);
        }
    }
}
