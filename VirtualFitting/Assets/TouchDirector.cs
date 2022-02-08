using UnityEngine;

public class TouchDirector : MonoBehaviour
{
	public GameObject manPrefab;
	public GameObject womanPrefab;
	public GameObject c26Prefab;
	public GameObject c49Prefab;
	public GameObject c2Prefab;
	public GameObject c7Prefab;
	public GameObject c16Prefab;
	public GameObject c12Prefab;
	public GameObject c79Prefab;
	public GameObject c111Prefab;

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
		Display(womanPrefab);
	}

	public void OnClickCoordination26()
	{
		Display(c26Prefab);
	}

	public void OnClickCoordination49()
	{
		Display(c49Prefab);
	}

	public void OnClickCoordination2()
	{
		Display(c2Prefab);
	}

	public void OnClickCoordination7()
	{
		Display(c7Prefab);
	}

	public void OnClickCoordination16()
	{
		Display(c16Prefab);
	}

	public void OnClickCoordination12()
	{
		Display(c12Prefab);
	}

	public void OnClickCoordination79()
	{
		Display(c79Prefab);
	}

	public void OnClickCoordination111()
	{
		Display(c111Prefab);
	}
	// 코디 단위 OnClickCoordinationID 추가

	private void Display(GameObject obj)
	{
		var prev = GameObject.FindWithTag("Prev");
		if (prev != null) Destroy(prev);

		var target = Instantiate(obj);
		target.transform.position = new Vector3(0, 0, 0);
	}
}