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
    using System.Windows.Forms;
    using Polenter.Serialization;

    /// <summary>
    /// </summary>
    public class Configuration
    {
        /// <summary>
        /// Stores the configuration helper instance.
        /// </summary>
        protected static Configuration instance = null;

        /// <summary>
        /// Loads the configuration.
        /// </summary>
        protected Configuration()
        {
            bool created = false;

            try
            {
                var serializer = new SharpSerializer();
                if (!File.Exists(string.Format("Data\\Users\\{0}.xml", Environment.MachineName)))
                {
                    serializer.Serialize(new UserSettings(), string.Format("Data\\Users\\{0}.xml", Environment.MachineName));
                }
                this.User = serializer.Deserialize(string.Format("Data\\Users\\{0}.xml", Environment.MachineName)) as UserSettings;
            }
            catch (System.Exception)
            {
                this.User = new UserSettings();
                created = true;
            }
            finally
            {
                if (this.User == null)
                {
                    this.User = new UserSettings();
                    created = true;
                }
                if (created)
                {
                    var serializer = new SharpSerializer();
                    serializer.Serialize(this.User, string.Format("Data\\Users\\{0}.xml", Environment.MachineName));
                }
            }

            try
            {
                var serializer = new SharpSerializer();
                if (!File.Exists("Data\\Global\\Extensions.xml"))
                {
                    serializer.Serialize(new List<Extension>(), "Data\\Global\\Extensions.xml");
                }
                this.Extensions = serializer.Deserialize("Data\\Global\\Extensions.xml") as List<Extension>;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(string.Format("Failed to load registered file extensions. {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                var serializer = new SharpSerializer();
                if (!File.Exists("Data\\Global\\Processors.xml"))
                {
                    serializer.Serialize(new List<ContentPipeline>(), "Data\\Global\\Processors.xml");
                }
                this.Processors = serializer.Deserialize("Data\\Global\\Processors.xml") as List<ContentPipeline>;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(string.Format("Failed to load registered file processors. {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                var serializer = new SharpSerializer();
                if (!File.Exists("Data\\Global\\Importers.xml"))
                {
                    serializer.Serialize(new List<ContentPipeline>(), "Data\\Global\\Importers.xml");
                }
                this.Importers = serializer.Deserialize("Data\\Global\\Importers.xml") as List<ContentPipeline>;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(string.Format("Failed to load registered file processors. {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gets the configuration helper instance.
        /// </summary>
        public static Configuration Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Configuration();
                }
                return instance;
            }
        }

        /// <summary>
        /// Stores the user-related settings.
        /// </summary>
        public UserSettings User
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets all the extensions registered by the current user.
        /// </summary>
        public List<Extension> Extensions
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets all the extensions registered by the current user.
        /// </summary>
        public List<ContentPipeline> Processors
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets all the extensions registered by the current user.
        /// </summary>
        public List<ContentPipeline> Importers
        {
            get;
            set;
        }

        /// <summary>
        /// Saves all the configurations.
        /// </summary>
        public void Save()
        {
            var serializer = new SharpSerializer();
            serializer.Serialize(this.Extensions, "Data\\Global\\Extensions.xml");
            serializer.Serialize(this.Importers, "Data\\Global\\Importers.xml");
            serializer.Serialize(this.Processors, "Data\\Global\\Processors.xml");
            serializer.Serialize(this.User, string.Format("Data\\Users\\{0}.xml", Environment.MachineName));
        }
    }
}