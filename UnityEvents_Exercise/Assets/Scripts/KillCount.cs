using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[CreateAssetMenu(fileName = "KillCount", menuName = "ScriptableObjects/KillCount", order = 1)]
public class KillCount : ScriptableObject
{
    public GameObject killCountInterface;
    public TextMeshProUGUI killCountTextGUI;

    private int _killCount; // class member
    public int killCount // property = container for getter/setter
    {
        get
        {
            return _killCount;
        }
        set
        {
            killCountInterface = GameObject.Find("KC_Counter");
            killCountTextGUI = killCountInterface.GetComponent<TextMeshProUGUI>();
            killCountTextGUI.text = value.ToString();
            _killCount = value;
        }
    }

    private void OnEnable()
    {
        //initialization
        killCount = 0;
    }

}
