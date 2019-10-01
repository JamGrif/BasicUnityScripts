using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    int myInt = 5;

    void Start()
    {
        Debug.Log(MultiplyByTwo(myInt));


    }

    int MultiplyByTwo(int num)
    {
        return num * 2;
    }



}
