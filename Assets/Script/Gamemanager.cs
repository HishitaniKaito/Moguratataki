using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using TMPro;

public class Gamemanager : MonoBehaviour
{
    [SerializeField] TMP_Text _scoretext;
    public int _score = 0;
    [SerializeField]List<Mogura> _moguraList;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ScoreAdd()
    {
        Debug.Log("スコア＋１");
        _scoretext.text = $"得点 : {_score}";

    }
}
