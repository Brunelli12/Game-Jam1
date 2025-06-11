using UnityEngine;

public class DoorController : MonoBehaviour
{
    public int[] requiredKeyIDs; // Ex: [1, 2]
    public Vector3 teleportDestination; // Coordenadas de destino ap�s abrir e interagir
    private bool isOpen = false;

    public void TryOpenDoor(PlayerKeyCollector player)
    {
        if (isOpen) return;

        foreach (int id in requiredKeyIDs)
        {
            if (!player.HasKey(id))
                return; // Falta uma chave
        }

        OpenDoor();
    }

    void OpenDoor()
    {
        isOpen = true;
        Debug.Log("Porta aberta!");
        // Aqui voc� pode desativar a porta ou ativar uma anima��o
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
