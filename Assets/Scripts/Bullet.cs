using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private GameObject _effectPrefab;
  

    void Start()
    {
        
        Destroy(gameObject, 3f);

    }

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(_effectPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

}
