using UnityEngine;
using System.Collections;

public class KeypadExit : MonoBehaviour
{

    public string curPassword;
    public string input;
    public bool onTrigger;
    public bool keypadScreen;
    private Challenge puzzle;
    private EscapeRoom room;
    
    public void SetRoom(EscapeRoom r)
    {
        room = r;
    }

    void OnTriggerEnter(Collider other)
    {
        onTrigger = true;
    }

    void OnTriggerExit(Collider other)
    {
        onTrigger = false;
        keypadScreen = false;
        input = "";
    }

    void Update()
    {
        if (input == curPassword && room.completed == 5)
        {
            keypadScreen = false;
            room.OpenDoor();
        }
    }

    void OnGUI()
    {
        if (keypadScreen)
        {
            GUI.Box(new Rect(0, 0, 555, 510), "");
            GUI.Box(new Rect(5, 5, 550, 25), input);

            if (GUI.Button(new Rect(5, 35, 50, 50), "1"))
            {
                input = input + "1";
            }

            if (GUI.Button(new Rect(60, 35, 50, 50), "2"))
            {
                input = input + "2";
            }

            if (GUI.Button(new Rect(115, 35, 50, 50), "3"))
            {
                input = input + "3";
            }

            if (GUI.Button(new Rect(170, 35, 50, 50), "4"))
            {
                input = input + "4";
            }

            if (GUI.Button(new Rect(225, 35, 50, 50), "5"))
            {
                input = input + "5";
            }

            if (GUI.Button(new Rect(280, 35, 50, 50), "6"))
            {
                input = input + "6";
            }

            if (GUI.Button(new Rect(335, 35, 50, 50), "7"))
            {
                input = input + "7";
            }

            if (GUI.Button(new Rect(390, 35, 50, 50), "8"))
            {
                input = input + "8";
            }

            if (GUI.Button(new Rect(445, 35, 50, 50), "9"))
            {
                input = input + "9";
            }

            if (GUI.Button(new Rect(500, 35, 50, 50), "0"))
            {
                input = input + "0";
            }
            if (GUI.Button(new Rect(5, 90, 50, 50), "Q"))
            {
                input = input + "Q";
            }

            if (GUI.Button(new Rect(60, 90, 50, 50), "W"))
            {
                input = input + "W";
            }

            if (GUI.Button(new Rect(115, 90, 50, 50), "E"))
            {
                input = input + "E";
            }

            if (GUI.Button(new Rect(170, 90, 50, 50), "R"))
            {
                input = input + "R";
            }

            if (GUI.Button(new Rect(225, 90, 50, 50), "T"))
            {
                input = input + "T";
            }

            if (GUI.Button(new Rect(280, 90, 50, 50), "Y"))
            {
                input = input + "Y";
            }

            if (GUI.Button(new Rect(335, 90, 50, 50), "U"))
            {
                input = input + "U";
            }

            if (GUI.Button(new Rect(390, 90, 50, 50), "I"))
            {
                input = input + "I";
            }

            if (GUI.Button(new Rect(445, 90, 50, 50), "O"))
            {
                input = input + "O";
            }

            if (GUI.Button(new Rect(500, 90, 50, 50), "P"))
            {
                input = input + "P";
            }
            if (GUI.Button(new Rect(5, 145, 50, 50), "A"))
            {
                input = input + "A";
            }

            if (GUI.Button(new Rect(60, 145, 50, 50), "S"))
            {
                input = input + "S";
            }

            if (GUI.Button(new Rect(115, 145, 50, 50), "D"))
            {
                input = input + "D";
            }

            if (GUI.Button(new Rect(170, 145, 50, 50), "F"))
            {
                input = input + "F";
            }

            if (GUI.Button(new Rect(225, 145, 50, 50), "G"))
            {
                input = input + "G";
            }

            if (GUI.Button(new Rect(280, 145, 50, 50), "H"))
            {
                input = input + "H";
            }

            if (GUI.Button(new Rect(335, 145, 50, 50), "J"))
            {
                input = input + "J";
            }

            if (GUI.Button(new Rect(390, 145, 50, 50), "K"))
            {
                input = input + "K";
            }

            if (GUI.Button(new Rect(445, 145, 50, 50), "L"))
            {
                input = input + "L";
            }
            if (GUI.Button(new Rect(60, 200, 50, 50), "Z"))
            {
                input = input + "Z";
            }

            if (GUI.Button(new Rect(115, 200, 50, 50), "X"))
            {
                input = input + "X";
            }

            if (GUI.Button(new Rect(170, 200, 50, 50), "C"))
            {
                input = input + "C";
            }

            if (GUI.Button(new Rect(225, 200, 50, 50), "V"))
            {
                input = input + "V";
            }

            if (GUI.Button(new Rect(280, 200, 50, 50), "B"))
            {
                input = input + "B";
            }

            if (GUI.Button(new Rect(335, 200, 50, 50), "N"))
            {
                input = input + "N";
            }

            if (GUI.Button(new Rect(390, 200, 50, 50), "M"))
            {
                input = input + "M";
            }
            if (GUI.Button(new Rect(425, 255, 100, 50), "Clear"))
            {
                input = "";
            }
            if (GUI.Button(new Rect(215, 255, 100, 50), "Space"))
            {
                input = input + " ";
            }
            if (GUI.Button(new Rect(5, 255, 100, 50), "Collapse"))
            {
                keypadScreen = false;
            }
        }
    }
}