using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops_Arrays_Excercise : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] arr1 = new int[10];
        int[] arr2 = new int[10];

        for (int i = 0; i < 10; ++i)
        {
            arr1[i] = Random.Range(0, 1000);
            Debug.Log("arr1[" + i + "] = " + arr1[i]);
            arr2[i] = Random.Range(0, 1000);
            Debug.Log("arr2[" + i + "] = " + arr2[i]);
        }

        int[] arr3 = new int[10];

        for (int i = 0; i < 10; ++i)
        {
            arr3[i] = arr1[i] + arr2[i];
            Debug.Log("arr3[" + i + "] = " + arr3[i]);
        }

        string[] arr4 = new string[] { "I", "feel", "uptight", "on", "a", "Saturday", "night" };
        string concatenatedString = new("");

        foreach (string s in arr4) {
            concatenatedString += s;
            concatenatedString += " ";
        }

        Debug.Log(concatenatedString);

        int[,] matrixA = new int[2, 3] { {1,2,3}, {4,5,6} };
        int[] matrixB = new int[3] {7,8,9};

        int[] resultMatrix = new int[2] {0,0};

        for (int i = 0; i < matrixA.GetLength(0); ++i) {
            for (int j = 0; j < matrixA.GetLength(1); ++j) {
                resultMatrix[i] += matrixA[i, j] * matrixB[j];
            }
        }

        foreach (int value in resultMatrix) {
            Debug.Log("Matrix Result: " + value);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
