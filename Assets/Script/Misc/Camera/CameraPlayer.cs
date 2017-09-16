using UnityEngine;
public class CameraPlayer : MonoBehaviour {
    public Transform target;

	// Update is called once per frame
	void FixedUpdate () {
		if (target == null) {
			return;
		} else {
			Vector3 newPos = target.position;
			newPos.z = -10;
			transform.position = newPos;
		}
	}
}
