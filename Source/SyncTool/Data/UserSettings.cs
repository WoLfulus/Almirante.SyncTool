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
    using System.IO;

    /// <summary>
    /// User defined settings.
    /// </summary>
    public class UserSettings
    {
        /// <summary>
        /// Creates an instance of the <see cref="UserSettings"/> class.
        /// </summary>
        public UserSettings()
        {
            this.Projects = new List<UserProject>();
        }

        /// <summary>
        /// Gets or sets all the projects by the current user.
        /// </summary>
        public List<UserProject> Projects
        {
            get;
            set;
        }

        /// <summary>
        /// Cleanups all invalid projects.
        /// </summary>
        public void Cleanup()
        {
            this.Projects.RemoveAll((p) =>
            {
                if (String.IsNullOrEmpty(p.Name))
                {
                    return true;
                }
                else if (!File.Exists(p.ProjectFile))
                {
                    return true;
                }
                foreach (string folder in p.SourceFolders)
                {
                    if (!Directory.Exists(folder))
                    {
                        return true;
                    }
                }
                return false;
            });
        }
    }
}