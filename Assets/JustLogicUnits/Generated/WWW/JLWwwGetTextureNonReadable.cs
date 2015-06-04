using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("WWW/Get Texture Non Readable")]
[UnitFriendlyName("WWW.Get Texture Non Readable")]
[UnitUsage(typeof(Texture2D), HideExpressionInActionsList = true)]
public class JLWwwGetTextureNonReadable : JLExpression
{
    [Parameter(ExpressionType = typeof(WWW))]
    public JLExpression OperandValue;

    public override object GetAnyResult(IExecutionContext context)
    {
        WWW opValue = OperandValue.GetResult<WWW>(context);
        return opValue.textureNonReadable;
    }
}
