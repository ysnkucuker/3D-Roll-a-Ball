using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldSpawner : MonoBehaviour
{
    public GameObject _gold;
    public int _goldNumber;
    public float _xVector, _yVector, _zVector;

    void Start()
    {
        SpawnGold();
    }

    public void SpawnGold()
    {
        for (int i = 0; i < _goldNumber; i++)
        {
            Instantiate(_gold, new Vector3(_xVector, _yVector, _zVector), Quaternion.identity);
            if (i % 3 == 2)
            {
                _zVector += 3;
                _xVector = -2.5f;
            }
            _xVector += 2;
        }
        
    }
}
