using UnityEngine;

public class movement : MonoBehaviour {

    float speed = 10f;

    // Update is called once per frame
    void Update() {

        float horizontalInput = (Input.GetAxis("Horizontal")) * speed * Time.deltaTime;

        transform.Translate(horizontalInput, 0, 0);

    }
}
