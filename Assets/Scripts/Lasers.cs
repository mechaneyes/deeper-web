//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;


////Get on the Disco Train
////https://open.spotify.com/playlist/2lubVUTyTaAn0967rFzf74?si=hfuDodFcRRi2pw6c3hOtgg



//public class Lasers : MonoBehaviour
//{


//    [SerializeField]
//    public Sources sources;

//    [SerializeField]
//    public Sources sourcesSides;

//    [SerializeField]
//    private Targets_01 targets;

//    [SerializeField]
//    private Targets_02_Sides tSides;

//    [SerializeField]
//    private Targets_01 colorCenter;

//    [SerializeField]
//    private Targets_02_Sides colorSides;

//    List<LineRenderer> laserList = new List<LineRenderer>();
//    List<LineRenderer> laserListSides = new List<LineRenderer>();





//    public void Awake()
//    {
//        sources = FindObjectOfType<Sources>();
//        sourcesSides = FindObjectOfType<Sources>();
//        targets = FindObjectOfType<Targets_01>();
//        tSides = FindObjectOfType<Targets_02_Sides>();
//        colorCenter = FindObjectOfType<Targets_01>();
//        colorSides = FindObjectOfType<Targets_02_Sides>();
//    }





//    void Start()
//    {
//        for (int i = 0; i < sources.sources.Length; i++)
//        {
//            GameObject oneLiner = new GameObject();
//            oneLiner.AddComponent<LineRenderer>();
//            oneLiner.GetComponent<LineRenderer>().material.SetColor("_Color", colorCenter.colorCenter);
//            LineRenderer lr = oneLiner.GetComponent<LineRenderer>();
//            lr.startWidth = 0.01f;
//            lr.endWidth = 0.01f;

//            laserList.Add(lr);

//        }

//        for (int i = 0; i < tSides.tSides.Length; i++)
//        {
//            GameObject oneLiner = new GameObject();
//            oneLiner.AddComponent<LineRenderer>();
//            oneLiner.GetComponent<LineRenderer>().material.SetColor("_Color", Color.green);
//            LineRenderer lr = oneLiner.GetComponent<LineRenderer>();
//            lr.startWidth = 0.01f;
//            lr.endWidth = 0.01f;

//            laserListSides.Add(lr);

//            Debug.Log("colorSides " + colorCenter);

//        }

//        //Debug.Log("sourcesSides " + sourcesSides.sourcesSides.Length);

//    }





//    void Update()
//    {
//        float time = Time.time;
//        //for (int i = 0; i < sources.sources.Length; i++)
//        for (int i = 0; i < 12; i++)
//        {
//            laserListSides[i].GetComponent<LineRenderer>().material.SetColor("_Color", colorCenter.colorCenter);
//            laserList[i].SetPosition(0, sources.sources[i].position);
//            laserList[i].SetPosition(1, targets.targets[i].position);
//        }
//        for ((int i, int j) = (0, 12); j < 24; i++, j++)
//        {
//            laserList[j].SetPosition(0, sources.sources[j].position);
//            laserList[j].SetPosition(1, targets.targets[i].position);
//            //Debug.Log("targets.targets[i].position " + targets.targets[i].position);
//        }

//        for (int i = 0; i < 12; i++)
//        {
//            laserListSides[i].GetComponent<LineRenderer>().material.SetColor("_Color", tSides.colorSides);
//            laserListSides[i].SetPosition(0, sourcesSides.sourcesSides[0].position);
//            laserListSides[i].SetPosition(1, tSides.tSides[i].position);
//        }

//        for (int i = 10; i < 20; i++)
//        {
//            laserListSides[i].GetComponent<LineRenderer>().material.SetColor("_Color", tSides.colorSides);
//            laserListSides[i].SetPosition(0, sourcesSides.sourcesSides[1].position);
//            laserListSides[i].SetPosition(1, tSides.tSides[i].position);
//        }

//        //laserList[0].SetPosition(0, sources.sources[0].position);
//        //laserList[0].SetPosition(1, theLine.singleDrop);
//    }






//    // Inspiration
//    // ---
//    //void DrawLine(Vector3 start, Vector3 end)
//    //{
//    //    GameObject myLine = new GameObject();
//    //    //myLine.transform.position = start;
//    //    myLine.AddComponent<LineRenderer>();
//    //    LineRenderer lr = myLine.GetComponent<LineRenderer>();
//    //    //lr.SetColors(color, color);
//    //    lr.startWidth = 0.01f;
//    //    lr.endWidth = 0.01f;
//    //    lr.SetPosition(0, start);
//    //    lr.SetPosition(1, end);
//    //    GameObject.Destroy(myLine, 0.01f);
//    //}
//}
