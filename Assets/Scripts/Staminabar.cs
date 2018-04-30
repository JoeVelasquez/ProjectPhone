using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Staminabar : MonoBehaviour {

    public float staminaDrain = 1F;
    public float stamina = 100;
    public float maxstamina = 100;
    public Image currentstamina;

    public bool run;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            run = true; 
        }
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            run = false;
        }

        if (run == true && stamina >= 0)
        {
            stamina -= Time.deltaTime * staminaDrain;
            float ratio = stamina / maxstamina;
            currentstamina.rectTransform.localScale = new Vector3(ratio, 1, 1);
        }
        if (run == false && stamina >= 0)
        {
            stamina += Time.deltaTime * staminaDrain;
            float ratio = stamina / maxstamina;
            currentstamina.rectTransform.localScale = new Vector3(ratio, 1, 1);
        }
        if (stamina == 0)
        {
            run = false;
            stamina -= Time.deltaTime * staminaDrain;
            float ratio = stamina / maxstamina;
            currentstamina.rectTransform.localScale = new Vector3(ratio, 1, 1);
        }
	}
}
