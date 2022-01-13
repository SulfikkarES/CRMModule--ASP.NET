#region Copyright
//
// All rights are reserved. Reproduction or transmission in whole or in part, 
// in any form or by any means, electronic, mechanical or otherwise, is
// prohibited without the prior written consent of the copyright owner.
//
// Filename        : Customer.cs    
// Purpose         : To create Customer object 

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
#endregion NameSpaces

namespace CRMModule.Compnents
{
    public class Custemers
    {
        #region Public Properties
        /// <summary>
        /// Get Customer Id
        /// </summary>
        public int CustomerId
        {
            get;
            set;
        }

        /// <summary>
        /// Get First Name
        /// </summary>
        public string FirstName
        {
            get;
            set;
        }

        /// <summary>
        /// Get Last Name
        /// </summary>
        public string LastName
        {
            get;
            set;
        }

        /// <summary>
        /// Get Email Address
        /// </summary>
        public string EmailAddress
        {
            get;
            set;
        }

        /// <summary>
        /// Get Phone Number
        /// </summary>
        public int PhoneNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Get Designation
        /// </summary>
        public string Designation
        {
            get;
            set;
        }

        /// <summary>
        /// Get Company
        /// </summary>
        public string Company
        {
            get;
            set;
        }

        /// <summary>
        /// Get City
        /// </summary>
        public string City
        {
            get;
            set;
        }

        /// <summary>
        /// Get College Name
        /// </summary>
        public string CollegeName
        {
            get;
            set;
        }

        /// <summary>
        /// Get State
        /// </summary>
        public string State
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Customer created date
        /// </summary>
        public DateTime CreatedDate
        {
            get;
            set;
        }

        /// <summary>
        /// Get the Customer Created By
        /// </summary>
        public string CreatedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Customer Modified date
        /// </summary>
        public DateTime ModifiedDate
        {
            get;
            set;
        }


        /// <summary>
        /// Get the Customer Modified By
        /// </summary>
        public string ModifiedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Get Source
        /// </summary>
        public string Source
        {
            get;
            set;
        }

        /// <summary>
        /// Get Source Id
        /// </summary>
        public int SourceId
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

        #region Get All Customers
        /// <summary>
        /// Retrieves all Customers
        /// </summary>
        /// <returns>data's of Customers</returns>
        public DataTable GetAllCustomers()
        {
            SqlDataAdapter daCustomer;
            string SelectQuery = "procCustomerSelect";

            SqlConnection catdbCon = null;
            DataSet dsCustomer = new DataSet();

            try
            {
                catdbCon = CRMModuleDBConnection.GetConnection();
                catdbCon.Open();

                daCustomer = new SqlDataAdapter(SelectQuery, catdbCon);
                daCustomer.Fill(dsCustomer);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                catdbCon.Close();
            }
            return dsCustomer.Tables[0];
        }
        #endregion


        #region Insert customer
        /// <summary>
        /// Insert a Customer to the Customer table
        /// </summary>
        /// <returns>numberOfRowsAffected</returns>
        public int InsertACustomer()
        {
            int numberOfRowsAffected;
            string insertQuery = "procCustomerinsert";

            SqlConnection catdbCon = null;

            SqlCommand cmdInsertCustomer = null;

            try
            {
                catdbCon = CRMModuleDBConnection.GetConnection();
                catdbCon.Open();

                cmdInsertCustomer = new SqlCommand(insertQuery, catdbCon);

                cmdInsertCustomer.Parameters.AddWithValue("@id", this.CustomerId);
                cmdInsertCustomer.Parameters.AddWithValue("@firstname", this.FirstName);
                cmdInsertCustomer.Parameters.AddWithValue("@lastname", this.LastName);
                cmdInsertCustomer.Parameters.AddWithValue("@email", this.EmailAddress);
                cmdInsertCustomer.Parameters.AddWithValue("@phonenumber", this.PhoneNumber);
                cmdInsertCustomer.Parameters.AddWithValue("@designation", this.Designation);
                cmdInsertCustomer.Parameters.AddWithValue("@company", this.Company);
                cmdInsertCustomer.Parameters.AddWithValue("@city", this.City);
                cmdInsertCustomer.Parameters.AddWithValue("@collegename", this.CollegeName);
                cmdInsertCustomer.Parameters.AddWithValue("@state", this.State);
                cmdInsertCustomer.Parameters.AddWithValue("@createddate", this.CreatedDate);
                cmdInsertCustomer.Parameters.AddWithValue("@createdby", this.CreatedBy);
                cmdInsertCustomer.Parameters.AddWithValue("@modifieddate", this.ModifiedDate);
                cmdInsertCustomer.Parameters.AddWithValue("@modifiedby", this.ModifiedBy);
                cmdInsertCustomer.Parameters.AddWithValue("@sid", this.SourceId);
                cmdInsertCustomer.CommandType = CommandType.StoredProcedure;
                numberOfRowsAffected = cmdInsertCustomer.ExecuteNonQuery();
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
        #endregion Customer

        #region edit Customer
        /// <summary>
        /// Edit a Customer in the Customer table
        /// </summary>
        /// <returns>numberOfRowsAffected</returns>
        public int EditACustomer()
        {
            int numberOfRowsAffected;
            string editQuery = "prcCuustomerEdit";
            SqlConnection catdbCon = null;

            SqlCommand cmdEditCustomer = null;

            try
            {
                catdbCon = CRMModuleDBConnection.GetConnection();
                catdbCon.Open();

                cmdEditCustomer = new SqlCommand(editQuery, catdbCon);

                cmdEditCustomer.Parameters.AddWithValue("@id", this.CustomerId);
                cmdEditCustomer.Parameters.AddWithValue("@firstname", this.FirstName);
                cmdEditCustomer.Parameters.AddWithValue("@lastname", this.LastName);
                cmdEditCustomer.Parameters.AddWithValue("@email", this.EmailAddress);
                cmdEditCustomer.Parameters.AddWithValue("@phonenumber", this.PhoneNumber);
                cmdEditCustomer.Parameters.AddWithValue("@designation", this.Designation );
                cmdEditCustomer.Parameters.AddWithValue("@company", this.Company);
                cmdEditCustomer.Parameters.AddWithValue("@city", this.City);
                cmdEditCustomer.Parameters.AddWithValue("@collegename", this.CollegeName);
                cmdEditCustomer.Parameters.AddWithValue("@state", this.State);
                cmdEditCustomer.Parameters.AddWithValue("@createddate", this.CreatedDate);
                cmdEditCustomer.Parameters.AddWithValue("@createdby", this.CreatedBy);
                cmdEditCustomer.Parameters.AddWithValue("@modifieddate", this.ModifiedDate);
                cmdEditCustomer.Parameters.AddWithValue("@modifiedby", this.ModifiedBy);
                cmdEditCustomer.Parameters.AddWithValue("@sid", this.SourceId);
                cmdEditCustomer.CommandType = CommandType.StoredProcedure;
                numberOfRowsAffected = cmdEditCustomer.ExecuteNonQuery();
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
        #endregion edit Customer

        #region delete Customer
        /// <summary>
        /// Delete a Customer from the Customer table
        /// </summary>
        /// <returns>numberOfRowsAffected</returns>
        public int DeleteACustomer(int catgryId)
        {
            int numberOfRowsAffected;
            string deleteQuery = "procCustomerDelete";
            SqlConnection catdbCon = null;

            SqlCommand cmddeleteCustomer = null;

            try
            {
                catdbCon = CRMModuleDBConnection.GetConnection();
                catdbCon.Open();

                cmddeleteCustomer = new SqlCommand(deleteQuery, catdbCon);

                cmddeleteCustomer.Parameters.AddWithValue("@id", catgryId); 
                cmddeleteCustomer.CommandType = CommandType.StoredProcedure;
                numberOfRowsAffected = cmddeleteCustomer.ExecuteNonQuery();
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
        #endregion delete Customer
        #endregion Public metords


    }
}