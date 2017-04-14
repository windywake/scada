﻿/*
 * Copyright 2017 Mikhail Shiryaev
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 * 
 * Product  : Rapid SCADA
 * Module   : ScadaSchemeCommon
 * Summary  : Size in two-dimensional space
 * 
 * Author   : Mikhail Shiryaev
 * Created  : 2017
 * Modified : 2017
 */

using Scada.Scheme.Model.PropertyGrid;
using System.ComponentModel;
using System.Xml;

namespace Scada.Scheme.Model.DataTypes
{
    /// <summary>
    /// Size in two-dimensional space
    /// <para>Размер в двумерном пространстве</para>
    /// </summary>
    [TypeConverter(typeof(SizeConverter))]
    public struct Size
    {
        /// <summary>
        /// Размер по умолчанию
        /// </summary>
        public static readonly Size Default = new Size(100, 100);


        /// <summary>
        /// Конструктор
        /// </summary>
        public Size(int width, int height)
            : this()
        {
            Width = width;
            Height = height;
        }


        /// <summary>
        /// Получить или установить ширину
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Получить или установить высоту
        /// </summary>
        public int Height { get; set; }


        /// <summary>
        /// Получить значение дочернего XML-узла в виде размера
        /// </summary>
        public static Size GetChildAsSize(XmlNode parentXmlNode, string childNodeName)
        {
            XmlNode node = parentXmlNode.SelectSingleNode(childNodeName);
            return node == null ?
                Default :
                new Size(node.GetChildAsInt("Width"), node.GetChildAsInt("Height"));
        }
    }
}
