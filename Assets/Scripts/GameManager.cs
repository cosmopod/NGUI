using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{


		public enum Difficulties
		{
				Easy,
				Normal,
				Hard
		}

		public static Difficulties difficulty = Difficulties.Normal;
		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		public void ExitPressed ()
		{
				//Exit application
				Application.Quit ();
		}

		public void OnDifficultyChange ()
		{
				string listValue = UIPopupList.current.value;
				switch (listValue) {
				case "Easy":
						difficulty = Difficulties.Easy;
						break;
				case "Normal":
						difficulty = Difficulties.Normal;
						break;
				case "Hard":
						difficulty = Difficulties.Hard;
						break;
				}
				Debug.Log (difficulty);
		}
}
