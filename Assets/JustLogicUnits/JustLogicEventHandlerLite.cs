﻿/*
	
	This file is a part of JustLogic product which is distributed under 
	the BSD 3-clause "New" or "Revised" License
	
	Copyright (c) 2015. All rights reserved. 
	Authors: Vladyslav Taranov.
	
	Redistribution and use in source and binary forms, with or without
	modification, are permitted provided that the following conditions are met:
	
	* Redistributions of source code must retain the above copyright notice, this
	  list of conditions and the following disclaimer.
	
	* Redistributions in binary form must reproduce the above copyright notice,
	  this list of conditions and the following disclaimer in the documentation
	  and/or other materials provided with the distribution.
	
	* Neither the name of JustLogic nor the names of its
	  contributors may be used to endorse or promote products derived from
	  this software without specific prior written permission.
	
	THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
	AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
	IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
	DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE
	FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
	DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
	SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
	CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
	OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
	OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

 */
  
using System;
using System.Collections.Generic;
using System.Linq;
using JustLogic;
using JustLogic.Core;
using JustLogic.Core.Events;

using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Just Logic/JL Event Handler")]
public class JustLogicEventHandlerLite : JustLogicEventHandlerBase, IScriptVariablesDescriber
{
    // also we could use MethodBase.GetCurrentMethod to parse name and parameters...
    // and seek for event by methodname in library
#if !JUSTLOGIC_FREE

    #region Animator

    public virtual void OnAnimatorIK(int layerIndex)
    {
        Trigger(new OnAnimatorIK(), layerIndex);
    }

    public virtual void OnAnimatorMove()
    {
        Trigger(new OnAnimatorMove());
    }

    #endregion

    #region Application

    public virtual void OnApplicationFocus(bool focus)
    {
        Trigger(new OnApplicationFocus(), focus);
    }

    public virtual void OnApplicationPause(bool pause)
    {
        Trigger(new OnApplicationPause(), pause);
    }

    public virtual void OnApplicationQuit()
    {
        Trigger(new OnApplicationQuit());
    }

    public virtual void OnLevelWasLoaded(int level)
    {
        Trigger(new OnLevelWasLoaded(), level);
    }

    #endregion

    #region Renderer

    public virtual void OnBecameInvisible()
    {
        Trigger(new OnBecameInvisible());
    }

    public virtual void OnBecameVisible()
    {
        Trigger(new OnBecameVisible());
    }

    #endregion

    #region Colliders Additional

    public virtual void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Trigger(new OnControllerColliderHit(), hit);
    }

    public virtual void OnJointBreak(float breakForce)
    {
        Trigger(new OnJointBreak(), breakForce);
    }

    public virtual void OnParticleCollision(GameObject other)
    {
        Trigger(new OnParticleCollision(), other);
    }

    #endregion
    
#endif

    #region Colliders

    public virtual void OnTriggerEnter(Collider other)
    {
        Trigger(new OnTriggerEnter(), other);
    }

    public virtual void OnTriggerExit(Collider other)
    {
        Trigger(new OnTriggerExit(), other);
    }

    public virtual void OnTriggerStay(Collider other)
    {
        Trigger(new OnTriggerStay(), other);
    }

    public virtual void OnCollisionEnter(Collision collision)
    {
        Trigger(new OnCollisionEnter(), collision);
    }

    public virtual void OnCollisionExit(Collision collision)
    {
        Trigger(new OnCollisionExit(), collision);
    }

    public virtual void OnCollisionStay(Collision collisionInfo)
    {
        Trigger(new OnCollisionStay(), collisionInfo);
    }

    #endregion

    #region Behavior

    protected override void Awake()
    {
        base.Awake();
        Trigger(new Awake());
    }

    public virtual void Start()
    {
        Trigger(new Start());
    }

#if !JUSTLOGIC_FREE

    public virtual void FixedUpdate()
    {
        Trigger(new FixedUpdate());
    }

    public virtual void OnDestroy()
    {
        Trigger(new OnDestroy());
    }

    public virtual void OnDisable()
    {
        Trigger(new OnDisable());
    }

#endif

    protected override void OnEnable()
    {
        base.OnEnable();
#if !JUSTLOGIC_FREE
        Trigger(new OnEnable());
#endif

    }

    #endregion

#if !JUSTLOGIC_FREE

    #region Camera

    public virtual void OnPostRender()
    {
        Trigger(new OnPostRender());
    }

    public virtual void OnPreCull()
    {
        Trigger(new OnPreCull());
    }

    public virtual void OnPreRender()
    {
        Trigger(new OnPreRender());
    }

    public virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Trigger(new OnRenderImage(), source, destination);
    }

    public virtual void OnWillRenderObject()
    {
        Trigger(new OnWillRenderObject());
    }

    public virtual void OnRenderObject()
    {
        Trigger(new OnRenderObject());
    }

    #endregion
    
#if !JUSTLOGIC_FREE
    [NonSerialized]
    static readonly Type OnTapType = typeof(OnTap);

    protected override void Update()
    {
        base.Update();
        if (!Application.isPlaying) return;
        if (EventHandlerData.EventDataClassFullName == OnTapType.FullName)
        {
            float d = 0f;
            foreach (Touch touch in Input.touches)
            {
                if (touch.phase == TouchPhase.Ended && touch.deltaTime < 0.5f && touch.deltaPosition.sqrMagnitude < 1f)
                {
                    if (d < float.Epsilon)
                        d = (Camera.main.transform.position - transform.position).magnitude * 5f;
                    Ray ray = Camera.main.ScreenPointToRay(touch.position);
                    ray.direction = ray.direction.normalized * d;
                    RaycastHit hit;
                    if (Physics.Raycast(ray, out hit)
                        && ((hit.rigidbody && hit.rigidbody.gameObject == gameObject)
                              || (hit.collider && hit.collider.gameObject == gameObject)))
                    {
                        Trigger(new OnTap());
                    }
                }
            }
        }
        Trigger(new Update());
    }
#endif

    protected void OnJLTimerTick(JustLogicTimerBase timer)
    {
        Trigger(new OnJLTimerTick(), timer);
    }

    public virtual void OnJLCustomEvent(object argument)
    {
        Trigger(new OnJLCustomEvent(), argument);
    }
#endif


}
