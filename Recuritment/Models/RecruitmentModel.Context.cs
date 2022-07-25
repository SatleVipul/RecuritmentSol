﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Recuritment.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class RecruitmentDbEntities1 : DbContext
    {
        public RecruitmentDbEntities1()
            : base("name=RecruitmentDbEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_CandidateMaster> tb_CandidateMaster { get; set; }
    
        public virtual int DeleteByID(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteByID", iDParameter);
        }
    
        public virtual ObjectResult<GetByID_Result> GetByID(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetByID_Result>("GetByID", iDParameter);
        }
    
        public virtual int InsertData(string candidateName, Nullable<System.DateTime> dateOfBirth, string discription, string skills, Nullable<bool> isdeleted, Nullable<int> created, Nullable<System.DateTime> createdOn)
        {
            var candidateNameParameter = candidateName != null ?
                new ObjectParameter("CandidateName", candidateName) :
                new ObjectParameter("CandidateName", typeof(string));
    
            var dateOfBirthParameter = dateOfBirth.HasValue ?
                new ObjectParameter("DateOfBirth", dateOfBirth) :
                new ObjectParameter("DateOfBirth", typeof(System.DateTime));
    
            var discriptionParameter = discription != null ?
                new ObjectParameter("Discription", discription) :
                new ObjectParameter("Discription", typeof(string));
    
            var skillsParameter = skills != null ?
                new ObjectParameter("Skills", skills) :
                new ObjectParameter("Skills", typeof(string));
    
            var isdeletedParameter = isdeleted.HasValue ?
                new ObjectParameter("Isdeleted", isdeleted) :
                new ObjectParameter("Isdeleted", typeof(bool));
    
            var createdParameter = created.HasValue ?
                new ObjectParameter("Created", created) :
                new ObjectParameter("Created", typeof(int));
    
            var createdOnParameter = createdOn.HasValue ?
                new ObjectParameter("CreatedOn", createdOn) :
                new ObjectParameter("CreatedOn", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertData", candidateNameParameter, dateOfBirthParameter, discriptionParameter, skillsParameter, isdeletedParameter, createdParameter, createdOnParameter);
        }
    
        public virtual ObjectResult<RetriveAll_Result> RetriveAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RetriveAll_Result>("RetriveAll");
        }
    
        public virtual int UpdateData(Nullable<int> id, string candidateName, Nullable<System.DateTime> dateOfBirth, string discription, string skills, Nullable<bool> isdeleted, Nullable<int> created, Nullable<System.DateTime> createdOn, Nullable<int> modified, Nullable<System.DateTime> modifiedOn)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var candidateNameParameter = candidateName != null ?
                new ObjectParameter("CandidateName", candidateName) :
                new ObjectParameter("CandidateName", typeof(string));
    
            var dateOfBirthParameter = dateOfBirth.HasValue ?
                new ObjectParameter("DateOfBirth", dateOfBirth) :
                new ObjectParameter("DateOfBirth", typeof(System.DateTime));
    
            var discriptionParameter = discription != null ?
                new ObjectParameter("Discription", discription) :
                new ObjectParameter("Discription", typeof(string));
    
            var skillsParameter = skills != null ?
                new ObjectParameter("Skills", skills) :
                new ObjectParameter("Skills", typeof(string));
    
            var isdeletedParameter = isdeleted.HasValue ?
                new ObjectParameter("Isdeleted", isdeleted) :
                new ObjectParameter("Isdeleted", typeof(bool));
    
            var createdParameter = created.HasValue ?
                new ObjectParameter("Created", created) :
                new ObjectParameter("Created", typeof(int));
    
            var createdOnParameter = createdOn.HasValue ?
                new ObjectParameter("CreatedOn", createdOn) :
                new ObjectParameter("CreatedOn", typeof(System.DateTime));
    
            var modifiedParameter = modified.HasValue ?
                new ObjectParameter("Modified", modified) :
                new ObjectParameter("Modified", typeof(int));
    
            var modifiedOnParameter = modifiedOn.HasValue ?
                new ObjectParameter("ModifiedOn", modifiedOn) :
                new ObjectParameter("ModifiedOn", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateData", idParameter, candidateNameParameter, dateOfBirthParameter, discriptionParameter, skillsParameter, isdeletedParameter, createdParameter, createdOnParameter, modifiedParameter, modifiedOnParameter);
        }
    }
}
