using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int _goldCount;
    [SerializeField] private GameObject _gold;
    [SerializeField] private float _xVector;
    [SerializeField] private float _yVector;
    [SerializeField] private float _zVector;
    // Start is called before the first frame update
    void Start()
    {
        GenerateGold();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateGold()
    {
        for(int i=0; i<_goldCount; i++)
        {
            if(i % 15 == 0)
            {
                _xVector = -21;
                _zVector -= 5;
            }
            Instantiate(_gold, new Vector3(_xVector, _yVector, _zVector), Quaternion.identity);
            _xVector += 3;
        }
        
    }
}
