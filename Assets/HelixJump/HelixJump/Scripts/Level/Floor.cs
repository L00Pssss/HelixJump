using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    [SerializeField] private List<Segment> defaultSegmets;

    public List<Segment> Def
    {
        get
        { return defaultSegmets; }
    }

    public void AddEmptySegment(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            defaultSegmets[i].SetEmpty();
        }
        // Обратный цикл, так как при удалении, масив сдвигается влево
        for (int i = amount; i >= 0; i--)
        {
            defaultSegmets.RemoveAt(i);
        }
    }

    public void AddRandomTrapSegment(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            int index = Random.Range(0, defaultSegmets.Count);

            defaultSegmets[index].SetTrap();
            defaultSegmets.RemoveAt(index);
        }
    }

    public void SetRandomRotation()
    {
        transform.eulerAngles = new Vector3(0, Random.Range(0, 360), 0);
    }

    public void SetFinmishSegment()
    {
        for (int i = 0; i < defaultSegmets.Count; i++)
        {
            defaultSegmets[i].SetFinish();
        }
    }
}
