﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Devart Entity Developer tool using Data Transfer Object template.
// Code is generated on: 25/11/2018 12:35:51 م
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ContosoUniversity.DAL.SalesModel.Dto
{

    [DataContractAttribute(IsReference=true)]
    public partial class CarDto
    {
        #region Constructors
  
        public CarDto() {
        }

        public CarDto(int id, int? manufactureYear, int? brandId, string modelName) {

          this.Id = id;
          this.ManufactureYear = manufactureYear;
          this.BrandId = brandId;
          this.ModelName = modelName;
        }

        #endregion

        #region Properties

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int? ManufactureYear { get; set; }

        [DataMember]
        public int? BrandId { get; set; }

        [DataMember]
        public string ModelName { get; set; }

        #endregion
    }

}