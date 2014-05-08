﻿using UnityEngine;
using System.Collections;

public class VolumeManager : MonoBehaviour
{

		UISlider slider;
	
		void Awake ()
		{
				//cogemos el slider
				slider = GetComponent<UISlider> ();
				// set the slider's value to last saved value 
				slider.value = NGUITools.soundVolume; 
		}

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		public void OnVolumeChange ()
		{
				//change NGUI's  UI sound volume
				NGUITools.soundVolume = UISlider.current.value;
				//Change the game audiolistener's volume
				AudioListener.volume = UISlider.current.value;
		}
}
