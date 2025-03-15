using UnityEngine;

public class GeoController : MonoBehaviour
{

    string Helloworld = "hello world";

    // int - integer/non-decimal
    // float - decimal number

    string hello = "hello ";
    string world = "world";

    float numberOne = 2;
    float numberTwo = 4.25f;

    // number_two

    // Start is called before the first frame update
    void Start()
    {
        string sum = hello + world;
        //Debug.Log(sum);
    }

    // Update is called once per frame
    void Update()
    {
        // float sum = numberOne + numberTwo;

        numberOne = numberOne + numberTwo; 
        // Debug.Log("sum: " + sum);
        Debug.Log("increase: " + numberOne);
    }
   // Vector3 vector3 = new Vector3(1, 1, 1,);
}    
//transform