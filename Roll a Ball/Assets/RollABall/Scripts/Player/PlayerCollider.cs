using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    [SerializeField] public int _collectedGold = 0;
    [SerializeField] private PlayerEffectController playerEffectController;
    public PlayerScore playerScore;

    public static PlayerCollider Instance;

    private void Awake()
    {
        Instance = this;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gold"))
        {
            Destroy(other.gameObject);
            playerScore.IncreaseScore();
            GoldController.Instance.IncreaseGold();
            // GetComponent<PlayerEffectController>().PlayGoldParticleEffect(); Maliyetli
            playerEffectController.PlayGoldParticleEffect(other.transform.position); //2. Yol
            // playerEffectController.CreateParticleEffect(other.transform.position); 3. Yol
            _collectedGold++;
            //GameManager.instance.OpenLevelCompleted();
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
