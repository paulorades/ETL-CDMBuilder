﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using org.ohdsi.cdm.framework.entities.Builder;
using org.ohdsi.cdm.framework.entities.Omop;

namespace org.ohdsi.cdm.framework.entities.DataReaders.v5 
{
   public class ConditionOccurrenceDataReader52 : IDataReader
   {
      private readonly IEnumerator<ConditionOccurrence> conditionEnumerator;
      private readonly KeyMasterOffset offset;
      
      // A custom DataReader is implemented to prevent the need for the HashSet to be transformed to a DataTable for loading by SqlBulkCopy
      public ConditionOccurrenceDataReader52(List<ConditionOccurrence> batch, KeyMasterOffset offset)
      {
         conditionEnumerator = batch.GetEnumerator();
         this.offset = offset;
      }

      public bool Read()
      {
         return conditionEnumerator.MoveNext();
      }
      
      public int FieldCount
      {
         get { return 15; }
      }

      // is this called only because the datatype specific methods are not implemented?  
      // probably performance to be gained by not passing object back?
      public object GetValue(int i)
      {
         switch (i)
         {
            case 0:
               return conditionEnumerator.Current.Id + offset.ConditionOccurrenceOffset;
            case 1:
               return conditionEnumerator.Current.PersonId;
            case 2:
               return conditionEnumerator.Current.ConceptId;
            case 3:
               return conditionEnumerator.Current.StartDate;
            case 4:
               return conditionEnumerator.Current.StartTime ?? conditionEnumerator.Current.StartDate.ToString("HH:mm:ss", CultureInfo.InvariantCulture);
            case 5:
               return conditionEnumerator.Current.EndDate;
            case 6:
               return conditionEnumerator.Current.EndTime;
            case 7:
               return conditionEnumerator.Current.TypeConceptId;
            case 8:
               return conditionEnumerator.Current.StopReason;
            case 9:
               return conditionEnumerator.Current.ProviderId == 0 ? null : conditionEnumerator.Current.ProviderId;
            case 10:
               return conditionEnumerator.Current.VisitOccurrenceId + offset.VisitOccurrenceOffset;
            case 11:
               return conditionEnumerator.Current.StatusConceptId;
            case 12:
               return conditionEnumerator.Current.SourceValue;
            case 13:
               return conditionEnumerator.Current.SourceConceptId;
            case 14:
               return conditionEnumerator.Current.StatusSourceValue;
            default:
               throw new NotImplementedException();
         }
      }

      public string GetName(int i)
      {
         switch (i)
         {
            case 0:
               return "Id";
            case 1:
               return "PersonId";
            case 2:
               return "ConceptId";
            case 3:
               return "StartDate";
            case 4:
               return "StartTime";
            case 5:
               return "EndDate";
            case 6:
               return "EndTime";
            case 7:
               return "TypeConceptId";
            case 8:
               return "StopReason";
            case 9:
               return "ProviderId";
            case 10:
               return "VisitOccurrenceId";
            case 11:
               return "StatusConceptId";
            case 12:
               return "SourceValue";
            case 13:
               return "SourceConceptId";
            case 14:
               return "StatusSourceValue";
            default:
               throw new NotImplementedException();
         }
      }

      #region implementationn not required for SqlBulkCopy
      public bool NextResult()
      {
         throw new NotImplementedException();
      }

      public void Close()
      {
         throw new NotImplementedException();
      }

      public bool IsClosed
      {
         get { throw new NotImplementedException(); }
      }

      public int Depth
      {
         get { throw new NotImplementedException(); }
      }

      public DataTable GetSchemaTable()
      {
         throw new NotImplementedException();
      }

      public int RecordsAffected
      {
         get { throw new NotImplementedException(); }
      }

      public void Dispose()
      {
         throw new NotImplementedException();
      }

      public bool GetBoolean(int i)
      {
         return (bool)GetValue(i);
      }

      public byte GetByte(int i)
      {
         return (byte)GetValue(i);
      }

      public long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length)
      {
         throw new NotImplementedException();
      }

      public char GetChar(int i)
      {
         return (char)GetValue(i);
      }

      public long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length)
      {
         throw new NotImplementedException();
      }

      public IDataReader GetData(int i)
      {
         throw new NotImplementedException();
      }

      public string GetDataTypeName(int i)
      {
         throw new NotImplementedException();
      }

      public DateTime GetDateTime(int i)
      {
         return (DateTime)GetValue(i);
      }

      public decimal GetDecimal(int i)
      {
         return (decimal)GetValue(i);
      }

      public double GetDouble(int i)
      {
         return Convert.ToDouble(GetValue(i));
      }

      public Type GetFieldType(int i)
      {
         switch (i)
         {
            case 0:
               return typeof(long);
            case 1:
               return typeof(long);
            case 2:
               return typeof(long);
            case 3:
               return typeof(DateTime);
            case 4:
               return typeof(string);
            case 5:
               return typeof(DateTime);
            case 6:
               return typeof(string);
            case 7:
               return typeof(long);
            case 8:
               return typeof(string);
            case 9:
               return typeof(long?);
            case 10:
               return typeof(long);
            case 11:
               return typeof(long);
            case 12:
               return typeof(string);
            case 13:
               return typeof(long);
            case 14:
               return typeof(string);
            default:
               throw new NotImplementedException();
         }
      }

      public float GetFloat(int i)
      {
         return (float)GetValue(i);
      }

      public Guid GetGuid(int i)
      {
         return (Guid)GetValue(i);
      }

      public short GetInt16(int i)
      {
         return (short)GetValue(i);
      }

      public int GetInt32(int i)
      {
         return (int)GetValue(i);
      }

      public long GetInt64(int i)
      {
         return Convert.ToInt64(GetValue(i));
      }

      public int GetOrdinal(string name)
      {
         throw new NotImplementedException();
      }

      public string GetString(int i)
      {
         return (string)GetValue(i);
      }

      public int GetValues(object[] values)
      {
         throw new NotImplementedException();
      }

      public bool IsDBNull(int i)
      {
         return GetValue(i) == null;
      }

      public object this[string name]
      {
         get { throw new NotImplementedException(); }
      }

      public object this[int i]
      {
         get { throw new NotImplementedException(); }
      }
      #endregion
   }
}
