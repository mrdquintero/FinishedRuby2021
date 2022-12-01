using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    //this will cause ruby to lose 1 health when she comes in contact with a negative gameObject
    void OnTriggerStay2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();
        if (controller != null)
        {
            controller.ChangeHealth(-1);
        }
    }
}
