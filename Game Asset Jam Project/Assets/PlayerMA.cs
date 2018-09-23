using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMA : MonoBehaviour
{

    public static void EliminateChef(PlayerMovement Chef)
    {
        Destroy(Chef.gameObject);
    }
}