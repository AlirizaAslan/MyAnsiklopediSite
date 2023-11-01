namespace Site.Core.Entities;

public abstract class EntityBase:IEntityBase
    {
        public virtual int Id { get; set; }

        public virtual string CreatedBy { get; set; }

        public virtual string ModifiedBy { get; set; }
        public virtual string DeletedBy { get; set; }

        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
        public virtual DateTime? DeletedDate { get; set; }
        public virtual bool isDeleted { get; set; }



    }
