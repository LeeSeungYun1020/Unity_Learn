using UnityEngine;

public class BamsongiController : MonoBehaviour
{
	// Start is called before the first frame update
	private void Start()
	{
		// shoot(new Vector3(0, 200, 2000));
	}

	// Update is called once per frame
	private void Update()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
		GetComponent<Rigidbody>().isKinematic = true;
		GetComponent<ParticleSystem>().Play();
	}

	public void shoot(Vector3 dir)
	{
		GetComponent<Rigidbody>().AddForce(dir);
	}
}