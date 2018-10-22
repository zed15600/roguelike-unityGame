using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMannager : MonoBehaviour {

    public BoardMannager boardScript;

    private int level = 3;

	// Use this for initialization
	void Awake () {
		boardScript = GetComponent<BoardMannager>();
        initGame();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void initGame() {
        boardScript.SetupScene(level);
    }
}
