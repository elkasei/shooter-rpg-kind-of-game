using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour 
{
	public static LevelManager Instance;

	public UIController UIController;
	public playerBehaviour Player;
    public bool keyBlue;
    void Start () 
	{
        keyBlue = false;

		if (Instance != null) {
			Debug.LogError ("Instance je už zabraná");
		} 

		else 
		{
			Instance = this;
		}
	}
	
	void Update () 
	{
        if (GameObject.FindWithTag("Blue Key") == null)
        {
            keyBlue = true;
            Destroy(GameObject.FindWithTag("Door"));
        }
    }
}
