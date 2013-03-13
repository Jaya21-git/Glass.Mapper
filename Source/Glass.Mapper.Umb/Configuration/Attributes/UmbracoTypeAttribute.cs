/*
   Copyright 2012 Michael Edwards
 
   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
 
*/ 
//-CRE-

using System;
using Glass.Mapper.Configuration.Attributes;
using Glass.Mapper.Configuration;

namespace Glass.Mapper.Umb.Configuration.Attributes
{
    /// <summary>
    /// UmbracoTypeAttribute
    /// </summary>
    public class UmbracoTypeAttribute : AbstractTypeAttribute
    {
        /// <summary>
        /// Indicates the content type to use when trying to create an item
        /// </summary>
        /// <value>
        /// The content type alias.
        /// </value>
        public string ContentTypeAlias { get; set; }

        /// <summary>
        /// Indicates that the class is used in a code first scenario.
        /// </summary>
        /// <value>
        ///   <c>true</c> if [code first]; otherwise, <c>false</c>.
        /// </value>
        public bool CodeFirst { get; set; }

        /// <summary>
        /// Overrides the default content type name when using code first
        /// </summary>
        /// <value>
        /// The name of the content type.
        /// </value>
        public string ContentTypeName { get; set; }

        /// <summary>
        /// Configures the specified type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="config">The config.</param>
        /// <exception cref="ConfigurationException">Type configuration is not of type {0}.Formatted(typeof(UmbracoTypeConfiguration).FullName)</exception>
        public override void Configure(Type type, AbstractTypeConfiguration config)
        {
            var umbConfig = config as UmbracoTypeConfiguration;

            if (umbConfig == null)
                throw new ConfigurationException(
                    "Type configuration is not of type {0}".Formatted(typeof(UmbracoTypeConfiguration).FullName));

            umbConfig.ContentTypeAlias = ContentTypeAlias;
            umbConfig.CodeFirst = CodeFirst;
            umbConfig.ContentTypeName = ContentTypeName;

            base.Configure(type, config);
        }
    }
}



