using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ScriptPref : MonoBehaviour
{
    [SerializeField] private List<GameObject> _prefabOverrides=new (144);
    [SerializeField] private GameObject _connectbuy;
    private int _countadd;
     private MainClick  mainclick { get; set; }
    private void Start()
    {
       mainclick = FindObjectOfType<MainClick>();
    }

    public void CountAdd(GameObject value)
    {
        _countadd = 0;
        for (int i = 0; i < _prefabOverrides.Count; i++)
        {
            _countadd++;
            GameObject gameObject = _prefabOverrides[i];
            
            if (gameObject ==value)
            {
                double buy = FindObjectOfType<BuyAndLvl>().st(_countadd+3);
                if (mainclick._commonСoins>=buy)
                {
                    mainclick._commonСoins = mainclick._commonСoins-buy;
                    
                    mainclick._coinsPerClick += _countadd;
                    value.SetActive(false);
                    break;
                }
                
                
            }

        }
    }
}
