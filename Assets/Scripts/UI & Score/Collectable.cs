using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public Score score;
    private AudioManager aManager;
 

    private void Start()
    {
        aManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            aManager.audioSource.PlayOneShot(aManager.collectibleAudio);
            Destroy(this.gameObject);
            score.UpdateScore(5);
        }
    }
    
}
