using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

namespace Tanks 
{
    public class TankPlayer : MonoBehaviourPunCallbacks
    {
        private Complete.TankMovement m_Movement;
        private Complete.TankShooting m_Shooting;

        private void Awake()
        {
            m_Movement = GetComponent<Complete.TankMovement>();
            m_Shooting = GetComponent<Complete.TankShooting>();

            if (!photonView.IsMine)
            {
                m_Movement.enabled = false;
                m_Shooting.enabled = false;

                enabled = false;
            }
        }
    }
}
