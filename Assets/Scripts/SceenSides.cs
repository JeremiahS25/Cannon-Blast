using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceenSides : MonoBehaviour
{
    [SerializeField] BoxCollider2D leftWallCollider;
    [SerializeField] BoxCollider2D rightWallCollider;

    void Awake()
    {
        float screenWidth = Game.Instance.screenWidth;

        leftWallCollider.transform.position = new Vector3(-screenWidth - leftWallCollider.size.x / 2f, 0f, 0f);
        rightWallCollider.transform.position = new Vector3(screenWidth + rightWallCollider.size.x / 2f, 0f, 0f);

        //disable the script: we're no longer need it: this.enabled = false
        //or destroy it:
        Destroy (this);
    }
}
