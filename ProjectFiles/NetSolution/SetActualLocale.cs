#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.Retentivity;
using FTOptix.UI;
using FTOptix.NativeUI;
using FTOptix.CoreBase;
using FTOptix.Core;
using FTOptix.NetLogic;
#endregion

public class SetActualLocale : BaseNetLogic
{
    public override void Start()
    {
        var actualLocale = LogicObject.GetVariable("ActualLocale").Value;
        var localeIdVar = Session.Get<IUAVariable>("ActualLocaleId");
        localeIdVar.Value = actualLocale;
        
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }
}
