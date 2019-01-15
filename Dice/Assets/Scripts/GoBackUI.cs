using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoBackUI : MonoBehaviour
{
	public Button Back_to_UI;

	void Start()
	{
		Back_to_UI.onClick.AddListener(Back_to_UIOnClick);
	}

	private void Back_to_UIOnClick()
	{
		Application.LoadLevel("UI");
	}
}
