﻿// GTA2.NET
// 
// File: DeltaSubItem.cs
// Created: 22.04.2013
// 
// 
// Copyright (C) 2010-2013 Hiale
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software
// and associated documentation files (the "Software"), to deal in the Software without restriction,
// including without limitation the rights to use, copy, modify, merge, publish, distribute,
// sublicense, and/or sell copies of the Software, and to permit persons to whom the Software
// is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies
// or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR
// IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// 
// Grand Theft Auto (GTA) is a registred trademark of Rockstar Games.
using System;
using System.Globalization;
using Microsoft.Xna.Framework;

namespace Hiale.GTA2NET.Core.Helper
{
    [Serializable]
    public class DeltaSubItem
    {
        public int Index { get; set; }

        public CompactRectangle Rectangle { get; set; }

        public Point RelativePosition { get; set; }

        //DeltaType?

        public DeltaSubItem()
        {
            //XML Serializer
        }

        public DeltaSubItem(int index, int width, int height)
        {
            Index = index;
            Rectangle = new CompactRectangle(0, 0, width, height);
        }

        public override string ToString()
        {
            return Index.ToString(CultureInfo.InvariantCulture);
        }

    }
}