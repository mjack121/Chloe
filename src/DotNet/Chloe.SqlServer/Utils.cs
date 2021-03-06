﻿using Chloe.DbExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chloe.SqlServer
{
    internal static class Utils
    {
        public static void CheckNull(object obj, string paramName = null)
        {
            if (obj == null)
                throw new ArgumentNullException(paramName);
        }
        public static bool IsNullable(Type type)
        {
            Type unType;
            return IsNullable(type, out unType);
        }
        public static bool IsNullable(Type type, out Type unType)
        {
            unType = Nullable.GetUnderlyingType(type);
            return unType != null;
        }
        public static Type GetUnderlyingType(Type type)
        {
            Type unType;
            if (!IsNullable(type, out unType))
                unType = type;

            return unType;
        }
        public static bool AreEqual(object obj1, object obj2)
        {
            if (obj1 == null && obj2 == null)
                return true;

            if (obj1 != null)
            {
                return obj1.Equals(obj2);
            }

            if (obj2 != null)
            {
                return obj2.Equals(obj1);
            }

            return object.Equals(obj1, obj2);
        }

    }
}
