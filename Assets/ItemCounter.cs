using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCounter : MonoBehaviour {

    public int count = 0;
    public int tcount = 4;
    private bool played = false;
    public bool playing = false;
    
	// Use this for initialization
	void Start () {
		
	}

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "count")
        {
            playing = true;
        }
    }

    public void OnGUI()
    {
        if (count < tcount)
        {
            GUI.Box(new Rect((Screen.width / 2) - 100, 10, 200, 35), "" + count + " items found");
        }
        else
        {
            GUI.Box(new Rect((Screen.width / 2) - 100, 10, 200, 35), "You have collected all the ritual items.");
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (playing == true)
        {
            if (Input.GetKey("e"))
            {
                if (!played)
                {
                    count += 1;
                    Debug.Log("You picked up a ritual item. Item = " + count);
                    played = true;
                }

            }
        }
    }
}
