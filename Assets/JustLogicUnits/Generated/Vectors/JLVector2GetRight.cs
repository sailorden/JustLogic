using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Vectors/Get/Get Right (Vector2)")]
[UnitFriendlyName("Get Right")]
[UnitUsage(typeof(Vector2), HideExpressionInActionsList = true)]
public class JLVector2GetRight : JLExpression
{
    public override object GetAnyResult(IExecutionContext context)
    {
        return Vector2.right;
    }
}
