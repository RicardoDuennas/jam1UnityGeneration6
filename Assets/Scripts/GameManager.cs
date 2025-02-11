using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject canvas;
    public bool isGameOver = false;
    public bool isGameWon = false;
    public int enemiesKilled = 0;
    public GameObject sounds;
    AudioSource audioSource;
    public AudioClip winSound;
    void Start()
    {
        sounds = GameObject.Find("Sounds");
        audioSource = sounds.GetComponent<AudioSource>();
    }
    public void GameOver()
    {
        isGameOver = true;
        Debug.Log("Game Over");
        canvas.GetComponent<UIScreenManager>().gameOverScreen.SetActive(true);
        // Todo lo relacionado al game over
        Time.timeScale = 0; // Detiene el juego
    }    
    public void GameWon()
    {
        isGameWon = true;
        Debug.Log("Game Won");
        canvas.GetComponent<UIScreenManager>().winnerScreen.SetActive(true);
        audioSource.PlayOneShot(winSound, 0.7f);

        // Todo lo relacionado al game won
        Time.timeScale = 0; // Detiene el juego
    }
}
