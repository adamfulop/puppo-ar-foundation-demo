using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARScene : MonoBehaviour {
    [SerializeField] private ARPlaneManager arPlaneManager;

    private void Start() {
        arPlaneManager.planeUpdated += PlaneUpdated;
    }

    private void PlaneUpdated(ARPlaneUpdatedEventArgs args) {
        var planeTransform = args.plane.transform;
        var objectTransform = transform;
        objectTransform.position = planeTransform.position;
        objectTransform.rotation = planeTransform.rotation;
    }
}