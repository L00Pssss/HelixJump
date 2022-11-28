using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoresCollector : BallEvents
{
    [SerializeField] private LevelProgress levelProgress;

    [SerializeField] private int scores;

    private int recordScores;
    private int scoreIndex;
    private int accumulateScore;
    public int RecordScores
    {
        get { return recordScores; }

        set { recordScores = value; }
    }
    public int Scores
    {
        get { return scores; }

        set { scores = value; }
    } 
    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type == SegmentType.Empty)
        {
            scoreIndex = 1;
            scores += levelProgress.CurrentLevel + accumulateScore;
            if (scoreIndex == 1)                                                    //���� ������ ����� 1, �� ������������ ���� �� ������ ���������� ���� ������
            {
                accumulateScore++;                                                  //����������� �������� ����
            }
        }


        if (type == SegmentType.Default)                                            //���������� ����������� ������ ���� � �������� ����
        {
            scoreIndex = 0;
            accumulateScore = 0;
        }
    }
}
