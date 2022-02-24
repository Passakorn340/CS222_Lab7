using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColors : MonoBehaviour
{
    public void getRed() {
        this.GetComponent<Renderer>().material.color = Color.red;
    }

    public void getYellow() {
        this.GetComponent<Renderer>().material.color = Color.yellow;
    }

    public void getGreen() {
        this.GetComponent<Renderer>().material.color = Color.green;
    }
}
