using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class Target : MonoBehaviour
{
    [SerializeField] private SortManager sm;
    [SerializeField] private Transform circle;
    private void Update()
    {
        circle.gameObject.SetActive(sm.ShouldSort);
        if (!sm.ShouldSort) return;

        if(sm.threshold > 0 && sm.balls.Count > 0)
        circle.localScale = Vector3.one * (transform.position.magnitude - sm.balls[sm.threshold - 1].transform.position.magnitude) * 2f;
    }
}