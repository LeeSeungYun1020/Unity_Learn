using UnityEngine;

public class MainCameraController : MonoBehaviour
{
	[SerializeField] private GameObject target;

	public float perspectiveZoomSpeed = 0.2f;
	private readonly float rotateSpeed = 200.0f;
	private readonly float wheelSpeed = 10f;
	private Camera camera;

	private Vector3 point;


	private void Start()
	{
		point = target.transform.position + new Vector3(0, 0.7f, 0);
		camera = GetComponent<Camera>();
	}

	private void Update()
	{
		if (Input.GetMouseButton(0) && Input.mousePosition.y > 300)
		{
			
			var rotationX = Input.GetAxis("Mouse X") * Time.deltaTime * rotateSpeed;
			var rotationY = Input.GetAxis("Mouse Y") * Time.deltaTime * rotateSpeed;

			transform.RotateAround(point, Vector3.right, -rotationY);
			transform.RotateAround(point, Vector3.up, rotationX);

			transform.LookAt(point);

			if (transform.position.y <= 0.1) transform.RotateAround(point, Vector3.right, rotationY);
		}

		var zoom = Input.GetAxis("Mouse ScrollWheel") * wheelSpeed;
		camera.fieldOfView -= zoom;
		camera.fieldOfView = Mathf.Clamp(camera.fieldOfView, 20f, 100f);

		if (Input.touchCount == 2)
		{
			var touchZero = Input.GetTouch(0);
			var touchOne = Input.GetTouch(1);

			var touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
			var touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

			var prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
			var touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

			var deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

			camera.fieldOfView += deltaMagnitudeDiff * perspectiveZoomSpeed;
			camera.fieldOfView = Mathf.Clamp(camera.fieldOfView, 20f, 100f);
		}
	}
}