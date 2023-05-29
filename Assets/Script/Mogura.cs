using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mogura : MonoBehaviour
{
    [SerializeField]float _time = 0.0f;
    [SerializeField]float _timer = 0.0f;
    [SerializeField] Animator _anim;
    Gamemanager _gm;
    [SerializeField]bool _click = true;
    Collider _co;

    // Start is called before the first frame update
    void Start()
    {
        _co = GetComponent<Collider>();
        _gm = FindObjectOfType<Gamemanager>();
        _time = Random.Range(3,7);
    }

    // Update is called once per frame
    void Update()
    {
        
        if(_time < _timer)
        {
            _anim.Play("MoguraAnim");
            _time = Random.Range(3,7);
            _timer = 0.0f;
        }
        _timer += Time.deltaTime; 
        if(Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();
            if(Physics.Raycast(ray,out hit))
            {
                if (hit.collider == _co)
                {
                    OnClick();
                }

            }
        }
    }
    private void OnClick()
    {
        if(_click)
        {
            _gm.ScoreAdd();
            _click = false;
        }
        Debug.Log("クリックされた");
    }
    public void Out()
    {
        _click = true;
    }
}
