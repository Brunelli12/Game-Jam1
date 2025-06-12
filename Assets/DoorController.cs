using UnityEngine;

public class DoorController : MonoBehaviour
{
    public int[] requiredKeyIDs;
    public Vector3 teleportDestination;
    private bool isOpen = false;

    public bool isVictoryDoor = false;  

    public void TryOpenDoor(PlayerKeyCollector player)
    {
        if (isOpen) return;

        foreach (int id in requiredKeyIDs)
        {
            if (!player.HasKey(id))
                return;
        }

        OpenDoor();
    }

    void OpenDoor()
    {
        isOpen = true;
        Debug.Log("Porta aberta!");
        
    }

    public bool IsOpen()
    {
        return isOpen;
    }

    public Vector3 GetTeleportDestination()
    {
        return teleportDestination;
    }
}

