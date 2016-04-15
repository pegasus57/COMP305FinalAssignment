/* Author's name: Jiho Yoo
* Last Modified by: Jiho Yoo
* Date last Modified: Feb 29, 2015
* Description: The Phoo is getting coins to buy honey.
* Revision History: 
* Feb 20, 2016 - set background and images.
* Feb 22, 2016 - write codes
* Feb 26, 2016 - set audios
* Feb 29, 2016 - found errors
*/
using UnityEngine;
using System.Collections;

public class SpikedWheelController : MonoBehaviour {
	// PRIVATE INSTANCE VARIABLES
	private Transform _transform;


	// Use this for initialization
	void Start () {
		this._transform = gameObject.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		this._transform.Rotate (0, 0, -2f);

	}
}
