using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackToS1 : MonoBehaviour
{
    public GameObject dice;

    public Button Out;
    public Button BacktoS1;

    private List<GameObject> ModelList = new List<GameObject>();

    void Start()
    {
        BacktoS1.onClick.AddListener(BacktoS1OnClick);
        Out.onClick.AddListener(OutOnClick);
    }

	private void BacktoS1OnClick()
	{
		Application.LoadLevel("S1");
	}

    public void OutOnClick()
    {
        Application.Quit();
    }
}
