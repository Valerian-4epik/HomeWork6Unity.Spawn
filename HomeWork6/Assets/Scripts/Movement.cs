using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Movement : MonoBehaviour
{
    private void Start()
    {
        transform.DOMoveX(5, 5).SetLoops(-1, LoopType.Yoyo);
    }
}
 