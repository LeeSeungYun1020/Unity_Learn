using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClearDirector : MonoBehaviour
{
	// Start is called before the first frame update
	private void Start()
	{
		var pointText = GameObject.Find("ClearPoint");
		pointText.GetComponent<Text>().text = "Point: " + Point.Value;
	}

	// Update is called once per frame
	private void Update()
	{
		if (Input.GetMouseButtonDown(0)) SceneManager.LoadScene("GameScene");
	}
}