using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
	public float speed = 150.0f;

	private Rigidbody2D rb;

	void Start() {
		rb = GetComponent<Rigidbody2D>();
	}
	void Update()
    {

        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(hAxis, vAxis, 0) * speed * Time.deltaTime;

        transform.Translate(hAxis, vAxis, 0);

		if (transform.position.x < -70) {
			transform.position = new Vector2 (-70, transform.position.y);
		} else if (transform.position.x > 70) {
			transform.position = new Vector2 (70, transform.position.y);
		} else if (transform.position.y < -35) {
            transform.position = new Vector2(transform.position.x, -35);
        }
    }
}
