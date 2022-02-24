using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimator : MonoBehaviour
{
    public void getAnimatorStand() {
        this.GetComponent<Animator>().Play("Old Man Idle");
    }

    public void getAnimatorWalk() {
        this.GetComponent<Animator>().Play("Walking");
    }

    public void getAnimatorLeft() {
        this.GetComponent<Animator>().Play("Left Turn 90");
    }
}
