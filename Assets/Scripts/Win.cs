using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public GameObject textObj, playerObj, ballObj,restartButton;
    public TextMeshProUGUI win_text, score_Text;
    public Transform Bricks;
    int _numberBrick;
    public static int score;
    
    void Start()
    {
        score=0;
        Time.timeScale=1;
        restartButton.SetActive(false);
    }

    void Update()
    {
        score_Text.text= "Score: " + score;
        _numberBrick = Bricks.childCount;

        if(_numberBrick == 0)
        {
            win_text.text="Congratulations!\n Score: "+ score ;
            Time.timeScale=0;
            restartButton.SetActive(true);
            Destroy(textObj);
            Destroy(playerObj);
            Destroy(ballObj);
        }
    }

    public void forRestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene(). buildIndex);
    }
}
