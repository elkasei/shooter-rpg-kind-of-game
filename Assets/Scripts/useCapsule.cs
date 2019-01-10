using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class useCapsule : MonoBehaviour, IUsable {

    private LevelManager keyBlue;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

	}

	public void Use()
	{
        Destroy (gameObject);
    }
}
