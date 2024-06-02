using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoldController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _totalGoldCountText;
    [SerializeField] private int _totalGoldCount = 0;
    [SerializeField] private int _goldIncreaseValue;

    public static GoldController Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        GetGoldData();
        
        _totalGoldCountText.text = _totalGoldCount.ToString();
    }

    public void IncreaseGold()
    {
        _goldIncreaseValue = Random.Range(1, 10);
        _totalGoldCount += _goldIncreaseValue;
        _totalGoldCountText.text = _totalGoldCount.ToString();
        PlayerPrefs.SetInt("goldData", _totalGoldCount);
    }

    public void DecreaseGold()
    {
        _totalGoldCount--;
        if(_totalGoldCount < 0)
        {
            _totalGoldCount = 0;
        }
        _totalGoldCountText.SetText(_totalGoldCount.ToString());
        PlayerPrefs.SetInt("goldData", _totalGoldCount);
    }

    public void GetGoldData()
    {
        if (PlayerPrefs.HasKey("goldData"))
        {
            _totalGoldCount = PlayerPrefs.GetInt("goldData", 0);
        }
       
    }
}
