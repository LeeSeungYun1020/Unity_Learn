using UnityEngine;

public class BasicManGenerator : MonoBehaviour
{
	public GameObject manPrefab;

	// Start is called before the first frame update
	private void Start()
	{
		var target = Instantiate(manPrefab);
		target.transform.position = new Vector3(0, 0, 0);
		// target.transform.Rotate(0, 180, 0);
	}

	// Update is called once per frame
	private void Update()
	{
	}
}