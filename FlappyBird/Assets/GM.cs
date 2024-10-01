using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour {

    void OnGUI()
    {
        GUI.Label(new Rect(40, 40, 200, 100), "Score: " + Score.score + "High Score: " + Score.highScore);
    }
}
