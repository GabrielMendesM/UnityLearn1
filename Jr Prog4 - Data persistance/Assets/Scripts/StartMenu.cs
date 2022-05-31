using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    public Text bestScoreText;

    public InputField inputField;

    private void Start()
    {
        bestScoreText.text = "Best score: " + Player.BestName + " : " + Player.BestScore;
    }

    public void StartGame()
    {
        Player.Name = string.IsNullOrEmpty(inputField.text) ? "Nameless" : inputField.text;

        SceneManager.LoadScene(0);
    }
}
