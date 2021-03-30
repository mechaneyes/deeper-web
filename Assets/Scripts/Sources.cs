using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sources : MonoBehaviour
{
    [SerializeField]
    Transform sourcePrefab = default;

    [SerializeField, Range(10, 100)]
    int resolution = 10;

    Transform[] sources;
    Transform[] connectors;

    public GameObject connector;
    public LineRenderer con;
    //Vector3 singleDrop = Graph.singleDrop;
    //public VectorVariable singleDrop;
    [SerializeField]
    private Graph theLine;

    void Start()
    {
        float step = 2f / resolution;
        var position = Vector3.zero;
        var scale = Vector3.one * step;

        sources = new Transform[resolution];
        for (int i = 0; i < sources.Length; i++)
        {
            Transform source = Instantiate(sourcePrefab);
            position.x = (i + 0.5f) * step - 1f;
            position.y = 2;
            position.z = 2;
            source.localPosition = position;
            source.localScale = scale;

            sources[i] = source;

            source.SetParent(transform, false);
        }

        //connector = new GameObject();
        //con = connector.AddComponent<LineRenderer>();
        //con.startWidth = 0.05f;
        //con.endWidth = 0.05f;

        theLine = FindObjectOfType<Graph>();
    }


    void Update()
    {
        Transform source = sources[1];
        Vector3 position = source.localPosition;
        //con.SetPosition(0, sources[1].position);
        //con.SetPosition(1, singleDrop);

        Debug.Log("theLine.singleDrop " + theLine.singleDrop);
    }
}
