using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeRoom : MonoBehaviour {

	public GameObject door;

	[HeaderAttribute("Puzzles")]
	public GameObject first_puzzle;
	public GameObject second_puzzle;
	public GameObject third_puzzle;
	public GameObject fourth_puzzle;
	public GameObject fifth_puzzle;

	[HeaderAttribute("Lights")]
	public Light firstLight;
    public GameObject lightbulb1;
	public Light secondLight;
    public GameObject lightbulb2;
	public Light thirdLight;
    public GameObject lightbulb3;
	public Light fourthLight;
    public GameObject lightbulb4;
	public Light fifthLight;
    public GameObject lightbulb5;

	private Challenge p1;
	private Challenge p2;
	private Challenge p3;
	private Challenge p4;
	private Challenge p5;

    public GameObject exit;
    public KeypadExit keypad;
	public int completed = 0;
	private float doorAngle = 360;
    public string password;
    public int numPuzzles = 0;
	// Use this for initialization
	void Start () {
        keypad.SetRoom(this);
		if (first_puzzle != null) {
            numPuzzles++;
            lightbulb1.SetActive(true);
			first_puzzle.SetActive (true);
			p1 = first_puzzle.GetComponent<Challenge> ();
			p1.SetLight (firstLight);
            p1.number = 1;
		}

		if (second_puzzle != null) {
            numPuzzles++;
            lightbulb2.SetActive(true);
            second_puzzle.SetActive (true);
			p2 = second_puzzle.GetComponent<Challenge>();
            p2.SetLight(secondLight);
            p2.number = 2;
		}

		if (third_puzzle != null) {
            numPuzzles++;
            lightbulb3.SetActive(true);
            third_puzzle.SetActive (true);
			p3 = third_puzzle.GetComponent<Challenge> ();
			p3.SetLight (thirdLight);
            p3.number = 3;
		}

		if (fourth_puzzle != null) {
            numPuzzles++;
            lightbulb4.SetActive(true);
            fourth_puzzle.SetActive (true);
			p4 = fourth_puzzle.GetComponent<Challenge> ();
			p4.SetLight (fourthLight);
            p4.number = 4;
		}

		if (fifth_puzzle != null) {
            numPuzzles++;
            lightbulb5.SetActive(true);
            fifth_puzzle.SetActive (true);
			p5 = fifth_puzzle.GetComponent<Challenge> ();
			p5.SetLight (fifthLight);
            p5.number = 5;
		}
	}

    public void OpenDoor()
    {
        if (doorAngle > 270)
        {
            doorAngle -= 0.5f;
            Vector3 euler = door.transform.localEulerAngles;
            euler.z = doorAngle;
            door.transform.localEulerAngles = euler;
        }
    }
	// Update is called once per frame
	void Update () {
		if (completed == numPuzzles) {
            keypad.curPassword = password;
            exit.SetActive(true);
		}
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                // whatever tag you are looking for on your game object
                if (hit.collider.tag == "Exit")
                {
                    keypad.curPassword = password;
                    keypad.keypadScreen = true;
                }
            }
        }
    }
}
