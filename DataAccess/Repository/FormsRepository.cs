﻿using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.SQLParamFinder;
using System.Data.SqlClient;
using DataAccess.DBConnetion;
using System.Data;

namespace DataAccess.Repository
{
    public class FormsRepository : RepositoryBase<stInfo>
    {        
        const string _SELECT_DOAA1_INFO = "DOAA1_INFO_SELECT_BY_DataCaptYM_DeptID_MenuID";
        const string _Insert_DOAA1_INFO = "DOAA1_INFO_INSERT";
        const string _Update_DOAA1_INFO = "DOAA1_INFO_UPDATE";
        const string _Insert_INFO2 = "stINFO2_INSERT";
        const string _Update_INFO2 = "stINFO2_UPDATE";
        const string _Insert_LIBINFO = "LIBINFO_INSERT";
        const string _Update_LIBINFO = "LIBINFO_UPDATE";


        /// <summary>
        /// 
        /// </summary>
        /// <param name="DataCaptYM"></param>
        /// <param name="DeptID"></param>
        /// <param name="MenuID"></param>
        /// <returns></returns>
        public stInfo GetDOAA1FormDataByID(int DataCaptYM, string DeptID, string MenuID)
        {
            stInfo info = new stInfo();
            info.DataCaptYM = DataCaptYM;
            info.DeptID = DeptID;
            info.MenuID = string.IsNullOrWhiteSpace(MenuID) ? "DOAA" : MenuID;
            return this.GetEntity<stInfo>(info, _SELECT_DOAA1_INFO);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int Insert(stInfo info)
        {
            return this.InsertAndGetEntityID(info, _Insert_DOAA1_INFO);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public bool Update(stInfo info)
        {
            return this.InsertOrUpdate(info, _Update_DOAA1_INFO);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="DataCaptYM"></param>
        /// <param name="DeptID"></param>
        /// <param name="MenuID"></param>
        /// <returns></returns>
        public stInfo2 GetADIRFormDataByID(int DataCaptYM, string DeptID, string MenuID)
        {
            Dictionary<string, object> sqlParamDictionary = new Dictionary<string, object>();
            sqlParamDictionary.Add("DataCaptYM", DataCaptYM);
            sqlParamDictionary.Add("DeptID", DeptID);
            sqlParamDictionary.Add("MenuID", string.IsNullOrWhiteSpace(MenuID) ? "ADIR" : MenuID);
            IDbCommand command = new SqlCommand().GetCommandWithParameters(sqlParamDictionary, _SELECT_DOAA1_INFO);
            SqlConnection connection = DBConnectionHelper.OpenNewSqlConnection(this.ConnectionString);
            command.Connection = connection;
            stInfo2 stInfo2 = EntityMapper.MapSingle<stInfo2>(command.ExecuteReader());
            DBConnectionHelper.CloseSqlConnection(connection);
            return stInfo2;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="info2"></param>
        /// <returns></returns>
        public bool InsertTostInfo2(stInfo2 info2)
        {
            IDbCommand command = new SqlCommand().GetCommandWithParameters(info2, _Insert_INFO2);
            SqlConnection connection = DBConnectionHelper.OpenNewSqlConnection(this.ConnectionString);            
            command.Connection = connection;
            command.ExecuteNonQuery();
            DBConnectionHelper.CloseSqlConnection(connection);
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info2"></param>
        /// <returns></returns>
        public bool UpdateTostInfo2(stInfo2 info2)
        {
            IDbCommand command = new SqlCommand().GetCommandWithParameters(info2, _Update_INFO2);
            SqlConnection connection = DBConnectionHelper.OpenNewSqlConnection(this.ConnectionString);
            command.Connection = connection;
            command.ExecuteNonQuery();
            DBConnectionHelper.CloseSqlConnection(connection);
            return true;            
        }

        public LibInfo GetLibFormDataByID(int DataCaptYM, string DeptID, string MenuID)
        {
            Dictionary<string, object> sqlParamDictionary = new Dictionary<string, object>();
            sqlParamDictionary.Add("DataCaptYM", DataCaptYM);
            sqlParamDictionary.Add("DeptID", DeptID);
            sqlParamDictionary.Add("MenuID", string.IsNullOrWhiteSpace(MenuID) ? "LIBFORM" : MenuID);
            IDbCommand command = new SqlCommand().GetCommandWithParameters(sqlParamDictionary, _SELECT_DOAA1_INFO);
            SqlConnection connection = DBConnectionHelper.OpenNewSqlConnection(this.ConnectionString);
            command.Connection = connection;
            LibInfo libInfo = EntityMapper.MapSingle<LibInfo>(command.ExecuteReader());
            DBConnectionHelper.CloseSqlConnection(connection);
            return libInfo;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="info2"></param>
        /// <returns></returns>
        public bool InsertToLibInfo(LibInfo libInfo)
        {
            IDbCommand command = new SqlCommand().GetCommandWithParameters(libInfo, _Insert_LIBINFO);
            SqlConnection connection = DBConnectionHelper.OpenNewSqlConnection(this.ConnectionString);
            command.Connection = connection;
            command.ExecuteNonQuery();
            DBConnectionHelper.CloseSqlConnection(connection);
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info2"></param>
        /// <returns></returns>
        public bool UpdateToLibInfo(LibInfo libInfo)
        {
            IDbCommand command = new SqlCommand().GetCommandWithParameters(libInfo, _Update_LIBINFO);
            SqlConnection connection = DBConnectionHelper.OpenNewSqlConnection(this.ConnectionString);
            command.Connection = connection;
            command.ExecuteNonQuery();
            DBConnectionHelper.CloseSqlConnection(connection);
            return true;
        }
    }
}
