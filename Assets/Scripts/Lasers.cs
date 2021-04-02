using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Get on the Disco Train
//https://open.spotify.com/playlist/2lubVUTyTaAn0967rFzf74?si=hfuDodFcRRi2pw6c3hOtgg



public class Lasers : MonoBehaviour
{

    [SerializeField]
    private Graph theLine;

    [SerializeField]
    public Sources sources;




    List<LineRenderer> laserList = new List<LineRenderer>();





    public void Awake()
    {
        sources = FindObjectOfType<Sources>();
        theLine = FindObjectOfType<Graph>();
    }



    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            GameObject oneLiner = new GameObject();
            oneLiner.AddComponent<LineRenderer>();
            LineRenderer lr = oneLiner.GetComponent<LineRenderer>();
            lr.startWidth = 0.01f;
            lr.endWidth = 0.01f;

            laserList.Add(lr);

        }

        Debug.Log("laserList " + laserList[0].startWidth);




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








    void Update()
    {
        float time = Time.time;
        for (int i = 0; i < 3; i++)
        {
            laserList[i].SetPosition(0, sources.sources[i].position);
            laserList[i].SetPosition(1, theLine.singleDrop);
        }

        //laserList[0].SetPosition(0, sources.sources[0].position);
        //laserList[0].SetPosition(1, theLine.singleDrop);

        //Debug.Log("theLine.singleDrop: " + theLine.singleDrop);
        //ln.SetPosition(0, sources.sources[0].position);
        //ln.SetPosition(1, theLine.singleDrop);
    }
}
