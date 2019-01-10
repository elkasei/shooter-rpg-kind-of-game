using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventoryToggle : MonoBehaviour {

    [SerializeField] GameObject inventoryGameObject;
    [SerializeField] KeyCode[] toggleInventoryKeys;

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < toggleInventoryKeys.Length; i++)
        {
            if(Input.GetKeyDown(toggleInventoryKeys[i]))
            {
                inventoryGameObject.SetActive(!inventoryGameObject.activeSelf);
                break;
            }

        }
    }
}
