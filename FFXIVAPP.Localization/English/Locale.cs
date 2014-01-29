﻿// FFXIVAPP.Localization
// Locale.cs
// 
// Copyright © 2013 ZAM Network LLC
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without modification, are permitted provided that the 
// following conditions are met: 
// 
//  * Redistributions of source code must retain the above copyright notice, this list of conditions and the following 
//    disclaimer. 
//  * Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the 
//    following disclaimer in the documentation and/or other materials provided with the distribution. 
//  * Neither the name of ZAM Network LLC nor the names of its contributors may be used to endorse or promote products 
//    derived from this software without specific prior written permission. 
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, 
// INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE 
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, 
// SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR 
// SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
// WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE. 

using System.Windows;

namespace FFXIVAPP.Localization.English
{
    internal static partial class Locale
    {
        private static readonly ResourceDictionary Dictionary = new ResourceDictionary();

        public static ResourceDictionary Context(string resourceName = "")
        {
            Dictionary.Clear();

            switch (resourceName)
            {
                case "client":
                    SetClientLocale();
                    break;
                case "event":
                    SetEventPluginLocale();
                    break;
                case "informer":
                    SetInformerPluginLocale();
                    break;
                case "parse":
                    SetParsePluginLocale();
                    break;
                case "radar":
                    SetRadarPluginLocale();
                    break;
                case "log":
                    SetLogPluginLocale();
                    break;
                case "widgets":
                    SetWidgetsPluginLocale();
                    break;
                default:
                    SetClientLocale();
                    SetEventPluginLocale();
                    SetInformerPluginLocale();
                    SetParsePluginLocale();
                    SetRadarPluginLocale();
                    SetLogPluginLocale();
                    SetWidgetsPluginLocale();
                    break;
            }

            return Dictionary;
        }
    }
}
