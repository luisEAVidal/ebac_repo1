using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data_Structures_Excercise : MonoBehaviour
{
    public List<int> Fill_List(int size, int lowerRange, int higherRange)
    {
        List<int> list = new();

        for (int i = 0; i < size; i++)
        {
            list.Add(Random.Range(lowerRange, higherRange));
        }
       
        return list;
    }

    public int[] Sort_Array(int[] array)
    {
        var list = new List<int> (array);
        list.Sort ();
        return list.ToArray ();
    }

    public HashSet<int> List_To_HashSet(List<int> list)
    {
        return new HashSet<int> (list);
    }

    public HashSet<string> List_To_HashSet(List<string> list)
    {
        return new HashSet<string>(list);
    }
    // Start is called before the first frame update
    void Start()
    {
        int[] arrayToSort = { 5, 101, 98 , 1, 5};
        var sortedArray = Sort_Array(arrayToSort);
        foreach (int value in sortedArray)
        {
           Debug.Log(value); 
        }

        List<int> sortedList = new List<int> (sortedArray);
        var hash_set_int = List_To_HashSet(sortedList);

        foreach (int value in hash_set_int)
        {
            Debug.Log(value);
        }

        List<string> stringList = new List<string>();

        stringList.Add("Mercury");
        stringList.Add("Venus");
        stringList.Add("Earth");
        stringList.Add("Mars");
        stringList.Add("Mercury");

        var hash_set_string = List_To_HashSet(stringList);

        foreach (string value in hash_set_string)
        {
            Debug.Log(value);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
