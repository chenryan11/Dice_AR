using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoToGame : MonoBehaviour
{

    public Button Go_To_Game;

    void Start()
    {
        Go_To_Game.onClick.AddListener(Go_To_GameOnClick);
    }

    private void Go_To_GameOnClick()
    {
        Application.LoadLevel("S2");
    }
}
