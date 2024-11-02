using UnityEngine;
using UnityEngine.VFX;

public class FollowCursor : MonoBehaviour
{
    public float distanceFromCamera = 10f; // The distance from camera to the object
    public VisualEffect visualEffect;

    void Start(){
        visualEffect = this.GetComponent<VisualEffect>();
    }


    void Update()
    {
        // Create a ray from camera through the mouse position
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        // Calculate the position along the ray at the specified distance
        Vector3 targetPosition = ray.GetPoint(distanceFromCamera);

        // Move the object to calculated position
        // transform.position = targetPosition;
        visualEffect.SetVector3("Position", targetPosition);
    }
}
