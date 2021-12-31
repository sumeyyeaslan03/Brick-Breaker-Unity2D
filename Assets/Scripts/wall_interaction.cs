using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class wall_interaction : MonoBehaviour
{
    public Rigidbody2D rb_ball;
    public float horizontal_speed, vertical_speed;
    public GameObject ballObj, playerObj, restartButton;
    public TextMeshProUGUI score_Text, win_text;

    void Start()
    {
        Win.score=0;
        Time.timeScale=1;
        restartButton.SetActive(false);
        rb_ball.velocity = new Vector2(Random.Range(-vertical_speed,vertical_speed), rb_ball.velocity.y);
    }


    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag=="Player")
        {
            rb_ball.velocity=new Vector2(rb_ball.velocity.x, horizontal_speed);
        }

        if(other.gameObject.tag=="wallLeft")
        {
            rb_ball.velocity = new Vector2(vertical_speed, rb_ball.velocity.y);
        }

        if(other.gameObject.tag=="wallRight")
        {
            rb_ball.velocity = new Vector2(-vertical_speed, rb_ball.velocity.y);
        }

        if(other.gameObject.tag=="wallTop")
        {
            rb_ball.velocity=new Vector2(rb_ball.velocity.x, -horizontal_speed);
        }

        if(other.gameObject.tag=="hiddenGround")
        {
            win_text.text="You Lost!\n Score: "+ Win.score ;       
            Time.timeScale=0;
            restartButton.SetActive(true);
            Destroy(score_Text);
            Destroy(playerObj);
            Destroy(ballObj);

        }
    }
}
