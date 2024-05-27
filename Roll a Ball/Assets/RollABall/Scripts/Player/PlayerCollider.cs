using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    public PlayerScore playerScore;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gold"))
        {
            Destroy(other.gameObject);
            playerScore.IncreaseScore();
        }
    }
}
