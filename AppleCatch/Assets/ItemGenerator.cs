using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
	public GameObject applePrefab;
	public GameObject bombPrefab;
	private float delta;
	private bool end;
	private int ratio = 2;
	private float span = 1f;
	private float speed = -0.03f;

	// Start is called before the first frame update
	private void Start()
	{
	}

	// Update is called once per frame
	private void Update()
	{
		if (!end)
		{
			delta += Time.deltaTime;
			if (delta > span)
			{
				delta = 0;
				GameObject item;
				var dice = Random.Range(1, 11);
				if (dice <= ratio)
					item = Instantiate(bombPrefab);
				else
					item = Instantiate(applePrefab);

				item.transform.position = new Vector3(Random.Range(-1, 2), 4, Random.Range(-1, 2));
				item.GetComponent<ItemController>().dropSpeed = speed;
			}
		}
	}

	public void SetParameter(float span, float speed, int ratio)
	{
		this.span = span;
		this.speed = speed;
		this.ratio = ratio;
	}

	public void GameEnd()
	{
		end = true;
	}
}