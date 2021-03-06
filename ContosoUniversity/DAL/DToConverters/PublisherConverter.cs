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
using System.Linq;

namespace ContosoUniversity.DAL.SalesModel.Dto
{

    public static partial class PublisherConverter
    {

        public static PublisherDto ToDto(this ContosoUniversity.DAL.SalesModel.Publisher source)
        {
            return source.ToDtoWithRelated(0);
        }

        public static PublisherDto ToDtoWithRelated(this ContosoUniversity.DAL.SalesModel.Publisher source, int level)
        {
            if (source == null)
              return null;

            var target = new PublisherDto();

            // Properties
            target.Id = source.Id;
            target.Name = source.Name;

            // Navigation Properties
            if (level > 0) {
              target.Books = source.Books.ToDtosWithRelated(level - 1);
            }

            // User-defined partial method
            OnDtoCreating(source, target);

            return target;
        }

        public static ContosoUniversity.DAL.SalesModel.Publisher ToEntity(this PublisherDto source)
        {
            if (source == null)
              return null;

            var target = new ContosoUniversity.DAL.SalesModel.Publisher();

            // Properties
            target.Id = source.Id;
            target.Name = source.Name;

            // User-defined partial method
            OnEntityCreating(source, target);

            return target;
        }

        public static List<PublisherDto> ToDtos(this IEnumerable<ContosoUniversity.DAL.SalesModel.Publisher> source)
        {
            if (source == null)
              return null;

            var target = source
              .Select(src => src.ToDto())
              .ToList();

            return target;
        }

        public static List<PublisherDto> ToDtosWithRelated(this IEnumerable<ContosoUniversity.DAL.SalesModel.Publisher> source, int level)
        {
            if (source == null)
              return null;

            var target = source
              .Select(src => src.ToDtoWithRelated(level))
              .ToList();

            return target;
        }

        public static List<ContosoUniversity.DAL.SalesModel.Publisher> ToEntities(this IEnumerable<PublisherDto> source)
        {
            if (source == null)
              return null;

            var target = source
              .Select(src => src.ToEntity())
              .ToList();

            return target;
        }

        static partial void OnDtoCreating(ContosoUniversity.DAL.SalesModel.Publisher source, PublisherDto target);

        static partial void OnEntityCreating(PublisherDto source, ContosoUniversity.DAL.SalesModel.Publisher target);

    }

}
