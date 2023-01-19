using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class MainClick : MonoBehaviour
{
     public double _commonСoins { get; set; }
    public int _coinsPerClick { get; set; }=1 ;
    private Vector3  MousePos;
    [SerializeField] private GameObject _panelpos;
    

    [SerializeField] private TextMeshProUGUI _textcCountClick;
    void Update()
    {

        MousePos = Input.mousePosition;
        if (Input.GetKeyDown(KeyCode.Mouse0) && _panelpos.transform.position.y <= MousePos.y  )
        {
            Debug.Log(MousePos.y);
            _commonСoins=_commonСoins+_coinsPerClick;
            _textcCountClick.text = _commonСoins.ToString();
        }

        if (_commonСoins!=Double.Parse(_textcCountClick.text))
        {
            _textcCountClick.text = _commonСoins.ToString();
        }
    }
}
