#region Copyright 
//
// All rights are reserved. Reproduction or transmission in whole or in part, 
// in any form or by any means, electronic, mechanical or otherwise, is
// prohibited without the prior written consent of the copyright owner.
//
// Filename        : CRMModuleDBConnection.cs
// Purpose         : To define the connection properties and methods
// Creation Date   : 10-01-2022
// Author          : Sulfikkar E S
//
// Change History  :
// Changed by      :              
// Date            : 
// Purpose         :
//
#endregion Copyright EazyLearn

#region Name spaces
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
#endregion namespaces

namespace CRMModule.Compnents
{
    public class CRMModuleDBConnection
    {
        #region Public Static Properties

        /// <summary>
        /// Connection string
        /// </summary>
        public static string bssConnectionString
        {
            get;
            set;
        }
        #endregion Public Static Properties

        #region Public Static Methods

        /// <summary>
        /// To create database object for database connection
        /// </summary>
        /// <returns>Connection object</returns>

        public static SqlConnection GetConnection()
        {
            SqlConnection conObj;
             bssConnectionString = ConfigurationManager.ConnectionStrings["CRMModule"].ConnectionString; 
            conObj = new SqlConnection(bssConnectionString);

            return conObj;
        }
        #endregion

    }
}