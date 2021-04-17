using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sources : MonoBehaviour
{



    [SerializeField]
    Transform sourcePrefab = default;

    [SerializeField, Range(10, 100)]
    int resolution = 20;

    public Transform[] sources;
    public Transform[] sourcesSides;



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
            position.y = 6;
            position.z = 6;
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
            position.y = 6;
            position.z = -6;
            source.localPosition = position;
            source.localScale = scale;

            sources[j] = source;
            //Debug.Log("sources.sources.sources " + sources[i].localPosition);

            source.SetParent(transform, false);
        }

        sourcesSides = new Transform[2];
        SourcesSides(0, -4f);
        SourcesSides(1, 4f);
    }




    void SourcesSides(int arrLoc, float zee)
    {
        float step = 2f / resolution;
        var position = Vector3.zero;
        var scale = Vector3.one * step;


        Transform source = Instantiate(sourcePrefab);
        source.GetComponent<Renderer>().material.color = Color.cyan;
        position.x = 0;
        position.y = 1;
        position.z = zee;
        source.localPosition = position;
        source.localScale = scale;

        sourcesSides[arrLoc] = source;
        //Debug.Log("sourcesSides[arrLoc] " + arrLoc);

        source.SetParent(transform, false);
    }



    void Start()
    { }






    void Update()
    {
        //Transform source = sources[6];
        //Vector3 position = source.localPosition;

        //con.SetPosition(0, sources[6].position);
        //con.SetPosition(1, target.singleDrop);

        //Debug.Log("target.singleDrop " + target.singleDrop);
    }
}
