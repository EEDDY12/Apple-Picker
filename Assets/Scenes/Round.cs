using TMPro;
using UnityEngine;

public class Round : MonoBehaviour
{
    static public int score = 1000;
    static public string round = "Round 1";

    private TextMeshProUGUI gt;

    void Awake()
    {
        gt = GetComponent<TextMeshProUGUI>();   // cache reference
        PlayerPrefs.SetString("Round", round);
    }

    void Update()
    {
        score = PlayerPrefs.GetInt("ScoreCounter");

        if (score >= 3000)      round = "Round 4";
        else if (score >= 2000) round = "Round 3";
        else if (score >= 1000) round = "Round 2";
        else                    round = "Round 1";

        // **Update on-screen text**
        gt.text = round;

        // Optional: only save when it changes, not every frame
        PlayerPrefs.SetString("Round", round);
    }
}
