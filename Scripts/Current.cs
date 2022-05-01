using UnityEngine;
using System.Collections;

public class Current : MonoBehaviour
{
	public BrojacNovcica brojacNovcica;

	void Awake()
	{
		brojacNovcica = GameObject.Find("brojNovcica").GetComponent<BrojacNovcica>();

	}
	
	void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
			brojacNovcica.brojac++;
			gameObject.SetActive(false);
        }
    }
}
