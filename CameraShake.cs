using UnityEngine;
using System.Collections;
public class CamShake : MonoBehaviour
{
	private Vector3 originPosition;
	private Quaternion originRotation;
	private int count=0;
	public float shake_decay;
	public float shake_intensity;
	public int time;
	private Vector3 tempVec;
	void Awake(){
		print ("aweake");

	}
	
	void Start (){
		print("start");

	/*	if (Input.GetMouseButtonDown (0)){
			Shake ();
		}*/
	}
	
	void Update (){
		Debug.Log ("updatte");
		Shake ();
		if (time==100){
			originPosition = this.transform.position;
			originRotation = this.transform.rotation;
		}
		if (time >0){
			Debug.Log ("start");
			//shake_intensity=0.03f;
			tempVec = originPosition + Random.insideUnitSphere * shake_intensity*0.2f;
			tempVec.y=this.transform.position.y;
			tempVec.z=this.transform.position.z;
			this.transform.position=tempVec;
			/*this.transform.position.x=tempVec.x;
			this.transform.position.y=this.transform.position.y;
			this.transform.position.z=this.transform.position.z;*/
			Debug.Log (this.transform.position);
			/*this.transform.rotation = new Quaternion(
				originRotation.x + Mathf.Pow(count,-1)*Random.Range (-shake_intensity,shake_intensity) * .02f,
				originRotation.y + Mathf.Pow(count,-1)*Random.Range (-shake_intensity,shake_intensity) * .02f,
				originRotation.z + Mathf.Pow(count,-1)*Random.Range (-shake_intensity,shake_intensity) * .02f,
				originRotation.w + Mathf.Pow(count,-1)*Random.Range (-shake_intensity,shake_intensity) * .02f);
			shake_intensity -= shake_decay;*/
			shake_intensity -= shake_decay;
			shake_intensity=Mathf.Abs(shake_intensity);
			time-=1;
		}
		if (time==0) {
		this.transform.position=new Vector3(0,0,0);
		}
	}
	
	void Shake(){
		originPosition = this.transform.position;
		//originRotation = this.transform.rotation;
		//Debug.Log(originPosition);
		//Debug.Log(originRotation);
		//shake_intensity = .3f;
		//shake_decay = 0.002f;
	}
}
