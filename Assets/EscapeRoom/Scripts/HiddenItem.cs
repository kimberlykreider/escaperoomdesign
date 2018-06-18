using UnityEngine;
using System.Collections;

public class HiddenItem : Challenge
{

    public GameObject door;
    public float doorAngle;
    bool open = false;
    private Valve.VR.InteractionSystem.Hand hand;
    // Use this for initialization
    public override void Start()
    {
        //hand = gameObject.GetComponent<Valve.VR.InteractionSystem.Hand>();
    }

    void OpenDoor()
    {
        open = true;
        while (doorAngle < 90)
        {
            doorAngle += 0.01f;
            Vector3 euler = door.transform.localEulerAngles;
            euler.z = doorAngle;
            door.transform.localEulerAngles = euler;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                // whatever tag you are looking for on your game object
                if (!open && hit.collider.tag == "Trigger")
                {
                    print("here");
                    OpenDoor();
                }
                else if (hit.collider.tag == "Trigger")
                {
                    this.Completed();
                }
            }
        }
    }
}

