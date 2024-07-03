using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public GameObject gameOver;
    public float score;

    public Text scoreText;
    public int scoreCoin;
    public Text coinText;
    private Player player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!player.isDead)
        {
            UpdateScore();
        }
    }

    public void ShowGameOver()
    {
        gameOver.SetActive(true);
    }

    private void UpdateScore()
    {
        score += Time.deltaTime * 10f;
        scoreText.text = Mathf.Round(score).ToString() + "m";
    }

    public void addCoin()
    {
        scoreCoin++;
        coinText.text = scoreCoin.ToString();
    }
}
