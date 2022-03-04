using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Text _highScoreText;

    private void Start()
    {
        _highScoreText.text = "HIGHSCORE: " + PlayerPrefs.GetInt("highscore");
    } 

    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }
}
