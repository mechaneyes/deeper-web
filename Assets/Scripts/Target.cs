using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TheTargets
{
    public class Target : MonoBehaviour
    {
        //[SerializeField]
        //Transform tsLeftPrefab = default;

        [SerializeField, Range(10, 100)]
        int resolution = 20;

        float step = 2f / 10;
        Vector3 position = Vector3.zero;
        Vector3 scale = Vector3.one * 0.07f;

        public Transform[] tSides;

        public Target(Transform thePrefab, int iter, int zee)
        {
            tSides = new Transform[10];

            Transform oneTarget = Instantiate(thePrefab);
            position.x = (iter + 2.5f) * step - 1f;
            //position.z = -1;
            position.z = zee;
            oneTarget.localPosition = position;
            oneTarget.localScale = scale;

            tSides[iter] = oneTarget;
            //oneTarget.SetParent(transform, false);

            Debug.Log("position.x " + position.x);
        }
    }
}