using UnityEngine;
using UnityEngine.UI; 
using System.Collections;

public class CurrentNumber : MonoBehaviour
{

	public int brojac = 0;

	
	void Update()
	{
		
		GetComponent<Text>().text = brojac.ToString();
	}
}
