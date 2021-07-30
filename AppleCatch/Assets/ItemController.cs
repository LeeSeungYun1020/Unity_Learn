using UnityEngine;

public class ItemController : MonoBehaviour
{
	public float dropSpeed = -0.03f;

	// Start is called before the first frame update
	private void Start()
	{
	}

	// Update is called once per frame
	private void Update()
	{
		transform.Translate(0, dropSpeed, 0);
		if (transform.position.y < -1.0f) Destroy(gameObject);
	}
}