using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sources : MonoBehaviour
{



    [SerializeField]
    Transform sourcePrefab = default;

    [SerializeField, Range(10, 100)]
    int resolution = 10;

    public Transform[] sources;

    private GameObject connector;
    private LineRenderer con;

    [SerializeField]
    private Graph theLine;



    private void Awake()
    {

        float step = 2f / resolution;
        var position = Vector3.zero;
        var scale = Vector3.one * step;

        sources = new Transform[24];
        for (int i = 0; i < 12; i++)
        {
            Transform source = Instantiate(sourcePrefab);
            position.x = (i + 0.5f) * step - 1f;
            position.y = 2;
            position.z = 2;
            source.localPosition = position;
            source.localScale = scale;

            sources[i] = source;
            //Debug.Log("sources.sources.sources " + sources[i].localPosition);

            source.SetParent(transform, false);
        }

        for ((int i, int j) = (0, 12); j < 24; i++, j++)
        {
            Transform source = Instantiate(sourcePrefab);
            position.x = (i + 0.5f) * step - 1f;
            position.y = 2;
            position.z = -2;
            source.localPosition = position;
            source.localScale = scale;

            sources[j] = source;
            //Debug.Log("sources.sources.sources " + sources[i].localPosition);

            source.SetParent(transform, false);
        }
    }



    void Start()
    {
        //connector = new GameObject();
        //con = connector.AddComponent<LineRenderer>();
        //con.startWidth = 0.01f;
        //con.endWidth = 0.01f;

        theLine = FindObjectOfType<Graph>();
    }






    void Update()
    {
        //Transform source = sources[6];
        //Vector3 position = source.localPosition;

        //con.SetPosition(0, sources[6].position);
        //con.SetPosition(1, theLine.singleDrop);

        //Debug.Log("theLine.singleDrop " + theLine.singleDrop);
    }
}
