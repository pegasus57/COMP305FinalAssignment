/*
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
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // PRIVATE INSTANCE VARIABLES
    private int _scoreValue;
    private int _livesValue;

    public int _currentScore;

    //[SerializeField]
    //private AudioSource _gameOverSound;



    // PUBLIC ACCESS METHODS
    public int ScoreValue
    {

        get
        {
            return this._scoreValue;
        }

        set
        {
            this._scoreValue = value;
            this.ScoreLabel.text = "Score: " + this._scoreValue;

        }
    }

    public int LivesValue
    {
        get
        {
            return this._livesValue;
        }

        set
        {
            this._livesValue = value;
            if (this._livesValue <= 0)
            {
                this._endGame();
            }
            else
            {
                this.LivesLabel.text = "Lives: " + this._livesValue;
            }
        }
    }





    //PUBLIC INSTANCE VARIABLES
    ////public int enemyNumber = 3;
    ////public EnemyController enemy;
    public Text LivesLabel;
    public Text ScoreLabel;
    public Text HighScoreLabel;
    public Text Good;
    //public Text GameOverLabel2;
    //public PlayerController player;
    //public CoinController coin;
    //public Text HighScoreLabel;
    //public Button RestartButton;

    // Use this for initialization
    void Start()
    {
        this._initialize();
        //enemy.gameObject
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Awake()
    {
        
        DontDestroyOnLoad(gameObject);

    }

    //private methods=========================



    private void _initialize()
    {
        this.ScoreValue = 0;
        this.LivesValue = 5;


        //this.Good.gameObject.SetActive(false);
        //this.HighScoreLabel.gameObject.SetActive(false);
        //this.RestartButton.gameObject.SetActive(false);



        //for (int enemyCount = 0; enemyCount < this.enemyNumber; enemyCount++)
        //{
        //    Instantiate(enemy.gameObject);
        //}
    }


    private void _endGame()
    {
        SceneManager.LoadScene("EndScenes");
        //this.GameOverLabel.gameObject.SetActive(true);
        //this.player.gameObject.SetActive(false);
        //this.coin.gameObject.SetActive(false);
        //this.LivesLabel.gameObject.SetActive(false);
        //this.ScoreLabel.gameObject.SetActive(false);
        //this.HighScoreLabel.gameObject.SetActive(true);
        //this.HighScoreLabel.text = "High Score: " + this._scoreValue;
        //this._gameOverSound.Play();
        //this.RestartButton.gameObject.SetActive(true);
    }







    // PUBLIC METHODS

    public void RestartButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
