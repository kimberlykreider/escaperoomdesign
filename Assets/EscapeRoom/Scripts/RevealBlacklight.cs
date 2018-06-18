using UnityEngine;
using System.Collections;

public class RevealBlacklight : Challenge
{
    public Light flashlight;
    public GameObject roomlights;
    public Keypad keypad;
    public bool light = false;
    public GameObject lightswitch;

    public GameObject hiddenMessage;
	// Use this for initialization
	void Start ()
	{
        flashlight.enabled = false;
        keypad.SetChallenge(this);
	}
	
	// Update is called once per frame
	void Update ()
	{
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                if (hit.collider.tag == "BLButton")
                {
                    this.keypad.keypadScreen = true;
                }
                // whatever tag you are looking for on your game object
                if (hit.collider.tag == "Switch")
                {
                    light = !light;
                }
            }
        }
        if (light)
        {
            hiddenMessage.SetActive(true);
            flashlight.enabled = true;
            roomlights.SetActive(false);
        }
        if (!light)
        {
            hiddenMessage.SetActive(false);
            flashlight.enabled = false;
            roomlights.SetActive(true);
        }
	
	}
}

