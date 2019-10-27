using UnityEngine;
using System.Collections;

public class DestroyEffect : MonoBehaviour {
    private float creationTime;

    private void Start()
    {
        creationTime = Time.time;
    }
    void Update ()
	{
        if (Time.time - creationTime > 2) Destroy(gameObject);
	}
}
