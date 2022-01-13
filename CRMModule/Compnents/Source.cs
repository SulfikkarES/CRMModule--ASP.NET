#region Copyright 
//
// All rights are reserved. Reproduction or transmission in whole or in part, 
// in any form or by any means, electronic, mechanical or otherwise, is
// prohibited without the prior written consent of the copyright owner.
//
// Filename        : Sourses.cs    
// Purpose         : To create Sources object 

// Creation Date   : 10-01-2022
// Author          : Sulfikkar E S
//
// Change History  :
// Changed by      :              
// Date            : 
// Purpose         :
//
#endregion

#region Name spaces
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
#endregion 

namespace CRMModule.Compnents
{
    public class Source
    {
        #region Public Properties
        /// <summary>
        /// Get Source Id
        /// </summary>
        public int SourceId
        {
            get;
            set;
        }

        /// <summary>
        /// Get Source Name
        /// </summary>
        public string SourceName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Source created date
        /// </summary>
        public DateTime CreatedDate
        {
            get;
            set;
        }

        /// <summary>
        /// Get the Source Created By
        /// </summary>
        public string CreatedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Source Modified date
        /// </summary>
        public DateTime ModifiedDate
        {
            get;
            set;
        }


        /// <summary>
        /// Get the source Modified By
        /// </summary>
        public string ModifiedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Active status
        /// </summary>
        public bool IsActive
        {
            get;
            set;
        }
        #endregion Public Properties

        #region Public Methods

        #region Get All Source
        /// <summary>
        /// Retrieves all Source
        /// </summary>
        /// <returns>data's of Source</returns>
        public DataTable GetAllSource()
        {
           
            SqlDataAdapter daSource;
            
            string SelectQuery = "procSourceSelect";

            SqlConnection catdbCon = null;
            DataSet dsSource = new DataSet();

            try
            {
               
                catdbCon = CRMModuleDBConnection.GetConnection();
                catdbCon.Open();

                daSource = new SqlDataAdapter(SelectQuery, catdbCon);
                daSource.Fill(dsSource);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                catdbCon.Close();
            }
            return dsSource.Tables[0];
        }
        #endregion


        #region Insert Source
        /// <summary>
        /// Insert a Source to the Source table
        /// </summary>
        /// <returns>numberOfRowsAffected</returns>
        public int InsertASource()
        {
            int numberOfRowsAffected;
            string insertQuery = "prcsourceinsert";

            SqlConnection catdbCon = null;

            SqlCommand cmdInsertSource = null;

            try
            {
                catdbCon = CRMModuleDBConnection.GetConnection();
                catdbCon.Open();

                cmdInsertSource = new SqlCommand(insertQuery, catdbCon);

                cmdInsertSource.Parameters.AddWithValue("@name", this.SourceName);
                cmdInsertSource.Parameters.AddWithValue("@createddate", this.CreatedDate);
                cmdInsertSource.Parameters.AddWithValue("@createdby", this.CreatedBy);
                cmdInsertSource.Parameters.AddWithValue("@modifieddate", this.ModifiedDate);
                cmdInsertSource.Parameters.AddWithValue("@modifiedby", this.ModifiedBy);
                cmdInsertSource.CommandType = CommandType.StoredProcedure;
                numberOfRowsAffected = cmdInsertSource.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                catdbCon.Close();
            }

            return numberOfRowsAffected;
        }
        #endregion Source

        #region edit Source
        /// <summary>
        /// Edit a Source in the Source table
        /// </summary>
        /// <returns>numberOfRowsAffected</returns>
        public int EditASource()
        {
            int numberOfRowsAffected;
            string editQuery = "prcsourceEdit";
            SqlConnection catdbCon = null;

            SqlCommand cmdEditSource = null;

            try
            {
                catdbCon = CRMModuleDBConnection.GetConnection();
                catdbCon.Open();

                cmdEditSource = new SqlCommand(editQuery, catdbCon);

                cmdEditSource.Parameters.AddWithValue("@id", this.SourceId); 
                cmdEditSource.Parameters.AddWithValue("@name", this.SourceName);
                cmdEditSource.Parameters.AddWithValue("@createddate", this.CreatedDate); 
                cmdEditSource.Parameters.AddWithValue("@createdby", this.CreatedBy);
                cmdEditSource.Parameters.AddWithValue("@modifieddate", this.ModifiedDate);
                cmdEditSource.Parameters.AddWithValue("@modifiedby", this.ModifiedBy);
                cmdEditSource.CommandType = CommandType.StoredProcedure;
                numberOfRowsAffected = cmdEditSource.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                catdbCon.Close();
            }
            return numberOfRowsAffected;
        }
        #endregion edit Source

        #region delete Source
        /// <summary>
        /// Delete a Source from the Source table
        /// </summary>
        /// <returns>numberOfRowsAffected</returns>
        public int DeleteASource(int SourceId)
        {
            int numberOfRowsAffected;
            string deleteQuery = "procSourceDelete";
            SqlConnection catdbCon = null;

            SqlCommand cmddeleteSource = null;

            try
            {
                catdbCon = CRMModuleDBConnection.GetConnection();
                catdbCon.Open();

                cmddeleteSource = new SqlCommand(deleteQuery, catdbCon);

                cmddeleteSource.Parameters.AddWithValue("@id", SourceId); 
                cmddeleteSource.CommandType = CommandType.StoredProcedure;
                numberOfRowsAffected = cmddeleteSource.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                catdbCon.Close();
            }

            return numberOfRowsAffected;
        }
        #endregion delete Source
        #endregion Public metords

    }
}