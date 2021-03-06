﻿using System.Windows;
using Caliburn.Micro;

namespace MiSharp.ViewModel.DialogResults
{
    public class CloseResult : Result
    {
        public override void Execute(ActionExecutionContext context)
        {
            Window window = Window.GetWindow(context.View);
            if (window != null) window.Close();

            base.Execute(context);
        }
    }
}