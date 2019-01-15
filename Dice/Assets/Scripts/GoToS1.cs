using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoToS1 : MonoBehaviour
{
	public Button GOTOS1;
    public Button Out;

    void Start()
	{
		GOTOS1.onClick.AddListener(GOTOS1OnClick);
        Out.onClick.AddListener(OutOnClick);
    }

	private void GOTOS1OnClick()
	{
		Application.LoadLevel("S1"); 
	}
    private void OutOnClick()
    {
        Application.Quit();
    }
}
