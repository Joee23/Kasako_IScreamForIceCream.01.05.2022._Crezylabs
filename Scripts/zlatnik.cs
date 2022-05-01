using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class zlatnik : MonoBehaviour
{
	private BrojacNovcica brojacNovcica;
	private ProgressBar progressBar;

	void Awake()
	{
		brojacNovcica = GameObject.Find("brojNovcica").GetComponent<BrojacNovcica>();
		progressBar = GameObject.Find("ProgressBar").GetComponent<ProgressBar>();
	}

	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			brojacNovcica.brojac++;
			if (brojacNovcica.brojac == 5)
			{
				SceneManager.LoadScene(2);
			}
			progressBar.IncreseCurrent();
			gameObject.SetActive(false);
		}
	}
}
