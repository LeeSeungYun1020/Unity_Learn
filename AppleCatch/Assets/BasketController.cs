using UnityEngine;

public class BasketController : MonoBehaviour
{
	public AudioClip appleSE;

	public AudioClip bombSE;

	private AudioSource aud;

	private GameObject director;

	// Start is called before the first frame update
	private void Start()
	{
		director = GameObject.Find("GameDirector");
		aud = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit, Mathf.Infinity))
				transform.position = new Vector3(
					Mathf.RoundToInt(hit.point.x),
					0,
					Mathf.RoundToInt(hit.point.z)
				);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		Destroy(other.gameObject);
		if (other.gameObject.CompareTag("Apple"))
		{
			director.GetComponent<GameDirector>().GetApple();
			aud.PlayOneShot(appleSE);
		}
		else if (other.gameObject.CompareTag("Bomb"))
		{
			director.GetComponent<GameDirector>().GetBomb();
			aud.PlayOneShot(bombSE);
		}
	}
}