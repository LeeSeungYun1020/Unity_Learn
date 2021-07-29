using UnityEngine;

public class bamsongiGenerator : MonoBehaviour
{
	public GameObject bamsongiPrefab;

	// Start is called before the first frame update
	private void Start()
	{
	}

	// Update is called once per frame
	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			var bamsongi = Instantiate(bamsongiPrefab);

			var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			var worldDIr = ray.direction;
			bamsongi.GetComponent<BamsongiController>().shoot(worldDIr.normalized * 2000);
		}
	}
}