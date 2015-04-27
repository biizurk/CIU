using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpeechText : MonoBehaviour
{
		//public Select S;
		public Interact I;

		public GameObject TheSpeechCanvas;
		public Text txt;
		public float SpeechBoxTime;
		GameObject m_Player;
		// Use this for initialization
		void Start ()
		{
				TheSpeechCanvas.GetComponent<Canvas> ().enabled = false;
				//m_Player = GameObject.FindGameObjectWithTag ("Player");
		}
	
		// Update is called once per frame
		void Update ()
		{

				SpeechBoxTime += Time.deltaTime;

				string[] DigitGreetings = {"Lad this is sick", "Mate where the bitchez at?","Yea, I know the DJ","Don't mess with me. I have cousins"};
				System.Random random = new System.Random ();
				string quote = DigitGreetings [random.Next (DigitGreetings.Length)];
//				if (m_Player != null) {
//						//TheSpeechCanvas.transform.LookAt (m_Player.transform.position + new Vector3 (0f, 0.5f, 0f));
//						//TheSpeechCanvas.transform.Rotate (0f, 180f, 0f);
//				}

				if (I.selected == true && I.IsSpeaking == true) {
						SpeechBoxTime = 0;
						txt.GetComponent<Text> ().text = quote;
						TheSpeechCanvas.GetComponent<Canvas> ().enabled = true;

				}
				if (SpeechBoxTime >= 5) {
						TheSpeechCanvas.GetComponent<Canvas> ().enabled = false;
				}
		}
}
