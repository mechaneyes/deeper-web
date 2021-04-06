using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Get on the Disco Train
//https://open.spotify.com/playlist/2lubVUTyTaAn0967rFzf74?si=hfuDodFcRRi2pw6c3hOtgg



public class Lasers : MonoBehaviour
{


    [SerializeField]
    public Sources sources;

    [SerializeField]
    private Graph targets;

    List<LineRenderer> laserList = new List<LineRenderer>();





    public void Awake()
    {
        sources = FindObjectOfType<Sources>();
        targets = FindObjectOfType<Graph>();
    }





    void Start()
    {
        for (int i = 0; i < sources.sources.Length; i++)
        {
            GameObject oneLiner = new GameObject();
            oneLiner.AddComponent<LineRenderer>();
            oneLiner.GetComponent<LineRenderer>().material.SetColor("_Color", Color.red);
            LineRenderer lr = oneLiner.GetComponent<LineRenderer>();
            lr.startWidth = 0.01f;
            lr.endWidth = 0.01f;

            laserList.Add(lr);

        }

        //Debug.Log("laserList " + laserList[0].startWidth);
        //Debug.Log("sources.sources.Length " + sources.sources.Length);

    }





    void Update()
    {
        float time = Time.time;
        //for (int i = 0; i < sources.sources.Length; i++)
        for (int i = 0; i < 12; i++)
        {
            laserList[i].SetPosition(0, sources.sources[i].position);
            laserList[i].SetPosition(1, targets.targets[i].position);
        }
        for ((int i, int j) = (0, 12); j < 24; i++, j++)
        {
            laserList[j].SetPosition(0, sources.sources[j].position);
            laserList[j].SetPosition(1, targets.targets[i].position);
            Debug.Log("targets.targets[i].position " + targets.targets[i].position);
        }

        //laserList[0].SetPosition(0, sources.sources[0].position);
        //laserList[0].SetPosition(1, theLine.singleDrop);
    }






    // Inspiration
    // ---
    //void DrawLine(Vector3 start, Vector3 end)
    //{
    //    GameObject myLine = new GameObject();
    //    //myLine.transform.position = start;
    //    myLine.AddComponent<LineRenderer>();
    //    LineRenderer lr = myLine.GetComponent<LineRenderer>();
    //    //lr.SetColors(color, color);
    //    lr.startWidth = 0.01f;
    //    lr.endWidth = 0.01f;
    //    lr.SetPosition(0, start);
    //    lr.SetPosition(1, end);
    //    GameObject.Destroy(myLine, 0.01f);
    //}
}
