﻿/*
 * The Source file name: COMP305FinalAssignment
 * Author’s	name: Jiho Yoo / Rui Yang
 * Last	Modified by: Jiho Yoo
 * Date last Modified: Apr 7th, 2016
 * Program description: The game is attacking enemies and gaining torches. The hero attacks enemies to rescue a princess. 
 *                      The game has 3 level. If the hero finds door, hero can go to next level. 
 *                      In addition, if the hero finds the princess, the game will be done.
 * Revision	History: Mar 22th, 2016 - Created new project. Connect github to share codes.
 *                   Mar 23th, 2016 - Created menu Scene
 *                   Mar 25th, 2016 - Added images
 *                   Mar 26th, 2016 - Changed menu buttons
 *                   Mar 29th, 2016 - Imported Game
 *                   Mar 30th, 2016 - Added Lv2,3
 *                   Apr 03th, 2016 - Added Information Scene
 *                   Apr 06th, 2016 - Added door to go to next level
 *                   Apr 07th, 2016 - Added princess. Find errors
 *                   Apr 10th, 2016 - Added weapon
 *                   Apr 12th, 2016 - Changed map 
 *                   Apr 15th, 2016 - Added bullet system
 *                   Apr 18th, 2016 - Added loading scenes
 *                   Apr 19th, 2016 - Fixed all errors
 */
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {

    public GameController gameController;
    public Text LivesLabel;
    public Text ScoreLabel;
    //public Text HighScoreLabel;
    
	// Use this for initialization
	void Start () {

      
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //Event Handler for StartButtonClick

    public void StartButtonClick() 
    {
        SceneManager.LoadScene("Lvl1");
    }
   

    public void InstructionsButtonClick()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void Lv2ButtonClick()
    {
        SceneManager.LoadScene("Lvl2");
    }

    public void Lv3ButtonClick()
    {
        SceneManager.LoadScene("Lvl3");
    }

    public void QuitButtonClick()
    {
        Application.Quit();

    }

    public void BackButtonClick()
    {
        SceneManager.LoadScene("Menu");
    }

    public void IntroButtonClick()
    {
        SceneManager.LoadScene("Intro");
    }

    public Text HighScoreLabel;
    
    private void HighScoreLabels()
    {
        //this.HighScoreLabel.gameObject.SetActive(true);
       this.HighScoreLabel.text = "High Score: " + gameController.ScoreValue; 
    }
     
}
