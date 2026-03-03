using UnityEngine;

public class BattleFlow : MonoBehaviour
{
    public GameObject gameOverUI;
    public PlayerHealth playerHealth;
    public GameObject bgMusic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        gameOverUI.SetActive(false);
        playerHealth.onDead += OnGameOver;
    }

    private void OnGameOver()
    {
        gameOverUI.SetActive(true);
        bgMusic.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
