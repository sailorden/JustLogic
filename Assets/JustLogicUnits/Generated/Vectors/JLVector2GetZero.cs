using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Vectors/Get/Get Zero (Vector2)")]
[UnitFriendlyName("Get Zero")]
[UnitUsage(typeof(Vector2), HideExpressionInActionsList = true)]
public class JLVector2GetZero : JLExpression
{
    public override object GetAnyResult(IExecutionContext context)
    {
        return Vector2.zero;
    }
}
