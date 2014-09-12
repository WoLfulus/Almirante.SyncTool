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
    using System.Collections.Generic;

    /// <summary>
    /// Project class.
    /// </summary>
    public class UserProject
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public UserProject()
        {
            this.SourceFolders = new List<string>();
        }

        /// <summary>
        /// Project name.
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Project file.
        /// </summary>
        public string ProjectFile
        {
            get;
            set;
        }

        /// <summary>
        /// Source folders.
        /// </summary>
        public List<string> SourceFolders
        {
            get;
            set;
        }
    }
}