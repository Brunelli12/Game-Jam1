using UnityEngine;

public class DoorInteraction : MonoBehaviour
{
    private DoorController nearbyDoor;

    void Update()
    {
        if (nearbyDoor != null && nearbyDoor.IsOpen())
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                transform.position = nearbyDoor.GetTeleportDestination();
                Debug.Log("Teleportado para " + nearbyDoor.GetTeleportDestination());
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Door"))
        {
            nearbyDoor = other.GetComponent<DoorController>();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Door"))
        {
            if (nearbyDoor == other.GetComponent<DoorController>())
            {
                nearbyDoor = null;
            }
        }
    }
}
