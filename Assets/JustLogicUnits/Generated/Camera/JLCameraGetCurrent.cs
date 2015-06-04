using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Camera/Get Current")]
[UnitFriendlyName("Camera.Get Current")]
[UnitUsage(typeof(Camera), HideExpressionInActionsList = true)]
public class JLCameraGetCurrent : JLExpression
{
    public override object GetAnyResult(IExecutionContext context)
    {
        return Camera.current;
    }
}
