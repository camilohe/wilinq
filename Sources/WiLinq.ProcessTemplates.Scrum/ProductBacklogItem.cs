using System;
using WiLinq.LinqProvider;

namespace WiLinq.ProcessTemplates.Scrum
{
    [WorkItemType("Product Backlog Item")]
    public class ProductBacklogItem : GenericWorkItem {
    
        [Field("Microsoft.VSTS.Common.AcceptanceCriteria")]
        public virtual string AcceptanceCriteria {
            get => GetRefField<string>("Microsoft.VSTS.Common.AcceptanceCriteria");
            set => SetRefField("Microsoft.VSTS.Common.AcceptanceCriteria", value);
        }
    
        [Field("System.AuthorizedAs")]
        public virtual string AuthorizedAs => GetRefField<string>("System.AuthorizedAs");

        [Field("System.AuthorizedDate")]
        public virtual DateTime? AuthorizedDate => GetStructField<DateTime>("System.AuthorizedDate");

        [Field("Microsoft.VSTS.Common.BacklogPriority")]
        public virtual double? BacklogPriority {
            get => GetStructField<double>("Microsoft.VSTS.Common.BacklogPriority");
            set => SetStructField("Microsoft.VSTS.Common.BacklogPriority", value);
        }
    
        [Field("System.BoardColumn")]
        public virtual string BoardColumn => GetRefField<string>("System.BoardColumn");

        [Field("System.BoardColumnDone")]
        public virtual bool? BoardColumnDone => GetStructField<bool>("System.BoardColumnDone");

        [Field("System.BoardLane")]
        public virtual string BoardLane => GetRefField<string>("System.BoardLane");

        /// <summary>The business value for the customer when the backlog item is released</summary>
        [Field("Microsoft.VSTS.Common.BusinessValue")]
        public virtual int? BusinessValue {
            get => GetStructField<int>("Microsoft.VSTS.Common.BusinessValue");
            set => SetStructField("Microsoft.VSTS.Common.BusinessValue", value);
        }
    
        [Field("Microsoft.VSTS.Common.ClosedDate")]
        public virtual DateTime? ClosedDate {
            get => GetStructField<DateTime>("Microsoft.VSTS.Common.ClosedDate");
            set => SetStructField("Microsoft.VSTS.Common.ClosedDate", value);
        }
    
        /// <summary>The estimated effort to implemented the backlog item</summary>
        [Field("Microsoft.VSTS.Scheduling.Effort")]
        public virtual double? Effort {
            get => GetStructField<double>("Microsoft.VSTS.Scheduling.Effort");
            set => SetStructField("Microsoft.VSTS.Scheduling.Effort", value);
        }
    
        [Field("System.History")]
        public virtual string History {
            get => GetRefField<string>("System.History");
            set => SetRefField("System.History", value);
        }
    
        [Field("Microsoft.VSTS.Build.IntegrationBuild")]
        public virtual string IntegrationBuild {
            get => GetRefField<string>("Microsoft.VSTS.Build.IntegrationBuild");
            set => SetRefField("Microsoft.VSTS.Build.IntegrationBuild", value);
        }
    
        /// <summary>Priority for completing the backlog item, based on business goals</summary>
        [Field("Microsoft.VSTS.Common.Priority")]
        public virtual int? Priority {
            get => GetStructField<int>("Microsoft.VSTS.Common.Priority");
            set => SetStructField("Microsoft.VSTS.Common.Priority", value);
        }
    
        [Field("System.RevisedDate")]
        public virtual DateTime? RevisedDate => GetStructField<DateTime>("System.RevisedDate");

        [Field("System.Tags")]
        public virtual string Tags {
            get => GetRefField<string>("System.Tags");
            set => SetRefField("System.Tags", value);
        }
    
        /// <summary>Business = delivers value to a user or another system; Architectural = work to support other stories or components</summary>
        [Field("Microsoft.VSTS.Common.ValueArea")]
        public virtual string ValueArea {
            get => GetRefField<string>("Microsoft.VSTS.Common.ValueArea");
            set => SetRefField("Microsoft.VSTS.Common.ValueArea", value);
        }
    
        [Field("System.Watermark")]
        public virtual int? Watermark => GetStructField<int>("System.Watermark");
    }
}