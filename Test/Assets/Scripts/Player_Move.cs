using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player_Move : MonoBehaviour
{
    public float _speed;

    private bool _isMove;

    public static int _score;

    public Text _scoreText;

    private void FixedUpdate()
    {
        if (_isMove == true)
        {
            transform.Rotate(0, 0, _speed);
        }
        if (_isMove == false)
        {
            transform.Rotate(0, 0, -_speed);
        }
    }

    private void Update()
    {
        _scoreText.text = _score.ToString();

        if (_score > PlayerPrefs.GetInt("highscore"))
        {
            PlayerPrefs.SetInt("highscore", _score);
        }
    }

    public void OnClickPan()
    {
        _isMove = !_isMove;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene(0);
        }
        if (collision.gameObject.tag == "Coin")
        {
            _score++;
        } 
    }
}
