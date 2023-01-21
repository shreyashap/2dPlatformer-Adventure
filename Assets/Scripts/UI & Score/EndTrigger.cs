using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EndTrigger : MonoBehaviour
{
    public int levelToUnlock;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Level Completed");
            PlayerPrefs.SetInt("levelReached", levelToUnlock);

        }
    }
}
