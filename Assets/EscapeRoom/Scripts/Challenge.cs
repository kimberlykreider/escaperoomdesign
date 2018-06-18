using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge : MonoBehaviour {

	public bool completed = false;
	public EscapeRoom room;
	public Light completedLight;
    public int number;
	// Use this for initialization
	public virtual void Start () {
		
	}
	public void SetLight(Light l) {
        completedLight = l;
	}

	public void Completed() {
        //room.completed++;
        room.password += this.number;
        switch (room.completed)
        {
            case 0:
                completedLight.color = Color.red;
                break;
            case 1:
                completedLight.color = Color.yellow;
                break;
            case 2:
                completedLight.color = Color.green;
                break;
            case 3:
                completedLight.color = Color.blue;
                break;
            case 4:
                completedLight.color = new Color(0.52F, 0, 0.82F);
                break;
        }
        room.completed++;
        completed = true;
        completedLight.enabled = true;
    }

	// Update is called once per frame
	void Update () {
		if (completed) {
			completedLight.enabled = true;
		}
	}
}
