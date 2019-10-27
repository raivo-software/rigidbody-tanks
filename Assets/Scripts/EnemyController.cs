using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class EnemyController : MonoBehaviour
{
    public TextMesh GameOverText;
    private float explosionTime = 0;

    private void Update()
    {
        if (explosionTime != 0 && explosionTime + 2 < Time.time)
            GameOverText.gameObject.SetActive(true);
    }

    public void Explode(Vector3 explosionPosition)
    {
        explosionTime = Time.time;
        /*
         * Toteuta Explode funktion loppuosa:
         * Aseta gameObjectista löytyvän Rigidbody -komponentin isKinematic -kentäksi false.
         * Lisää Rigidbodylle myös räjähdys, käyttämällä AddExplosionForce -funktiota.
         */


    }
}
