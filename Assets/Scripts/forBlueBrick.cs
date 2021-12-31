using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forBlueBrick : MonoBehaviour
{
    private int _brick_healt=1;
    public AudioSource brick_Sound;

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag=="Ball")
        {
            _brick_healt--;
            Win.score+=10;
            brick_Sound.Play();
        }

        if(_brick_healt==0)
        {
            Destroy(this.gameObject);
        }
    }
}
