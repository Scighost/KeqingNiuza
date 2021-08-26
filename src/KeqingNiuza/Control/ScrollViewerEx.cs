﻿using HandyControl.Controls;
using System.Windows.Input;

namespace KeqingNiuza.Control
{
    public class ScrollViewerEx : ScrollViewer
    {
        protected override void OnMouseWheel(MouseWheelEventArgs e)
        {
            if (ViewportHeight + VerticalOffset >= ExtentHeight && e.Delta <= 0)
            {
                return;
            }

            if (VerticalOffset == 0 && e.Delta >= 0)
            {
                return;
            }

            base.OnMouseWheel(e);
        }
    }
}
