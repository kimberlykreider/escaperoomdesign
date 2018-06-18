using UnityEngine;
using System.Collections;

public class NumberFromPicture : Challenge
{
	public Keypad keypad;
	// Use this for initialization
	public override void Start ()
	{
		keypad.SetChallenge (this);
	}
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                // whatever tag you are looking for on your game object
                if (hit.collider.tag == "NFPButton")
                {
                    keypad.keypadScreen = true;
                }
            }
        }
    }
}

