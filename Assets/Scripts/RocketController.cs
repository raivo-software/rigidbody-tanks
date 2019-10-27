using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RocketController : MonoBehaviour
{
    public TurretController Turret;
    public EnemyController Enemy;
    public GameObject Explosion;
    private float instantiationTime;

    /* 
     * SetForce-funktion toteutus:
     * Hae Turret-objektilta suunta käyttämällä GetTurretForward() -funktiota.
     * Palautettu arvo on nullable Vector3.
     * Saat tarkasteltua onko nullablella arvoa sen HasValue -kentällä.
     * Saat haettua nullablen sisältämän arvon Value -kentästä.
     * 
     * Anna parametrina saadulle rigidbodylle turrentin suuntainen voima käyttämällä AddForce() -funktiota.
    */
    private void SetForce(Rigidbody rigidbody)
    {
    
    }

    /*
     * Tarkasta OnCollisionEnter -funktiossa, onko osuma tapahtunut Enemyn kanssa.
     * Voit käyttää collision.gameObject ja Enemy.gameObject -kenttiä tarkasteluun
     * 
     * Jos osuman kohde on enemy, niin kutsu Enemy.Explode -funktiota ja oma sijainti parametriksi.
     * Lopuksi tuhoa raketti Destroy -funktiolla.
    */
    private void OnCollisionEnter(Collision collision)
    {
        
    }


    //ÄLÄ MUUTA ALLA OLEVIA FUNKTIOIHIN
    private void Start()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        SetForce(rigidbody);
        instantiationTime = Time.time;
    }

    private void Update()
    {
        if (Time.time - instantiationTime > 3)
            Destroy(gameObject);
    }

    private void OnDestroy()
    {
        GameObject explosion = Instantiate(Explosion);
        explosion.transform.position = transform.position;
    }
}
