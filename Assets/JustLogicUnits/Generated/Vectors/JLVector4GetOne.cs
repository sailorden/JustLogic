using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Vectors/Get/Get One (Vector4)")]
[UnitFriendlyName("Get One")]
[UnitUsage(typeof(Vector4), HideExpressionInActionsList = true)]
public class JLVector4GetOne : JLExpression
{
    public override object GetAnyResult(IExecutionContext context)
    {
        return Vector4.one;
    }
}
