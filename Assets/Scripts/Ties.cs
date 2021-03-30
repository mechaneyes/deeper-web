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
    //Transform[] connectors;

    private GameObject connector;
    private LineRenderer con;

    [SerializeField]
    private Graph theLine;

    [SerializeField]
    public Sources sources;



    public void Awake()
    {
        //Sources sources.sources[1]
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
            connector = new GameObject();
            con = connector.AddComponent<LineRenderer>();
            con.startWidth = 0.01f;
            con.endWidth = 0.01f;
        }



        sources = FindObjectOfType<Sources>();
        Debug.Log("sourcesElements: " + sources.sources[0].localPosition);
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

            //con.SetPosition(0, sources[1].position);
            //con.SetPosition(1, theLine.singleDrop);

            ////singleDrop = t[i].position;
            //Debug.Log("source " + source);
        }
    }
}
