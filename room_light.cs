using UnityEngine;
using System.Collections;


public class RoomLights : MonoBehaviour {
	GameObject light_1;
	GameObject light_2;
	public int duration;
	public int blink;
	private bool prog_end=false;
	private int iniDur;
	private bool alert_audio=false;

	AudioSource red_alert_audio;
	AudioSource after_alert_audio;
	//Note: Need to have tw lights of name "Light1" and "Light2"
	void Start() {
		light_1=GameObject.Find("Light1");
		light_2=GameObject.Find("Light2");
		iniDur = duration;

		AudioSource[] audios = GetComponents<AudioSource>();
		red_alert_audio = audios[0];
		after_alert_audio = audios[1];

		red_alert_audio.Play();
	}

	void Update() {
		light_2.light.color=Color.red;


		duration = duration - 1;
		if(!prog_end) {
		if ( duration==0) {
				light_1.light.enabled=!light_1.light.enabled;
				duration=iniDur;
				blink=blink-1;

				if(blink==0){
					prog_end=true;
					light_2.light.enabled=false;
					light_1.light.enabled=false;
					alert_audio=true;
				}

				if(alert_audio){
					after_alert_audio.Play();
					alert_audio=false;
				}
		}
		}
	}
}
