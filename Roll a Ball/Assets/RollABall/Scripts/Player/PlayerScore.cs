using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    private int _totalGold = 0;
    private int _point;
    public void IncreaseScore()
    {
        _point = Random.Range(0, 10);
        _totalGold += _point;
        Debug.Log("Point : " + _point);
        Debug.Log("Total Point : " + _totalGold);
    }
}
