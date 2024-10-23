using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace yodan
{
    public class BasicBoatMono : MonoBehaviour
    {
        [ContextMenu("teleport forward")]
        public void TeleportForward()
        {
            transform.position += transform.forward * 1;
        }
    }
}
