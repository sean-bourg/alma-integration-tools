﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace AlmaIntergrationTools.Finance
{


    public class OwneredEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("createdBy")]
        public String CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("creationDate")]
        public String CreationDate { get; set; }

        /// <summary>
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("customerId")]
        public String CustomerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("institutionId")]
        public String InstitutionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("libraryId")]
        public String LibraryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("libraryUnitId")]
        public String LibraryUnitId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("modificationDate")]
        public String ModificationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("modifiedBy")]
        public String ModifiedBy { get; set; }

    }
}