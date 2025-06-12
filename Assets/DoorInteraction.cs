using UnityEngine;

public class DoorInteraction : MonoBehaviour
{
    private DoorController nearbyDoor;

    public GameObject telaVitoria;  

    void Update()
    {
        if (nearbyDoor != null && nearbyDoor.IsOpen())
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (nearbyDoor.isVictoryDoor)
                {
                    Debug.Log("Vitória!");
                    telaVitoria.SetActive(true);
                    Time.timeScale = 0f; 
                }
                else
                {
                    transform.position = nearbyDoor.GetTeleportDestination();
                    Debug.Log("Teleportado para " + nearbyDoor.GetTeleportDestination());
                }
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
