using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform target;         // The target object to follow
    public Vector3 offset = new Vector3(0f, 5f, -10f);   // Offset from the target in world space

    public float smoothSpeed = 0.125f;       // Smoothness of camera movement

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;

            transform.LookAt(target);   // Ensure the camera looks at the target
        }
    }
}
