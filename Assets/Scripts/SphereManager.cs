using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereManager : MonoBehaviour
{
    public GameObject[] spherePrefab;
    public int sphereIndex;

    //public static float halfSpheres = spherePrefab.Length;
    public static float sphereOffsetterPos = 1;
    public static float sphereOffsetterNeg = -1;


    void Start()
    {
        for (int i = 0; i < spherePrefab.Length; i++)
        {
            ////Instantiate(spherePrefab[sphereIndex], new Vector3(i * 2, i * 2 * i * 2, 0), Quaternion.identity);
            //Transform pointPrefab = Instantiate(spherePrefab[sphereIndex]);
            ////sphere.localPosition = Vector3.right;
            ////position.x = i * 2;
            ////position.y = position.x * position.x;

            ////Debug.Log("offsetter " + sphereOffsetter);
            //sphereOffsetterPos++;

        }

        //for (int j = 0; j > spherePrefab.Length * -1; j--)
        //{
        //    Instantiate(spherePrefab[sphereIndex], new Vector3(j * 2, 1, 0), Quaternion.identity);

        //    Debug.Log("sphereOffsetterNeg " + sphereOffsetterNeg);
        //    sphereOffsetterNeg--;

        //}
    }

    // Update is called once per frame
    void Update()
    {

        //index += Time.deltaTime;
        //float y = amplitudeY * Mathf.Cos(omegaY * index);


        //spherePrefab[sphereIndex].transform.Vector3(0, y, 0));
    }
}
