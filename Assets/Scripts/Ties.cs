using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ties : MonoBehaviour
{



    //[SerializeField]
    //Transform tiePrefab = default;

    [SerializeField, Range(10, 100)]
    int resolution = 10;

    Transform[] ties;
    //Transform[] lines;

    private GameObject line;
    private LineRenderer ln;

    [SerializeField]
    private Graph theLine;

    [SerializeField]
    public Sources sources;



    public void Awake()
    {
        sources = FindObjectOfType<Sources>();
        theLine = FindObjectOfType<Graph>();
    }



    void Start()
    {
        float step = 2f / resolution;
        var position = Vector3.zero;
        var scale = Vector3.one * step;

        ties = new Transform[resolution];
        for (int i = 0; i < 9; i++)
        {
            //Transform source = Instantiate(tiePrefab);
            line = new GameObject();
            ln = line.AddComponent<LineRenderer>();
            ln.startWidth = 0.01f;
            ln.endWidth = 0.01f;
        }



        //Debug.Log("sourcesElements: " + sources.sources[0].localPosition);

        Debug.Log("theLine.singleDrop: " + theLine.singleDrop);

        //foreach (Transform t in fromSources.passSources)
        //for (int j = 0; j < sourcesElements.Length; j++)
        //{
        //    Debug.Log("sourcesElements " + sourcesElements[j]);
        //}

    }








    void Update()
    {
        float time = Time.time;
        for (int i = 0; i < 12; i++)
        {
            //Transform source = ties[1];
            //Vector3 position = source.localPosition;

            //ln.SetPosition(0, sources.sources[0].position);
            //ln.SetPosition(1, theLine.singleDrop);

            ////singleDrop = t[i].position;
            //Debug.Log("source " + source);
        }

        Debug.Log("theLine.singleDrop: " + theLine.singleDrop);
        ln.SetPosition(0, sources.sources[0].position);
        ln.SetPosition(1, theLine.singleDrop);
    }
}
