using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    #region Sinlgeton class: Game

    public static Game Instance;

    void Awake ()
    {
        Instance = this;
        screenWidth = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x;
    }

    #endregion

    [HideInInspector]public float screenWidth;
}