//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class DestroyFloor : BallEvents
//{
//    [SerializeField] private LevelGenerator levelGenerator;
//    private int floor = 2;
//    [SerializeField] private Animator animator;
//    List<GameObject> segment;
//    private int segments = 12;
//    private void Start()
//    {
//        segment = new List<GameObject>();
//    }
//    protected override void OnBallCollisionSegment(SegmentType type)
//    {
//        if (type == SegmentType.Empty)
//        {
//            listObj();
//            floor += 1;
//        }
//    }
//    public void listObj()
//    {
//        for (int i = 0; i < levelGenerator.FloorAmount; i++)
//        {
//            segment.Add(GameObject.Find("Floor " + (i + 1)));
//        }
//        for (int i = 1; i < segments; i++)
//        {

//            Transform f = segment[((int)levelGenerator.FloorAmount - floor)].transform.Find("segment");
//            f.GetComponent<MeshCollider>().isTrigger = false;
//            Transform s = segment[((int)levelGenerator.FloorAmount - floor)].transform.Find($"segment ({i})");
//            s.GetComponent<MeshCollider>().isTrigger = false;
//        }
//        segment[((int)levelGenerator.FloorAmount - floor)].GetComponent<Animator>().enabled = true;
//    }
//}
