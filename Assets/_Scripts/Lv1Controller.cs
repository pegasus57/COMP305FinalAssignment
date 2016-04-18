using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class Lv1Controller : MonoBehaviour {


    public Text HighScoreLabel;
    public GameController gamecontroller;


	// Use this for initialization
	void Start () {

        this.HighScoreLabel.text = "Lv1 Score: " + gamecontroller.ScoreValue;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
