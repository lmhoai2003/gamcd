using UnityEngine;
using Fusion;
using TMPro;
using System;
using UnityEngine.UI;


public class PlayerProperties : NetworkBehaviour
{

    [Networked, OnChangedRender(nameof(OnHPChanged))]
    public int _hpPlayer { get; set; } = 100;


    public TextMeshPro hpText;

    public TextMeshPro nameText;

    public void OnHPChanged()
    {
        hpText.text = _hpPlayer.ToString() + "\ncon nice";
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("emi"))
        {
            _hpPlayer -= 10;
            if (_hpPlayer <= 0)
            {
                _hpPlayer = 0;
            }
            Debug.Log("va cham voi quai hehe: " + _hpPlayer);
        }
    }

    //làm cho text hiện luôn quay về phía camera
    private void Update()
    {
        if (hpText != null)
        {
            hpText.transform.LookAt(Camera.main.transform);
            hpText.transform.Rotate(0, 180, 0); // Đảo ngược hướng nhìn
        }
        if (nameText != null)
        {
            nameText.transform.LookAt(Camera.main.transform);
            nameText.transform.Rotate(0, 180, 0); // Đảo ngược hướng nhìn
        }

    }
    void Start()
    {
        if (nameText != null)
        {
            // Lấy tên người chơi từ PlayerPrefs
            string playerName = PlayerPrefs.GetString("PlayerName");
            nameText.text = playerName;
        }
    }


}
