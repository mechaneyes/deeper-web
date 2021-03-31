using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// https://catlikecoding.com/unity/tutorials/basics/building-a-graph/
// https://learn.unity.com/tutorial/introduction-to-scriptable-objects#5cf187b7edbc2a31a3b9b123
// https://en.wikipedia.org/wiki/The_Raven_(Lou_Reed_album)


public class Graph : MonoBehaviour
{
    [SerializeField]
    Transform targetPrefab = default;

    [SerializeField, Range(10, 100)]
    int resolution = 10;

    Transform[] targets;

    public Vector3 singleDrop;

    void Start()
    {
        float step = 2f / resolution;
        var position = Vector3.zero;
        var scale = Vector3.one * step;

        targets = new Transform[resolution];
        for (int i = 0; i < targets.Length; i++)
        {
            Transform oneTarget = Instantiate(targetPrefab);
            position.x = (i + 0.5f) * step - 1f;
            oneTarget.localPosition = position;
            oneTarget.localScale = scale;

            targets[i] = oneTarget;

            oneTarget.SetParent(transform, false);
        }
    }

    void Update()
    {
        float time = Time.time;
        for (int i = 0; i < targets.Length; i++)
        {
            Transform oneTarget = targets[i];
            Vector3 position = oneTarget.localPosition;
            position.y = Mathf.Sin(Mathf.PI * (position.x + time));
            oneTarget.localPosition = position;

            singleDrop = targets[2].position;
            //Debug.Log("singleDrop " + singleDrop);
        }
    }
}
