using UnityEngine;

public class TouchDirector : MonoBehaviour
{
	public GameObject manPrefab;
	public GameObject womanPrefab;

	// Start is called before the first frame update
	private void Start()
	{
	}

	// Update is called once per frame
	private void Update()
	{
	}

	public void OnClickCoordination1()
	{
		Display(manPrefab);
	}

	public void OnClickCoordination2()
	{
		Display(womanPrefab);
	}

	private void Display(GameObject obj)
	{
		var prev = GameObject.FindWithTag("Prev");
		if (prev != null) Destroy(prev);

		var target = Instantiate(obj);
		target.transform.position = new Vector3(0, 0, 0);
	}
}