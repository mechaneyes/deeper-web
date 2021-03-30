using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// https://catlikecoding.com/unity/tutorials/basics/building-a-graph/
// https://learn.unity.com/tutorial/introduction-to-scriptable-objects#5cf187b7edbc2a31a3b9b123
// https://en.wikipedia.org/wiki/The_Raven_(Lou_Reed_album)


public class Graph : MonoBehaviour
{
    [SerializeField]
    Transform pointPrefab = default;

    [SerializeField, Range(10, 100)]
    int resolution = 10;

    Transform[] points;

    public Vector3 singleDrop;

    void Start()
    {
        float step = 2f / resolution;
        var position = Vector3.zero;
        var scale = Vector3.one * step;

        points = new Transform[resolution];
        for (int i = 0; i < points.Length; i++)
        {
            Transform point = Instantiate(pointPrefab);
            position.x = (i + 0.5f) * step - 1f;
            point.localPosition = position;
            point.localScale = scale;

            points[i] = point;

            point.SetParent(transform, false);
        }
    }

    void Update()
    {
        float time = Time.time;
        for (int i = 0; i < points.Length; i++)
        {
            Transform point = points[i];
            Vector3 position = point.localPosition;
            position.y = Mathf.Sin(Mathf.PI * (position.x + time));
            point.localPosition = position;

            singleDrop = points[2].position;
            //Debug.Log("singleDrop " + singleDrop);
        }
    }
}
