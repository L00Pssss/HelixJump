using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScoreText : BallEvents
{
    [SerializeField] private ScoresCollector scoresCollector;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text scroeRecordText;
    [SerializeField] private string markMaxScoreText;

    private void Start()
    {
        scroeRecordText.text = markMaxScoreText + ": " + scoresCollector.RecordScores;
    }

  //  public string ScoreRecordText => scroeRecordText.ToString();
    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type != SegmentType.Trap)
        {
            scoreText.text = scoresCollector.Scores.ToString();
        }

        if (type != SegmentType.Trap)
        {
            scroeRecordText.text = markMaxScoreText + ": " + scoresCollector.RecordScores;
        }
    }
}
