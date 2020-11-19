using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextWaveButton : MonoBehaviour
{
    [SerializeField] private Spawner _spawner;
    [SerializeField] private Button _nextWaveButton;

    private void OnEnable()
    {
        _spawner.AllEnemySpawned += OnAllEnemiesSpawned;
        _nextWaveButton.onClick.AddListener(OnNextWaveButtonClicked);
    }

    private void OnDisable()
    {
        _spawner.AllEnemySpawned -= OnAllEnemiesSpawned;
        _nextWaveButton.onClick.RemoveListener(OnNextWaveButtonClicked);
    }

    private void OnAllEnemiesSpawned() 
    {
        _nextWaveButton.gameObject.SetActive(true);
    }

    private void OnNextWaveButtonClicked() 
    {
        _spawner.SetNextWave();
        _nextWaveButton.gameObject.SetActive(false);
    }
}
