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
            GoldController.Instance.IncreaseGold();
        }

    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Obstecle"))
        {
            GoldController.Instance.DecreaseGold();
        }

        if (collision.gameObject.CompareTag("Obstecle1"))
        {
            GameManager.instance.Pause();
        }
    }
}
