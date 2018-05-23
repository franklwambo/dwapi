﻿using System;
using System.Data;

namespace Dwapi.SharedKernel.Utility
{
    public static class DataRecordExtender
    {
        public static string GetStringOrDefault(this IDataRecord reader, string columnName)
        {
            object columnValue = reader[reader.GetOrdinal(columnName)];
            if (!(columnValue is DBNull))
            {
                return columnValue.ToString();
            }

            return string.Empty;
        }

        public static int? GetNullIntOrDefault(this IDataRecord reader, string columnName)
        {
            object columnValue = reader[reader.GetOrdinal(columnName)];
            if (!(columnValue is DBNull))
            {
                int o;
                if (int.TryParse(columnValue.ToString(), out o))
                    return o;
                return null;
            }

            return null;
        }

        public static DateTime? GetNullDateOrDefault(this IDataRecord reader, string columnName)
        {
            object columnValue = reader[reader.GetOrdinal(columnName)];
            if (!(columnValue is DBNull))
            {
                return (DateTime) columnValue;
            }

            return null;
        }

    }
}