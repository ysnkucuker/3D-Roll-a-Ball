using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEffectController : MonoBehaviour
{
    [SerializeField] private GameObject _particlePrefab;
    [SerializeField] private ParticleSystem _goldParticleEffect;
    public void PlayGoldParticleEffect(Vector3 position)
    {
        _goldParticleEffect.transform.position = position;
        _goldParticleEffect.gameObject.SetActive(true);
        _goldParticleEffect.Play();
    }

    public void CreateParticleEffect(Vector3 position)
    {
        GameObject particle = Instantiate(_particlePrefab, position, Quaternion.identity);
        _particlePrefab.gameObject.SetActive (true);
        particle.GetComponent<ParticleSystem>().Clear();
        particle.GetComponent<ParticleSystem>().Play();
    }
 
}
