using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
	private GameObject generator;
	private int point;
	private GameObject pointText;
	private float time = 30.0f;

	private GameObject timerText;

	// Start is called before the first frame update
	private void Start()
	{
		timerText = GameObject.Find("Time");
		pointText = GameObject.Find("Point");
		generator = GameObject.Find("ItemGenerator");
	}

	// Update is called once per frame
	private void Update()
	{
		time -= Time.deltaTime;

		if (time < 0)
		{
			time = 0;
			generator.GetComponent<ItemGenerator>().GameEnd();
		}
		else if (time < 5)
		{
			generator.GetComponent<ItemGenerator>().SetParameter(0.7f, -0.04f, 3);
		}
		else if (time < 12)
		{
			generator.GetComponent<ItemGenerator>().SetParameter(0.5f, -0.06f, 6);
		}
		else if (time < 23)
		{
			generator.GetComponent<ItemGenerator>().SetParameter(0.8f, -0.04f, 4);
		}
		else if (time < 30)
		{
			generator.GetComponent<ItemGenerator>().SetParameter(1.0f, -0.03f, 2);
		}

		timerText.GetComponent<Text>().text = time.ToString("F1");
		pointText.GetComponent<Text>().text = point + " points";
	}

	public void GetApple()
	{
		point += 100;
	}

	public void GetBomb()
	{
		point /= 2;
	}
}