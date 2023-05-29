using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using TMPro;

public class Gamemanager : MonoBehaviour
{
    [SerializeField] TMP_Text _scoretext;
    public int _score = 0;
    // Start is called before the first frame update
    void Start()
    {
        _scoretext.text = $"得点 : {_score}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ScoreAdd()
    {
        _score++;
        Debug.Log("スコア＋１");
        _scoretext.text = $"得点 : {_score}";

    }
}
