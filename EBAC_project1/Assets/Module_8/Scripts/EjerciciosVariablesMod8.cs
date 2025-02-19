using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using Random = UnityEngine.Random;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    // Start is called before the first frame update
    int integerExample = 0;
    float floatExample = 0.0f;
    public GameObject capsulePrefab, cubeDuplicate1Go;
    public String cubeColor;

    private MeshRenderer _MeshRenderer, _MeshRenderer_CubeDuplicate1;
    void Start()
    {
        string completeName = "Luis Añorve Vidal";

        string firstName = completeName.Substring(0,4);
        string middleName = completeName.Substring(5, 6);
        string lastName = completeName.Substring(12);
        string[] nameList = completeName.Split(' ', StringSplitOptions.None);
        Debug.LogWarning("Name substrings: " + firstName + " " + middleName + " " + lastName);
        Debug.LogWarning("Name list: " + nameList[0] + " " + nameList[1] + " " + nameList[2]);

        string numericString1 = new string("5000");
        string numericString2 = new string("75000");

        int convertedString1, convertedString2;

        if (int.TryParse(numericString1, out convertedString1) && int.TryParse(numericString2, out convertedString2))
        {
            Debug.LogWarning("Product of  converted strings: " + convertedString1 * convertedString2);
        }
        else {
            Debug.LogError("Numberic string cannot be converted");
        }

        string phrase1 = "Over the hills and far away!!!";
        char[] phraseArray = phrase1.ToCharArray();
        for (int i = 0; i < phraseArray.Length; ++i) {
            if (i % 2 == 0) {
                Debug.LogWarning(phraseArray[i]);
            }
        }

        string phrase2 = "Lorem ipsum dolor sit amet";

        phrase2 = phrase2[5..];

        Debug.LogWarning("First 5 characters: ->" + phrase2);

        _MeshRenderer = GetComponent<MeshRenderer>();
        _MeshRenderer_CubeDuplicate1 = cubeDuplicate1Go.GetComponent<MeshRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        integerExample++;
        Debug.Log("integerExample = " + integerExample);
    }

    private void FixedUpdate()
    {
        floatExample *= integerExample;
        Debug.Log("floatExample = " + floatExample);

        _MeshRenderer.material.color = integerExample%2==0 ? Color.cyan : Color.magenta;

        switch (cubeColor) {
            case "red":
                _MeshRenderer_CubeDuplicate1.material.color = Color.red; 
            break;
            case "blue":
                _MeshRenderer_CubeDuplicate1.material.color = Color.red;
            break;
            case "yellow":
                _MeshRenderer_CubeDuplicate1.material.color = Color.yellow;
            break;
            default:
                _MeshRenderer_CubeDuplicate1.material.color = Color.gray;
            break;
        }

    }

    private void LateUpdate()
    {
        float localFloat1 = Random.Range(1.0f,10000.0f);
        float localFloat2 = Random.Range(1.0f, 10000.0f);
        Debug.Log("localFloat1 = " + localFloat1 + " localFloat2 = " + localFloat2);
        int localInt1 = (int)(localFloat1 * localFloat2);
        Debug.Log("localInt1 = " + localInt1);

        Debug.Log("localFloat1 converted to string: " + localFloat1.ToString("N4"));
    }

}
