using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class Audio : MonoBehaviour
{
	private AudioSource _audiosource;
	private bool _isPaused;
	public TMP_Text SoundPaused;
	public TMP_Text VolumeControl;
 	
	public static float[] _samples = new float[8192]; //512, 1024, 2048,  Recommended between ->4096, 8192 <- Max
	
	// Use this for initialization
	void Start ()
	{
		_audiosource = GetComponent<AudioSource>();
		SoundPaused.enabled = false;
		VolumeControl.enabled = true; 
	}
	
	// Update is called once per frame
	void Update () 
	{
		GetSpectrumAudioSource();

		if(Input.GetKeyDown(KeyCode.Space))
		{
			_isPaused = (_isPaused == false) ? true : false;

			if (_isPaused)
			{
				_audiosource.Pause();
				SoundPaused.enabled = true;
				
			}
			else
			{
				_audiosource.UnPause();
				SoundPaused.enabled = false;
				

			}
		}

		if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
		{
			_audiosource.volume += 0.1f;

			//VolumeControl.SetText("Volume: "+ (int) 1.0f * 1 / 100);
			if (_audiosource.volume <=  1.0f)
			{
				VolumeControl.SetText("Volume: 100 %");
			}
			if (_audiosource.volume <=  0.9f)
			{
				VolumeControl.SetText("Volume: 90 %");
			}
			if (_audiosource.volume <=  0.8f)
			{
				VolumeControl.SetText("Volume: 80 %");
			}
			if (_audiosource.volume <=  0.7f)
			{
				VolumeControl.SetText("Volume: 70 %");
			}
			if (_audiosource.volume <=  0.6f)
			{
				VolumeControl.SetText("Volume: 60 %");
			}
			if (_audiosource.volume <=  0.5f)
			{
				VolumeControl.SetText("Volume: 50 %");
			}
			if (_audiosource.volume <=  0.4f)
			{
				VolumeControl.SetText("Volume: 40 %");
			}
			if (_audiosource.volume <=  0.3f)
			{
				VolumeControl.SetText("Volume: 30 %");
			}
			if (_audiosource.volume <= 0.2f)
			{
				VolumeControl.SetText("Volume: 20 %");
			}
			if (_audiosource.volume <=  0.1f)
			{
				VolumeControl.SetText("Volume: 10 %");
			}
			if (_audiosource.volume <=  0.0f)
			{
				VolumeControl.SetText("Volume: MUTED");
			}
			
			//VolumeControl.SetText("Volume: 100%");
		}

		if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
		{
			_audiosource.volume -= 0.1f; 
			//VolumeControl.SetText("Volume: "+ (int) 1.0f * 1 / 100);
			if (_audiosource.volume <= 1.0f)
			{
				VolumeControl.SetText("Volume: 100 %");
			}
			if (_audiosource.volume <= 0.9f)
			{
				VolumeControl.SetText("Volume: 90 %");
			}
			if (_audiosource.volume <= 0.8f)
			{
				VolumeControl.SetText("Volume: 80 %");
			}
			if (_audiosource.volume <= 0.7f)
			{
				VolumeControl.SetText("Volume: 70 %");
			}
			if (_audiosource.volume <= 0.6f)
			{
				VolumeControl.SetText("Volume: 60 %");
			}
			if (_audiosource.volume <= 0.5f)
			{
				VolumeControl.SetText("Volume: 50 %");
			}
			if (_audiosource.volume <= 0.4f)
			{
				VolumeControl.SetText("Volume: 40 %");
			}
			if (_audiosource.volume <= 0.3f)
			{
				VolumeControl.SetText("Volume: 30 %");
			}
			if (_audiosource.volume <= 0.2f)
			{
				VolumeControl.SetText("Volume: 20 %");
			}
			if (_audiosource.volume <= 0.1f)
			{
				VolumeControl.SetText("Volume: 10 %");
			}
			if (_audiosource.volume <= 0.0f)
			{
				VolumeControl.SetText("Volume: MUTED");
			}
		}
	}


	void GetSpectrumAudioSource()
	{
		_audiosource.GetSpectrumData(_samples, 0, FFTWindow.Blackman);
	}	 
}
