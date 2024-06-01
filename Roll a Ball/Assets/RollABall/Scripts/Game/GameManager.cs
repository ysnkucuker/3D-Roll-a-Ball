using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _levelCompletedPanel;
    [SerializeField] private GameObject _gameOverPanel;
    [SerializeField] private int _goldCount;
    [SerializeField] private GameObject _gold;
    [SerializeField] private float _xVector;
    [SerializeField] private float _yVector;
    [SerializeField] private float _zVector;
    // Start is called before the first frame update

    public static GameManager instance;

    public void Awake()
    {
        instance = this;
    }
    void Start()
    {
        GenerateGold();
    }

    // Update is called once per frame
    void Update()
    {
        OpenLevelCompleted();   
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
        Debug.Log(_goldCount);
    }

    #region UI
    public void Pause()
    {
        _gameOverPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void ReStart()
    {
        SceneManager.LoadScene(SceneManager.GetSceneByBuildIndex(0).name);
    }

    public void OpenLevelCompleted()
    {
        if(PlayerCollider.Instance._collectedGold == _goldCount)
        {
            _levelCompletedPanel.SetActive(true);
        }
    }
    #endregion
}
