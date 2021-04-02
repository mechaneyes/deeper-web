//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;


////https://stackoverflow.com/questions/54695270/multiple-line-renderers-each-following-a-different-object
////https://soundcloud.com/fknyc/francois-k-ital-dub-vibes


//public class Lasers : MonoBehaviour
//{



//    [SerializeField]
//    Transform laserPrefab = default;

//    //[SerializeField, Range(10, 100)]
//    //int resolution = 10;

//    Transform[] ties;
//    //Transform[] lines;




//    public GameObject[] lineObjects;
//    //private LineRenderer[] lnArr;
//    public LineRenderer ln;


//    [SerializeField]
//    private Graph theLine;

//    [SerializeField]
//    public Sources sources;




//    public List<GameObject> lnList = new List<GameObject>();





//    public void Awake()
//    {
//        sources = FindObjectOfType<Sources>();
//        theLine = FindObjectOfType<Graph>();
//    }



//    void Start()
//    {

//        //lnArr = new GameObject[9];

//        //lineObjects = new GameObject();

//        GameObject newLine = new GameObject("Line");
//        for (int i = 0; i < 9; i++)
//        {
//            //GameObject lineObjects[i] = new GameObject();
//            //lnList.Add(someGameObject.GetComponent<YourUnitType>());


//            //GameObject newLine = new GameObject("Line");
//            LineRenderer line = (new GameObject("line")).AddComponent<LineRenderer>(); ;


//            lnList.Add(newLine);
//            //Debug.Log("lRend " + lRend);

//            //lr.startWidth = 0.01f;
//            //lnArr[i].endWidth = 0.01f;

//            //lnArr[i] = ln;
//            //Debug.Log("lnArr[i] " + lnArr[i]);
//        }

//        Debug.Log("lnList " + lnList);



//        lr = new GameObject().AddComponent<LineRenderer>();
//        lr.gameObject.SetParent(transform, false);
//        // just to be sure reset position and rotation as well
//        lr.gameObject.transform.SetPositionAndRotation(Vector3.zero, Quaternion.identity);





//        //Debug.Log("lineRenderer: " + lineRenderer.startWidth);

//        //foreach (Transform t in fromSources.passSources)
//        //for (int j = 0; j < sourcesElements.Length; j++)
//        //{
//        //    Debug.Log("sourcesElements " + sourcesElements[j]);
//        //}

//    }








//    void Update()
//    {
//        float time = Time.time;
//        for (int i = 0; i < 12; i++)
//        {
//            //Transform source = ties[1];
//            //Vector3 position = source.localPosition;

//            //ln.SetPosition(0, sources.sources[0].position);
//            //ln.SetPosition(1, theLine.singleDrop);

//            ////singleDrop = t[i].position;
//            //Debug.Log("source " + source);
//        }

//        //Debug.Log("theLine.singleDrop: " + theLine.singleDrop);
//        //ln.SetPosition(0, sources.sources[0].position);
//        //ln.SetPosition(1, theLine.singleDrop);
//    }
//}
