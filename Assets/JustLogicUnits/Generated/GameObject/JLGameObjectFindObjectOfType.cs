using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Object/Find Object Of Type")]
[UnitFriendlyName("Find Object Of Type")]
[UnitUsage(typeof(Object), HideExpressionInActionsList = true)]
public class JLGameObjectFindObjectOfType : JLExpression
{
    [Parameter(ExpressionType = typeof(System.Type))]
    public JLExpression Type;

    public override object GetAnyResult(IExecutionContext context)
    {
        return FindObjectOfType(Type.GetResult<System.Type>(context));
    }
}
