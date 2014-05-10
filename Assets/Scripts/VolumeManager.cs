using UnityEngine;
using System.Collections;

public class VolumeManager : MonoBehaviour
{

		UISlider slider;
		public UIToggle soundToggle;
	
		void Awake ()
		{
				//cogemos el slider
				slider = GetComponent<UISlider> ();
				// set the slider's value to last saved value 
				slider.value = NGUITools.soundVolume;

				// si el volumen es 0, desactivamos el check
				if (NGUITools.soundVolume == 0)
						soundToggle.value = false;
				
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

		public void OnSoundToggle ()
		{
				float newVolume = 0;
				//si el boton esta checkeado, ponemos el slide a su valor
				if (UIToggle.current.value)
						newVolume = slider.value;
				AudioListener.volume = newVolume;
				NGUITools.soundVolume = newVolume;
		 
		}
}
