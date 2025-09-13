using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Basket : MonoBehaviour
{

    public TextMeshProUGUI scoreGT;
    public TextMeshProUGUI roundGT;

    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        scoreGT = scoreGO.GetComponent<TextMeshProUGUI>();
        scoreGT.text = "0";
        GameObject roundGO = GameObject.Find("Round");
        roundGT = roundGO.GetComponent<TextMeshProUGUI>();
        roundGT.text = "Round 1";
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos2D = Input.mousePosition;

        mousePos2D.z = -Camera.main.transform.position.z;

        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;

    }


    void OnCollisionEnter(Collision coll)
    {
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.tag == "Apple")
        {
            Destroy(collidedWith);

            int score = int.Parse(scoreGT.text);
            score += 100;
            scoreGT.text = score.ToString();

            //
            string round = "Round 1";
            if (score >= 3000) round = "Round 4";
            else if (score >= 2000) round = "Round 3";
            else if (score >= 1000) round = "Round 2";
            else round = "Round 1";
            roundGT.text = round;

            //

            if (score > HighScore.score)
            {
                HighScore.score = score;
            }
        }
        else if (collidedWith.tag == "Branch")
        {
            Destroy(collidedWith);

            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
            apScript.AppleDestroyed();
        }
    }
}
