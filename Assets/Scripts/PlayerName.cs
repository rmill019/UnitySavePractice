using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour {
	
	private InputField input;
	// Use this for initialization
	void Start () {
		input = GetComponent<InputField>();
		input.onValueChanged.AddListener (SavePlayerName);

		string savedName = PlayerPrefs.GetString ("PlayerName");
		// If we are able to find a String in PlayerPrefs by the name of PlayerName
		if (!string.IsNullOrEmpty(savedName))
		{
			input.text = savedName;
			GameManager.instance.playerName = savedName;
		}
	}
	
	private void SavePlayerName (string playerName)
	{
		PlayerPrefs.SetString ("PlayerName", playerName);
		PlayerPrefs.Save();
		GameManager.instance.playerName = playerName;
	}
}
