using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketLauncher : MonoBehaviour
{
    public GameObject RocketPrefab;
    public TurretController Turret;
    public EnemyController Enemy;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            LaunchRocket();
    }

    void LaunchRocket()
    {
        GameObject newRocket = Instantiate(RocketPrefab);
        newRocket.GetComponent<RocketController>().Turret = Turret;
        newRocket.GetComponent<RocketController>().Enemy = Enemy;
        newRocket.transform.position = transform.position;
        Vector3? turretForward = Turret.GetTurretForward();
        if (turretForward.HasValue)
            newRocket.transform.forward = turretForward.Value;
    }
}
