/// 
/// The MIT License (MIT)
/// 
/// Copyright (c) 2014 João Francisco Biondo Trinca <wolfulus@gmail.com>
/// 
/// Permission is hereby granted, free of charge, to any person obtaining a copy
/// of this software and associated documentation files (the "Software"), to deal
/// in the Software without restriction, including without limitation the rights
/// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
/// copies of the Software, and to permit persons to whom the Software is
/// furnished to do so, subject to the following conditions:
/// 
/// The above copyright notice and this permission notice shall be included in
/// all copies or substantial portions of the Software.
/// 
/// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
/// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
/// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
/// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
/// /// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
/// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
/// THE SOFTWARE.
/// 

namespace Almirante.SyncTool.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;
    using Nini.Ini;
    using Nini.Config;

    /// <summary>
    /// File/folder property.
    /// </summary>
    public class SynctoolProperty
    {
        public bool Copy 
        { 
            get; 
            set; 
        }

        public bool Process
        {
            get;
            set;
        }

        public string Importer
        {
            get;
            set;
        }

        public string Processor
        {
            get;
            set;
        }

        public static SynctoolProperty Load(string path)
        {
            if (!File.Exists(path))
            {
                return null;
            }
            else
            {
                try
                {
                    IConfigSource config = new IniConfigSource(path);
                    return new SynctoolProperty()
                    {
                        Copy = config.Configs["SyncTool"].GetBoolean("Copy", false),
                        Importer = config.Configs["SyncTool"].GetString("Importer", null),
                        Processor = config.Configs["SyncTool"].GetString("Processor", null),
                        Process = config.Configs["SyncTool"].GetBoolean("Process", true)
                    };
                }
                catch (System.Exception)
                {
                    return null;
                }
            }
        }
    }
}
