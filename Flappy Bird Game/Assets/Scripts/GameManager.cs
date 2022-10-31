using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject scoreCanvas;
    public GameObject scorevalue;
    public GameObject bestScore;
    public GameObject newBS;
    public GameObject bird;
    // Start is called before the first frame update

    private void Start()
    {
        bestScore.GetComponent<UnityEngine.UI.Text>().text = PlayerPrefs.GetInt("HighScore").ToString();
        gameOverCanvas.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    public void GameOver()
    {
        scorevalue.GetComponent<UnityEngine.UI.Text>().text = Score.score.ToString();
        if(Score.score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", Score.score);
            bestScore.GetComponent<UnityEngine.UI.Text>().text = PlayerPrefs.GetInt("HighScore").ToString();
            newBS.SetActive(true);
        }
        gameOverCanvas.SetActive(true);
        scoreCanvas.SetActive(false);
        Time.timeScale = 0;
    }

    public void Replay(){
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
