using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretBehaviour : MonoBehaviour {

    Transform player;
    public Transform bulletShooterTurret;
    public GameObject bullet;

    void Awake()
    {
        player = GameObject.FindWithTag ("Player").transform;
    }

    void Update() {
        transform.LookAt(player);
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine("Shooting");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StopCoroutine("Shooting");
        }
    }

    IEnumerator Shooting()
    {
        while (true)
        {
            Instantiate(bullet, bulletShooterTurret.position, bulletShooterTurret.rotation);
            yield return new WaitForSeconds(1);
        }
    }
}
