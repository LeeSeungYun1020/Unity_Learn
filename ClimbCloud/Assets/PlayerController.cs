using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
	private readonly float jumpForce = 700.0f;
	private readonly float maxWalkSpeed = 2.0f;
	private readonly float walkForce = 30.0f;
	private Animator animator;

	private Rigidbody2D rigid2D;
	private readonly float threshold = 0.2f;

	// Start is called before the first frame update
	private void Start()
	{
		rigid2D = GetComponent<Rigidbody2D>();
		animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	private void Update()
	{
		if (Input.GetMouseButtonDown(0) && rigid2D.velocity.y == 0)
			rigid2D.AddForce(transform.up * jumpForce);

		var key = 0;
		if (Input.acceleration.x > threshold) key = 1;

		if (Input.acceleration.x < -threshold) key = -1;

		var speedx = Mathf.Abs(rigid2D.velocity.x);
		if (speedx < maxWalkSpeed) rigid2D.AddForce(transform.right * (key * walkForce));

		if (key != 0) transform.localScale = new Vector3(key, 1, 1);

		animator.speed = speedx / 2.0f;

		if (transform.position.y < -10) SceneManager.LoadScene("GameScene");
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		// Debug.Log("Goal!");
		SceneManager.LoadScene("ClearScene");
	}
}