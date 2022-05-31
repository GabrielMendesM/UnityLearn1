using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    const string BEST_NAME = "BestName";
    const string BEST_SCORE = "BestScore";

    public static string Name { get; set; }

    public static string BestName
    {
        get
        {
            return PlayerPrefs.GetString(BEST_NAME, "Nameless");
        }
        set
        {
            PlayerPrefs.SetString(BEST_NAME, value);
            PlayerPrefs.Save();
        }
    }
    public static int BestScore
    {
        get
        {
            return PlayerPrefs.GetInt(BEST_SCORE, 0);
        }
        set
        {
            PlayerPrefs.SetInt(BEST_SCORE, value);
            PlayerPrefs.Save();
        }
    }
}
