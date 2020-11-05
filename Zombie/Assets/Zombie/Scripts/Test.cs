using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public PropertyTest propertyTest;

    private void Start()
    {
        propertyTest.InputA = 10f;

            //var InputB = propertyTest.InputB;
            //propertyTest.InputB = 10f;

        propertyTest.InputC = 10f; //내부에는 0으로 저장
        var InputC = propertyTest.InputC; //외부에는 10으로 출력
    }
}
