using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

    public bool buttonInRanged;
    private bool played = false;

    void OnTriggerEnter(Collider col)
    {

        if(col.gameObject.tag == "play")
        {
            OnGUI();
            
            PickUp();
        }
    }
	
    public void PickUp()
    {
        Light PhoneLight = Camera.main.gameObject.GetComponent<Light>();

        if(played == true)
        {
            Object.Destroy(gameObject);

        }
    }

    public void OnGUI()
    {
        GUI.Label(new Rect (Screen.width / 2 - 50, Screen.height / 2 - 55, 120, 50), "Pick up Item");

    }

    void Update()
    {

    }
}

