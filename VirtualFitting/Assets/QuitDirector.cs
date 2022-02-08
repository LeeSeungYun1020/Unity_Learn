using UnityEngine;

public class QuitDirector : MonoBehaviour
{
	// Start is called before the first frame update
	private void Start()
	{
	}

	// Update is called once per frame
	private void Update()
	{
		if (Application.platform == RuntimePlatform.Android)
			if (Input.GetKeyDown(KeyCode.Escape))
				Application.Quit();
	}

	public void onQuitButtonClick()
	{
		Application.Quit();
	}
}