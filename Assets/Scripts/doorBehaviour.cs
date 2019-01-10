using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorBehaviour : MonoBehaviour {

    private LevelManager keyBlue;

    void Update()
    {
        if (GameObject.FindWithTag("Blue Key") == null)
        {
            Destroy(GameObject.FindWithTag("Door"));
        }
    }
}
