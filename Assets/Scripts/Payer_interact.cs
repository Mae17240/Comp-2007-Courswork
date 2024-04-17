using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Payer_interact : MonoBehaviour
{
    private List<Transform> npcList;

    private void Update() {

        if(Input.GetKeyDown(KeyCode.E)) {
            float npc_interact_range = 2f;
            Collider [] ColliderArray = Physics.OverlapSphere(transform.position, npc_interact_range);

            foreach (Collider collider in ColliderArray) {
              if  (collider.TryGetComponent(out NPC_interactacble npc_Interactacble))
                {
                    npc_Interactacble.Interact();
                }
            }
        }
    }
}
