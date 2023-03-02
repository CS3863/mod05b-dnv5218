using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    float testNumber = 10f;
    // Start is called before the first frame update
    void Start()
    {
        testNumber += 1;          
        print(testNumber);
        
    }

    // Update is called once per frame
    void Update()
    {
        testNumber += 0.1f;
        print(testNumber);

    }
}
