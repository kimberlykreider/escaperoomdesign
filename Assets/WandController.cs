using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WandController : MonoBehaviour {
    private Valve.VR.EVRButtonId gripButton = Valve.VR.EVRButtonId.k_EButton_Grip;
    private Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;
    private GameObject pickup;
    private SteamVR_TrackedObject trackedObj;
    private SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int) trackedObj.index); } }
	// Use this for initialization
	void Start () {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
	}
	
	// Update is called once per frame
	void Update () {
        if (controller == null)
        {
            Debug.Log("controller not initialized");
            return;
        }

        if (controller.GetPressDown(gripButton) && pickup != null)
        {
            pickup.transform.parent = this.transform;
        }
        if (controller.GetPressUp(gripButton) && pickup != null)
        {
            pickup.transform.parent = null;
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("trigger entered");
        //pickup = collider.gameObject;
    }
    private void OnTriggerExit(Collider collider)
    {
        Debug.Log("trigger exit");
        //pickup = null;
    }
}
