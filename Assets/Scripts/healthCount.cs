using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class healthCount : MonoBehaviour 
{

	public bool ShowHealth = false;

	public int Health
	{
		get
		{
			return health;
		}

		set
		{
			health = value;
		}
	}

	private int health = 100;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "enemyBullet(Clone)")
        {
            Health -= 15;
        }

        if (col.gameObject.name == "playerBullet(Clone)")
        {
            Health -= 15;
        }

		if (Health <= 0)
        {
            Destroy(gameObject);
        }

        if (col.gameObject.tag == "pickupHealth")
        {
			Health += 25;
            Destroy(col.gameObject);
        }
    }
}
