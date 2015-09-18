//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// <copyright>
// Copyright 2013 by the Spark Development Network
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
using System;
using System.Collections.Generic;


namespace Rock.Client
{
    /// <summary>
    /// Base client model for Communication that only includes the non-virtual fields. Use this for PUT/POSTs
    /// </summary>
    public partial class CommunicationEntity
    {
        /// <summary />
        public int Id { get; set; }

        /// <summary />
        public string AdditionalMergeFieldsJson { get; set; }

        /// <summary />
        public Guid? ForeignGuid { get; set; }

        /// <summary />
        public string ForeignKey { get; set; }

        /// <summary />
        public DateTime? FutureSendDateTime { get; set; }

        /// <summary />
        public bool IsBulkCommunication { get; set; }

        /// <summary />
        public string MediumDataJson { get; set; }

        /// <summary />
        public int? MediumEntityTypeId { get; set; }

        /// <summary>
        /// If the ModifiedByPersonAliasId and ModifiedDateTime properties are being set manually and should not be overwritten with current time/user when saved, set this value to true
        /// </summary>
        public bool ModifiedAuditValuesAlreadyUpdated { get; set; }

        /// <summary />
        public DateTime? ReviewedDateTime { get; set; }

        /// <summary />
        public string ReviewerNote { get; set; }

        /// <summary />
        public int? ReviewerPersonAliasId { get; set; }

        /// <summary />
        public int? SenderPersonAliasId { get; set; }

        /// <summary />
        public Rock.Client.Enums.CommunicationStatus Status { get; set; }

        /// <summary />
        public string Subject { get; set; }

        /// <summary />
        public Guid Guid { get; set; }

        /// <summary />
        public int? ForeignId { get; set; }

        /// <summary>
        /// Copies the base properties from a source Communication object
        /// </summary>
        /// <param name="source">The source.</param>
        public void CopyPropertiesFrom( Communication source )
        {
            this.Id = source.Id;
            this.AdditionalMergeFieldsJson = source.AdditionalMergeFieldsJson;
            this.ForeignGuid = source.ForeignGuid;
            this.ForeignKey = source.ForeignKey;
            this.FutureSendDateTime = source.FutureSendDateTime;
            this.IsBulkCommunication = source.IsBulkCommunication;
            this.MediumDataJson = source.MediumDataJson;
            this.MediumEntityTypeId = source.MediumEntityTypeId;
            this.ModifiedAuditValuesAlreadyUpdated = source.ModifiedAuditValuesAlreadyUpdated;
            this.ReviewedDateTime = source.ReviewedDateTime;
            this.ReviewerNote = source.ReviewerNote;
            this.ReviewerPersonAliasId = source.ReviewerPersonAliasId;
            this.SenderPersonAliasId = source.SenderPersonAliasId;
            this.Status = source.Status;
            this.Subject = source.Subject;
            this.Guid = source.Guid;
            this.ForeignId = source.ForeignId;

        }
    }

    /// <summary>
    /// Client model for Communication that includes all the fields that are available for GETs. Use this for GETs (use CommunicationEntity for POST/PUTs)
    /// </summary>
    public partial class Communication : CommunicationEntity
    {
        /// <summary />
        public List<string> AdditionalMergeFields { get; set; }

        /// <summary />
        public Dictionary<string, string> MediumData { get; set; }

        /// <summary />
        public EntityType MediumEntityType { get; set; }

        /// <summary />
        public ICollection<CommunicationRecipient> Recipients { get; set; }

        /// <summary />
        public PersonAlias ReviewerPersonAlias { get; set; }

        /// <summary />
        public PersonAlias SenderPersonAlias { get; set; }

        /// <summary />
        public DateTime? CreatedDateTime { get; set; }

        /// <summary />
        public DateTime? ModifiedDateTime { get; set; }

        /// <summary />
        public int? CreatedByPersonAliasId { get; set; }

        /// <summary />
        public int? ModifiedByPersonAliasId { get; set; }

        /// <summary>
        /// NOTE: Attributes are only populated when ?loadAttributes is specified. Options for loadAttributes are true, false, 'simple', 'expanded' 
        /// </summary>
        public Dictionary<string, Rock.Client.Attribute> Attributes { get; set; }

        /// <summary>
        /// NOTE: AttributeValues are only populated when ?loadAttributes is specified. Options for loadAttributes are true, false, 'simple', 'expanded' 
        /// </summary>
        public Dictionary<string, Rock.Client.AttributeValue> AttributeValues { get; set; }
    }
}
