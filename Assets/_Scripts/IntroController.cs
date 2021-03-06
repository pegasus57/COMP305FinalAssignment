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
 */
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class IntroController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void BackButtonClick()
    {
        SceneManager.LoadScene("Menu");
    }
}