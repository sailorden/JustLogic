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
using JustLogic.Core;
using JustLogic.Core.Events;

using UnityEngine;

[ExecuteInEditMode]
//[AddComponentMenu("Just Logic/JL Event Handler")]
public class JustLogicEventHandler : JustLogicEventHandlerLite
{
    [NonSerialized]
    List<KeyCode> _downKeys;

    protected override void Awake()
    {
        _downKeys = new List<KeyCode>();
        base.Awake();
    }

    protected void OnGUI()
    {
        if (!Application.isPlaying) return;
#if !JUSTLOGIC_FREE
        Trigger(new OnGUI());
#endif
        if (Event.current.type == EventType.KeyDown)
        {
            if (!_downKeys.Contains(Event.current.keyCode))
            {
                _downKeys.Add(Event.current.keyCode);
#if !JUSTLOGIC_FREE
                Trigger(new OnKeyDown(), Event.current.keyCode);
#endif
            }
        }
        else if (Event.current.type == EventType.KeyUp)
        {
            if (_downKeys.Remove(Event.current.keyCode))
                Trigger(new OnKeyUp(), Event.current.keyCode);
        }
    }
}
