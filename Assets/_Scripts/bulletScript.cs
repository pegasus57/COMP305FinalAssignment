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
 *                   Apr 10th, 2016 - Added weapon
 *                   Apr 12th, 2016 - Changed map 
 *                   Apr 15th, 2016 - Added bullet system
 *                   Apr 18th, 2016 - Added loading scenes
 *                   Apr 19th, 2016 - Fixed all errors
 */
using UnityEngine;
using System.Collections;

public class bulletScript : MonoBehaviour {
    float speed;

    private AudioSource[] _audioSources;
    private AudioSource _hurtSound;



	// Use this for initialization
	void Start () {
        speed = 150f;

        // Setup AudioSources
        this._audioSources = gameObject.GetComponents<AudioSource>();
        this._hurtSound = this._audioSources[0];
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 position = transform.position;
        position = new Vector2(position.x + speed * Time.deltaTime, position.y);
        transform.position = position;
        //Vector2 max = Camera.main.ScreenToViewportPoint(new Vector2(1, 1));
        //if (transform.position.y > max.y)
        //{
        //    Destroy(gameObject);
        //}
	
	}
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            this._hurtSound.Play();
            Destroy(other.gameObject);
            Destroy(gameObject);
            
        }
        if (other.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("SpikedWheel"))
        {
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("Crate"))
        {
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("Torch"))
        {
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("Princess"))
        {
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("End2"))
        {
            Destroy(gameObject);
        }
    
    }
}
