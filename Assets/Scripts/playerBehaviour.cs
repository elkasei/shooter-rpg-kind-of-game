using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBehaviour : MonoBehaviour
{
    float bulletSpeed = 1100;
    public GameObject bullet;
	public Transform ViewCamera;
	public float DistanceToUse = 2;
	private IUsable _focusedUsable; 

    void Fire()
    {
        GameObject tempBullet = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
        Rigidbody tempRigidBodyBullet = tempBullet.GetComponent<Rigidbody>();
        tempRigidBodyBullet.AddForce(tempRigidBodyBullet.transform.forward * bulletSpeed);
        Destroy(tempBullet, 0.3f);
    }

    void OnTriggerEnter(Collider collider)
    {
        Destroy(bullet.gameObject);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }

		RaycastHit result = new RaycastHit ();
		if (Physics.Raycast (ViewCamera.position, ViewCamera.forward, out result, DistanceToUse)) 
		{
			IUsable tempUsable = result.collider.GetComponent<IUsable> ();

			if (tempUsable != null) {
				_focusedUsable = tempUsable;
				LevelManager.Instance.UIController.ReadyToUse (true);
			} 
			else 
			{
				LevelManager.Instance.UIController.ReadyToUse (false);
				_focusedUsable = null;
			}
		}

		else 
		{
			LevelManager.Instance.UIController.ReadyToUse (false);
			_focusedUsable = null;
		}


		if (Input.GetKeyDown (KeyCode.E) && _focusedUsable != null) 
		{
			_focusedUsable.Use ();

		}
    }
}
