using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageDestroyScript : MonoBehaviour
{
    public void OnDestroy()
    {
        Destroy(gameObject);
    }
}
