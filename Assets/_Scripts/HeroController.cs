/*
 * The Source file name: COMP305FinalAssignment
 * Author�s	name: Jiho Yoo / Rui Yang
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
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;


using System.Collections;
// VELOCITY RANGE UTILITY Class +++++++++++++++++++++++
[System.Serializable]
public class VelocityRange
{
    // PUBLIC INSTANCE VARIABLES ++++
    public float minimum;
    public float maximum;

    // CONSTRUCTOR ++++++++++++++++++++++++++++++++++++
    public VelocityRange(float minimum, float maximum)
    {
        this.minimum = minimum;
        this.maximum = maximum;
    }
}
public class HeroController: MonoBehaviour {
    public VelocityRange velocityRange;
    public float moveForce;
    public float jumpForce;
    public Transform groundCheck;
    public Transform camera;
    public GameController gameController;
    public GameObject Bullet;
    public GameObject BulletPosition;
    public Text HighScoreLabel;

    // PRIVATE INSTANCE VARIABLES
    private Animator _animator;
    private float _move;
    private float _jump;
    private bool _facingRight;
    private Transform _transform;
    private Rigidbody2D _rigidBody2D;
    private bool _isGrounded;
    private AudioSource[] _audioSources;
    private AudioSource _jumpSound;
    private AudioSource _pickupSound;
    private AudioSource _DeadSound;
    private AudioSource _hurtSound;
    private AudioSource _hitSound;
    private GameObject _weapon1;
    


	// Use this for initialization
	void Start () {
        
        // Initialize Public Instance Variables
        this.velocityRange = new VelocityRange(300f, 30000f);

        //this._weapon1.gameObject.SetActive(false);


        // Intitialize Private Instance Variable
        this._transform = gameObject.GetComponent<Transform>();
        this._animator = gameObject.GetComponent<Animator>();
        this._rigidBody2D = gameObject.GetComponent<Rigidbody2D>();
        this._move = 0f;
        this._jump = 0f;
        this._facingRight = true;
        ////Set default animation state to "idle"
        //this._animator.SetInteger("AnimState", 0);


        // Setup AudioSources
        this._audioSources = gameObject.GetComponents<AudioSource>();
        this._jumpSound = this._audioSources[0];
        this._pickupSound = this._audioSources[1];
        this._DeadSound = this._audioSources[2];
       
        this._hitSound = this._audioSources[3];
        this._hurtSound = this._audioSources[5];
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if(Input.GetKeyDown("space"))
        {
            GameObject bullet = (GameObject)Instantiate(Bullet);
            bullet.transform.position = BulletPosition.transform.position;
            this._hitSound.Play();

        }





        Vector3 currentPosition = new Vector3(this._transform.position.x, this._transform.position.y, -10f);
        this.camera.position = currentPosition;
        
        this._isGrounded = Physics2D.Linecast(
            this._transform.position,
            this.groundCheck.position,
            1 << LayerMask.NameToLayer("Ground"));
        Debug.DrawLine(this._transform.position, this.groundCheck.position);


        if (this._isGrounded)
        {
            Debug.Log("1111");

       
        


        }
        else
        {
            Debug.Log("0000");
 
        }



        float forceX = 0f;
        float forceY = 0f;

        float absVelX = Mathf.Abs(this._rigidBody2D.velocity.x);
        float absVelY = Mathf.Abs(this._rigidBody2D.velocity.y);



        
        //Debug.Log(this._jump);
        // Ensure the player is grounded before any movement checks
        if (this._isGrounded)
        {
            // gets a number between -1 to 1 for both Horizontal and Vertical Axes
            this._move = Input.GetAxis("Horizontal");
            this._jump = Input.GetAxis("Vertical");
            if (this._move != 0)
            {
                if (this._move > 0)
                {
                    if (absVelX < this.velocityRange.maximum)
                    {
                        forceX = this.moveForce;
                    }
                    this._facingRight = true;
                    this._flip();
                }
                if (this._move < 0)
                {
                    if (absVelX < this.velocityRange.maximum)
                    {
                        forceX = -this.moveForce;
                    }
                    this._facingRight = false;
                    this._flip();
                }
                // call the walk clip
                this._animator.SetInteger("Anim_State", 1);
            }
            else
            {

                //Set default animation state to "idle"
                this._animator.SetInteger("Anim_State", 0);
            }
            if (this._jump != 0)
            {
                if (absVelY < this.velocityRange.maximum)
                {
                    this._jumpSound.Play();
                    forceY = this.jumpForce;
                }
                
            }
        }
        else
        {
            this._animator.SetInteger("Anim_State", 2);
        }
        this._rigidBody2D.AddForce(new Vector2(forceX, forceY));
        
        
	}


    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Torch"))
        {
            this._pickupSound.Play();
            Destroy(other.gameObject);
            this.gameController.ScoreValue += 10;
           



        }

        if (other.gameObject.CompareTag("End"))
        {
            SceneManager.LoadScene("Lv1ScoreScene");
           
        }

        if (other.gameObject.CompareTag("End2"))
        {
            SceneManager.LoadScene("Lv2ScoreScene");


        }

        
        if (other.gameObject.CompareTag("Princess"))
        {
            SceneManager.LoadScene("WinScenes");


        }

       

        if (other.gameObject.CompareTag("Enemy"))
        {
            this._hurtSound.Play();
            Destroy(other.gameObject);
            this.gameController.LivesValue--;
        }

        if (other.gameObject.CompareTag("Death"))
        {
            this._spawn();
            this._DeadSound.Play();
            this.gameController.LivesValue--;
        }

        if (other.gameObject.CompareTag("SpikedWheel"))
        {
            this._hurtSound.Play();
            this.gameController.LivesValue--;
        }

        if (other.gameObject.CompareTag("Weapon"))
        {
            Destroy(other.gameObject);

        }

        
        }

    //private methods
    private void _flip()
    {
        if (this._facingRight)
        {
            this._transform.localScale = new Vector2(1, 1);
        }
        else
        {
            this._transform.localScale = new Vector2(-1, 1);
        }
    }
    private void _spawn()
    {
        this._transform.position = new Vector3(-125f, 125f, 0);
    }
       
}
