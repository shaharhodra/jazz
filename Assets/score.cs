using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    public float enemyScore;
    public TMP_Text _Text;
    // Start is called before the first frame update
    void Start()
    {
       
        enemyScore = hitPlayer.score;
    }

    // Update is called once per frame
    void Update()
    {
        _Text.text = enemyScore.ToString();
        enemyScore = hitPlayer.score;
        Debug.Log(hitPlayer.score);

    }
}
