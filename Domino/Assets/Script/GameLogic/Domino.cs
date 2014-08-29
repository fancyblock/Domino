﻿using UnityEngine;
using System.Collections;

public class Domino : MonoBehaviour 
{
    public const int STATE_STAND = 0;
    public const int STATE_LAY = 1;
    public const int STATE_OVERLAY = 2;

    public GameObject m_imgStand;
    public GameObject m_imgOverlay;
    public GameObject m_imgLay;
    public DominoStage m_stage;

    protected int m_state;
    protected float m_angle;

	// Use this for initialization
	void Start () 
    {
        SetStandState();
        SetAngle(0.0f);
	}
	
	// Update is called once per frame
	void Update () 
    {
	}

    /// <summary>
    /// is stand or not 
    /// </summary>
    /// <returns></returns>
    public bool IsStand()
    {
        return m_stage == STATE_STAND;
    }

    /// <summary>
    /// set stand state 
    /// </summary>
    public void SetStandState()
    {
        m_imgStand.SetActive(true);
        m_imgLay.SetActive(false);
        m_imgOverlay.SetActive(false);

        m_state = STATE_STAND;
    }

    /// <summary>
    /// set angle 
    /// </summary>
    /// <param name="angle"></param>
    public void SetAngle( float angle )
    {
        m_angle = angle;

        while( m_angle >= 360.0f )
        {
            m_angle -= 360.0f;
        }
        while( m_angle < 0.0f )
        {
            m_angle += 360.0f;
        }

        gameObject.transform.localRotation = Quaternion.AngleAxis( angle, Vector3.forward );
    }

    /// <summary>
    /// push the domino 
    /// </summary>
    /// <param name="spot"></param>
    /// <param name="forceDis"></param>
    public void Push( Vector2 spot, float forceDis )
    {
        //TODO 
    }

    /// <summary>
    /// rotation the domino 
    /// </summary>
    public void onEditRotation()
    {
        Debug.Log("[Domino]: onEditRotation");

        //[TEMP]
        SetAngle(m_angle + 30.0f);
        //[TEMP]
    }

}