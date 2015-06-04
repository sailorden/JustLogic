using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Quaternion/Get Identity")]
[UnitFriendlyName("Get Identity")]
[UnitUsage(typeof(Quaternion), HideExpressionInActionsList = true)]
public class JLQuaternionGetIdentity : JLExpression
{
    public override object GetAnyResult(IExecutionContext context)
    {
        return Quaternion.identity;
    }
}
