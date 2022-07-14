using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Transform playerSlot;
    [SerializeField] Transform enemySlot;

    List<Transform> playerSlots;
    List<Transform> enemySlots;

    private void Awake()
    {
        playerSlots = new List<Transform>(playerSlot.GetComponentsInChildren<Transform>());
        enemySlots = new List<Transform>(enemySlot.GetComponentsInChildren<Transform>());
    }
}
