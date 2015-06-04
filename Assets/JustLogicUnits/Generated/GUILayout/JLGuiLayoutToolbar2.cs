using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("GUILayout/Toolbar With Images")]
[UnitFriendlyName("GUILayout.Toolbar With Images")]
[UnitUsage(typeof(System.Int32))]
public class JLGuiLayoutToolbar2 : JLExpression
{
    [Parameter(ExpressionType = typeof(System.Int32))]
    public JLExpression Selected;

    [Parameter(ExpressionType = typeof(Texture))]
    public JLExpression[] Images;

    [Parameter(ExpressionType = typeof(GUILayoutOption))]
    public JLExpression[] Options;

    public override object GetAnyResult(IExecutionContext context)
    {
        return GUILayout.Toolbar(Selected.GetResult<System.Int32>(context), Images.GetResult<Texture>(context), Options.GetResult<GUILayoutOption>(context));
    }
}
