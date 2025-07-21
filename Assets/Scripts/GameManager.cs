using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private List<GameObject> bullets;
    private int _score;
    public event Action<int> OnScoreChanged;
    
    void Start()
    {
        bullets ??= new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onBulletSpawned(GameObject bullet)
    {
        Debug.Log("onBulletSpawned");
        bullets.Add(bullet);
    }

    public void onRestart()
    {
        foreach (var bullet in bullets)
        {
            Destroy(bullet);
        }
        bullets.Clear();
        _score = 0;
        OnScoreChanged?.Invoke(_score);
    }

    public void UpdateScore(int scoreValue)
    {
        this._score += scoreValue;
        OnScoreChanged?.Invoke(_score);
    }
    
    public int GetScore()
    {
        return _score;
    }
    
}
