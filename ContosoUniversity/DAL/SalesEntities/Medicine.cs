﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Devart Entity Developer tool using Entity Framework DbContext template.
// Code is generated on: 25/11/2018 12:35:48 م
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace ContosoUniversity.DAL.SalesModel
{

    /// <summary>
    /// There are no comments for ContosoUniversity.DAL.SalesModel.Medicine in the schema.
    /// </summary>
    public partial class Medicine : Item    {

        public Medicine()
        {
            OnCreated();
        }


        #region Properties
    
        /// <summary>
        /// There are no comments for ScentificName in the schema.
        /// </summary>
        public virtual string ScentificName
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for ExpireDate in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual global::System.DateTime ExpireDate
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for MedicalGroup in the schema.
        /// </summary>
        public virtual string MedicalGroup
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for BatchNo in the schema.
        /// </summary>
        public virtual string BatchNo
        {
            get;
            set;
        }


        #endregion
    
        #region Extensibility Method Definitions
        partial void OnCreated();
        #endregion
    }

}
