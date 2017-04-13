using UnityEngine;

public class SphereCommands : MonoBehaviour
{
    // Called by GazeGestureManager when the user performs a Select gesture
    void OnSelect()
    {
        // If the sphere has no Rigidbody component, add one to enable physics.
        //if (!this.GetComponent<Rigidbody>())
        //{
        //  var rigidbody = this.gameObject.AddComponent<Rigidbody>();
        //rigidbody.collisionDetectionMode = CollisionDetectionMode.Continuous;
        //}
        GameObject thing = GameObject.Find("Cube 2");
        if (thing.transform.localScale == new Vector3(0.1f, 0.1f, 0.1f)) {
            thing.transform.localScale = new Vector3(0, 0, 0);
        }
        else
        {
            thing.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        }
            
    }
}