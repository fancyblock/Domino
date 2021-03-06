﻿using UnityEngine;
using System.Collections;

public class StartPoint : MonoBehaviour 
{
    public DominoStage m_dominoStage;
    public float m_forceRange;
	
    /// <summary>
    /// trigger the domino from a direction 
    /// </summary>
    [ContextMenu("Trigger")]
    public void Trigger()
    {
        float angle;
        Vector3 axis;
        transform.localRotation.ToAngleAxis( out angle, out axis );
        angle = angle * Mathf.PI / 180.0f;

        Vector2 dir = Vector2.zero;
        dir.Set(Mathf.Cos(angle), Mathf.Sin(angle));

        m_dominoStage.ForceToSpot( new Vector2( transform.localPosition.x, transform.localPosition.y ),
           dir , m_forceRange );
    }

    /// <summary>
    /// trigger a point range 
    /// </summary>
    public void TriggerPoint()
    {
        m_dominoStage.HitDominos(new Vector2(transform.localPosition.x, transform.localPosition.y),
            m_forceRange);
    }

}
