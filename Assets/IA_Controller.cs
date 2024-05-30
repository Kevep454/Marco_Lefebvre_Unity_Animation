using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum IAState
{
    None,
    Idle,
    PlayerSeen,
    PlayerNear,
    RandomAnim,
}
public class IA_Controller : MonoBehaviour
{
    private IAState _State = IAState.None;
    [SerializeField]
    public bool playerNear = false;

    private void Behaviour()
    {
        switch (_State)
        {
            case IAState.None:
                break;
            case IAState.Idle:
                break;
            case IAState.PlayerSeen:
                break;
            case IAState.PlayerNear:
                break;
            case IAState.RandomAnim:
                break;
        }
    }

    private void CheckTransition()
    {
        switch (_State)
        {
            case IAState.None:
                break;
            case IAState.Idle:
                if (playerNear)
                {
                    _State = IAState.PlayerNear;
                }
                break;
            case IAState.PlayerSeen:
                if (playerNear)
                {
                    _State = IAState.PlayerNear;
                }
                break;
            case IAState.PlayerNear:
                if (playerNear)
                {
                    _State = IAState.PlayerNear;
                }
                break;
            case IAState.RandomAnim:
                if (playerNear)
                {
                    _State = IAState.PlayerNear;
                }
                break;
        }
    }
}