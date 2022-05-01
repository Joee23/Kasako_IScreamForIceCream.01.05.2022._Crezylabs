using UnityEngine;
using UnityEngine.UI; 
using System.Collections;

public class BrojacNovcica : MonoBehaviour {

	public int brojac=10;

	
	void Update () {
		
		GetComponent<Text>().text = brojac.ToString();
	}
}
