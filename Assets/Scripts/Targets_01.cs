using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// https://catlikecoding.com/unity/tutorials/basics/building-a-graph/
// https://learn.unity.com/tutorial/introduction-to-scriptable-objects#5cf187b7edbc2a31a3b9b123
// https://en.wikipedia.org/wiki/The_Raven_(Lou_Reed_album)


public class Targets_01 : MonoBehaviour
{
    [SerializeField]
    Transform targetPrefab = default;

    [SerializeField, Range(10, 100)]
    int resolution = 10;

    public Transform[] targets;

    private ColorFader colorFader;
    public Color colorCenter;

    void Awake()
    {
        colorFader = GetComponent<ColorFader>();
    }


    void Start()
    {
        float step = 2f / resolution;
        var position = Vector3.zero;
        //var scale = Vector3.one * step;
        var scale = Vector3.one * 0.07f;

        targets = new Transform[resolution];
        for (int i = 0; i < targets.Length; i++)
        {
            Transform oneTarget = Instantiate(targetPrefab);
            Color c = new Color(1.0f, 0.6f, 0.1f);
            oneTarget.GetComponent<MeshRenderer>().material.color = c;
            position.x = (i + 0.5f) * step - 1f;
            oneTarget.localPosition = position;
            oneTarget.localScale = scale;

            targets[i] = oneTarget;

            oneTarget.SetParent(transform, false);

            colorCenter = c;
        }

        //StartCoroutine(Flicker());
        //Debug.Log("fadingSpeed: " + colorFader.fadingSpeed);

    }

    IEnumerator Flicker()
    {
        while (true)
        {
            //for (int i = 0; i < targets.Length; i++)
            //{
            //yield return new WaitForSeconds(Random.Range(0.01f, 0.1f));
            yield return new WaitForSeconds(0.0005f);
            targets[Random.Range(0, targets.Length)].GetComponent<MeshRenderer>().material.SetColor("_Color", Color.red);
            //yield return new WaitForSeconds(Random.Range(0.01f, 0.1f));
            yield return new WaitForSeconds(0.0055f);
            targets[Random.Range(0, targets.Length)].GetComponent<MeshRenderer>().material.SetColor("_Color", Color.white);
            //}
        }
    }

    void Update()
    {
        float time = Time.time;
        for (int i = 0; i < targets.Length; i++)
        {
            Transform oneTarget = targets[i];
            Vector3 position = oneTarget.localPosition;

            //position.y = Mathf.Sin(Mathf.PI * (position.x + time));
            // Dividing by 2 flattens the curve
            position.y = Mathf.Sin(Mathf.PI * (position.x + time) / 3);
            oneTarget.localPosition = position;

            //singleDrop = targets[i].position;
            //Debug.Log("singleDrop " + position.y);
        }

        //InvokeRepeating("Flicker", 2.0f, 0.3f);
        //StartCoroutine(Flicker());
    }
}
