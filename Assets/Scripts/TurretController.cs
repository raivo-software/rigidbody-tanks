using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{
    public Collider RaycastPlane;

    void Update()
    {
        Vector3? turretForward = GetTurretForward();
        if(turretForward.HasValue)
            transform.forward = turretForward.Value;
    }

    public Vector3? GetTurretForward()
    {
        RaycastHit hitInfo;
        bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
        if (hit && hitInfo.collider == RaycastPlane)
            return hitInfo.point - transform.position;
        return null;
    }
}
