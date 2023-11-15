using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameCount : MonoBehaviour
{
    public int fixedBots;
    public GameObject winGames;
    public GameObject healthBar;
    public TMP_Text robotsFixed;
    // Start is called before the first frame update
    void Start()
    {
        fixedBots = 0;
    }

    // Update is called once per frame
    void Update()
    {
        robotsFixed.SetText("Fixed Robots: " + fixedBots);
        if(fixedBots == 4)
        {
            GameWin();
        }
    }

    public void GameWin()
    {
        healthBar.SetActive(false);
        winGames.SetActive(true);
        Time.timeScale = 0;
        if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
