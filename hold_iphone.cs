using UnityEngine;
using System.Collections;

public class IPhone : MonoBehaviour {
	GameObject hand;
	float diffX;
	float diffY;
	float diffZ;
	float netDiff;
	bool hold=false;
	// Use this for initialization
	void Start () {
		hand=GameObject.Find("HandNode");

	}
	
	// Update is called once per frame
	void Update () {
		//Taking square of difference along....
		diffX = Mathf.Pow((this.transform.position.x - hand.transform.position.x),2);//..X-direction
		diffY = Mathf.Pow((this.transform.position.y - hand.transform.position.y),2);//..Y-direction
		diffZ = Mathf.Pow((this.transform.position.z - hand.transform.position.z),2);//..Z-direction
		netDiff=Mathf.Sqrt (diffX + diffY + diffZ);//Sqrt of sum of difference

		if (Input.GetMouseButtonDown (0)) {//Checking the clicking of left click
			hold=!hold;
			}

		if (hold) {//Checking is the user is holding
						if (netDiff < 0.1) {//checkingi f the object is cose to the wand
								this.transform.position = hand.transform.position;
				//print (transform.position);
						}
				} else {
			//need to make the phonw on the floor
				}
	}
}
