﻿using NetSettings.Data;
using System;
using System.Collections.Generic;
using NetSettingsCore.Common;

namespace NetSettings
{
    internal class ItemHelpers
    {
        public static void BuildQualifiedNames(Dictionary<string, ItemTree> aQualifiedNames, ItemTree item, ItemTree parent)
        {
            ItemTree currentParent = parent == null || parent.type == "root" ? null : parent;
            if (item.type != "root")
            {
                if (currentParent == null)
                {
                    item.FullName = item.name;
                }
                else
                {
                    item.FullName = String.Format("{0}.{1}", currentParent.FullName, item.name);
                }
            }
            if (item.subItems != null)
                foreach (ItemTree subItem in item.subItems)
                {
                    BuildQualifiedNames(aQualifiedNames, subItem, item);

                }

            if (item.FullName != null)
            {
                aQualifiedNames.Add(item.FullName, item);
            }
        }

        public static void BuildQualifiedNames(ItemTree aRoot, out Dictionary<string, ItemTree> aQualifiedNames)
        {
            aQualifiedNames = null;
            if (aRoot.type == "root")
            {
                aQualifiedNames = new Dictionary<string, ItemTree>(StringComparer.OrdinalIgnoreCase);
                BuildQualifiedNames(aQualifiedNames, aRoot, null);
            }
        }

        //public static void NormalizeItemValue(ItemTree aItem)
        //{
           
        //}

        internal static void NormalizeItemData(ItemTree aItem, ref object obj)
        {
            if (aItem.type == "color")
            {
                var lastCulture = System.Threading.Thread.CurrentThread.CurrentCulture;
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
                try
                {
                    if (obj != null && obj is string)
                        obj = ColorTranslator.FromHtml(obj as string);
                }
                finally
                {
                    System.Threading.Thread.CurrentThread.CurrentCulture = lastCulture;
                }

                
			//Make sure all the colors are created from (R,G,B) and not known names
                var c = (IColor)(obj);
                obj = c.FromArgb(c.R, c.G, c.B);

                //TODO: Delete this lines? if no remove the System.Drawing
                //if (aItem.value != null && aItem.value is string)
                //    aItem.value = System.Drawing.ColorTranslator.FromHtml(aItem.value as string);
            }

            if (aItem.type == "number")
            {
                //normalize all our numbers to double data type
                if (obj != null && obj is Int64)
                    obj = (double)(Int64)obj;
            }
        }
    }

    internal class ColorTranslator
    {
        public static IColor FromHtml(string s)
        {
            throw new NotImplementedException();
        }
    }
}
