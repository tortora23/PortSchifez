using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FirstMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
        Connection.start();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void login(Text nick)
    {
        if (Connection.login(nick.text) && !Connection.isLogIn)
        {
            SceneManager.LoadScene("Game");
        }
    }
}
