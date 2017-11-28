using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour {

void Start () {
        SetGazedAt(false);
    }

    void Update () {

    }

    public void SetGazedAt(bool gazedAt) {
        // GetComponent<Renderer>().material.color = gazedAt ? Color.green : Color.red;
    }

    public void OnPointerHover() {
        Debug.Log ("OnGazeEnter");
        // SetGazedAt(true);
    }

    public void OnPointerExit() {
        Debug.Log ("OnGazeExit");
        // SetGazedAt(false);
    }
}
