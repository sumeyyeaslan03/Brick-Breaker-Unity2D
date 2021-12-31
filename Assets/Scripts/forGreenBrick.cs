using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forGreenBrick : MonoBehaviour
{
    private int _brick_healt=2;
    private MeshRenderer _rend;
    public Material broken;

    public AudioSource brick_Sound;

    void Start()
    {
        _rend= GetComponent<MeshRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag=="Ball")
        {
            brick_Sound.Play();
            _brick_healt--;
            Win.score+=5;
        }

        if(_brick_healt==0)
        {
            Destroy(this.gameObject);
        }

        if(_brick_healt ==1)
        {
            _rend.material= broken;
        }
    }
}
