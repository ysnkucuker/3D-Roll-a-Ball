using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoldController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _totalGoldCountText;
    [SerializeField] private int _totalGoldCount;
    [SerializeField] private int _goldIncreaseValue;

    public static GoldController Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        _totalGoldCountText.text = 0.ToString();
    }

    public void IncreaseGold()
    {
        _goldIncreaseValue = Random.Range(1, 10);
        _totalGoldCount += _goldIncreaseValue;
        _totalGoldCountText.text = _totalGoldCount.ToString();
    }
}
