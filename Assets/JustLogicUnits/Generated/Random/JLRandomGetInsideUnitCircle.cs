using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Random/Get Inside Unit Circle")]
[UnitFriendlyName("Random.Get Inside Unit Circle")]
[UnitUsage(typeof(Vector2), HideExpressionInActionsList = true)]
public class JLRandomGetInsideUnitCircle : JLExpression
{
    public override object GetAnyResult(IExecutionContext context)
    {
        return Random.insideUnitCircle;
    }
}
