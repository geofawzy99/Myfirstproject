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
    /// There are no comments for ContosoUniversity.DAL.SalesModel.SUV in the schema.
    /// </summary>
    public partial class SUV : Car    {

        public SUV()
        {
            OnCreated();
        }


        #region Properties
    
        /// <summary>
        /// There are no comments for SuvType in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual int SuvType
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
