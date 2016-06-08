// Copyright (c) The Avalonia Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using Gtk;
using Avalonia.Platform;
using System;

namespace Avalonia.Gtk
{
    public class PopupImpl : WindowImpl, IPopupImpl
    {
        public PopupImpl()
            : base(WindowType.Popup)
        {
        }

        public void SetFocusable(bool focusable)
        {
            // I haven't found a way to do this in GTK
        }
    }
}
