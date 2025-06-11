using UnityEngine;
using System.Collections.Generic;

public class PlayerKeyCollector : MonoBehaviour
{
    private GameObject keyNearby = null;
    private HashSet<int> collectedKeyIDs = new HashSet<int>();

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && keyNearby != null)
        {
            KeyItem key = keyNearby.GetComponent<KeyItem>();
            if (key != null && !collectedKeyIDs.Contains(key.keyID))
            {
                collectedKeyIDs.Add(key.keyID);
                Debug.Log("Pegou a chave " + key.keyID);

                // Verifica todas as portas da cena
                DoorController[] doors = FindObjectsOfType<DoorController>();
                foreach (DoorController door in doors)
                {
                    door.TryOpenDoor(this);
                }

                Destroy(keyNearby);
                keyNearby = null;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<KeyItem>() != null)
        {
            keyNearby = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == keyNearby)
        {
            keyNearby = null;
        }
    }

    public bool HasKey(int keyID)
    {
        return collectedKeyIDs.Contains(keyID);
    }
}
