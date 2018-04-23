using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

    private bool played = false;

    void OnTriggerEnter(Collider col)
    {

        if(col.gameObject.tag == "play")
        {
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

    void OnGUI()
    {
        //GUI.DrawTexture(Rect (Screen.width / 2 - 50, Screen.height / 2 - 55, 120, 50), "Pick up Item");
        if (Event.current.keyCode == KeyCode.E)
        {
            played = true;
            PickUp();
        }
    }
}

