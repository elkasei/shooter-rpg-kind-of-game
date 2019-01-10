using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIController : MonoBehaviour {

    public Slider Healthbar;
	public GameObject ReadyToUseObj;

    void Start()
    {

    }

    void Update()
    {

    }

    public void SetHealth(int health)
    {
        if (Healthbar != null)
        {
            Healthbar.value = health / 100.0f;
        }
    }

	public void ReadyToUse(bool show)
	{
		if (ReadyToUseObj != null) 
		{
			ReadyToUseObj.SetActive (show);
		}

	}
}
