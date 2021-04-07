using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targets_02_Sides : MonoBehaviour
{
    [SerializeField]
    Transform tsLeftPrefab = default;

    [SerializeField, Range(10, 100)]
    int resolution = 20;

    public Transform[] tSides;


    void Start()
    {
        //float step = 2f / resolution;
        float step = 2f / 10;
        var position = Vector3.zero;
        //var scale = Vector3.one * step;
        var scale = Vector3.one * 0.07f;

        tSides = new Transform[resolution];
        for (int i = 0; i < 10; i++)
        {
            Transform oneTarget = Instantiate(tsLeftPrefab);
            oneTarget.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.green);
            position.x = (i + 0.5f) * step - 1f;
            position.z = -1;
            oneTarget.localPosition = position;
            oneTarget.localScale = scale;

            tSides[i] = oneTarget;

            oneTarget.SetParent(transform, false);
        }

        for ((int i, int j) = (0, 10); j < 20; i++, j++)
        {
            Transform oneTarget = Instantiate(tsLeftPrefab);
            oneTarget.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.green);
            position.x = (i + 0.5f) * step - 1f;
            position.z = 1;
            oneTarget.localPosition = position;
            oneTarget.localScale = scale;

            tSides[j] = oneTarget;

            oneTarget.SetParent(transform, false);

            //Debug.Log("oneTarget" + j);
        }

        //StartCoroutine(Flicker());
    }

    IEnumerator Flicker()
    {
        while (true)
        {
            //for (int i = 0; i < tsLeft.Length; i++)
            //{
            //yield return new WaitForSeconds(Random.Range(0.01f, 0.1f));
            yield return new WaitForSeconds(0.0005f);
            tSides[Random.Range(0, tSides.Length)].GetComponent<MeshRenderer>().material.SetColor("_Color", Color.green);
            //yield return new WaitForSeconds(Random.Range(0.01f, 0.1f));
            yield return new WaitForSeconds(0.0055f);
            tSides[Random.Range(0, tSides.Length)].GetComponent<MeshRenderer>().material.SetColor("_Color", Color.white);
            //}
        }
    }

    void Update()
    {
        float time = Time.time;
        for (int i = 0; i < 10; i++)
        {
            Transform oneTarget = tSides[i];
            Vector3 position = oneTarget.localPosition;

            //position.y = Mathf.Sin(Mathf.PI * (position.x + time));
            // Dividing by 2 flattens the curve
            position.y = Mathf.Sin(Mathf.PI * (position.x + time) / 2);
            oneTarget.localPosition = position;

            //Debug.Log("singleDrop " + position.y);
        }

        for (int i = 10; i < 20; i++)
        {
            Transform oneTarget = tSides[i];
            Vector3 position = oneTarget.localPosition;
            position.y = Mathf.Sin(Mathf.PI * (position.x + time) / 2);
            oneTarget.localPosition = position;
        }

        //InvokeRepeating("Flicker", 2.0f, 0.3f);
        //StartCoroutine(Flicker());
    }
}
