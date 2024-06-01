using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("jazzbulet") || other.CompareTag("spazzbulet"))
        {
            Destroy(gameObject);
        }
    }

}
