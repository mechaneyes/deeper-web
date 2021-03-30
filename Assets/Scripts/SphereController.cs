using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    float amplitudeY = 2f;
    float omegaY = 2.0f;
    float index;

    //GameObject[] spherePrefab = SphereManager.spherePrefab;
    float sphereOffsetterPos = SphereManager.sphereOffsetterPos;
    float sphereOffsetterNeg = SphereManager.sphereOffsetterNeg;


    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("spherePrefab " + spherePrefab[1]);
    }

    // Update is called once per frame
    void Update()
    {
        index += Time.deltaTime;
        float y = amplitudeY * Mathf.Cos(omegaY * index);

        if (sphereOffsetterPos > 0)
        {
            //transform.localPosition = new Vector3(transform.position.x, y, 0);
        }
        else
        {
            //transform.localPosition = new Vector3(transform.position.x, transform.position.y * y, 0);
        }
    }
}
