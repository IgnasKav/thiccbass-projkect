using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteLevel : MonoBehaviour {
    public LevelController gm;

    private void OnTriggerEnter2D(Collider2D collider) {
        if (collider.gameObject.tag == "Player" && gm.ObjectiveComplete()) {
            Debug.Log("Loadnext level");
            //load next level
        }
    }
}