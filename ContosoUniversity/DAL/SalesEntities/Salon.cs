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
    /// There are no comments for ContosoUniversity.DAL.SalesModel.Salon in the schema.
    /// </summary>
    public partial class Salon : Car    {

        public Salon()
        {
            OnCreated();
        }


        #region Properties
    
        /// <summary>
        /// There are no comments for SalonType in the schema.
        /// </summary>
        public virtual int? SalonType
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for description in the schema.
        /// </summary>
        public virtual string description
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
