using System;

namespace Account.Domain.BaseProperties
{
    public abstract class TEntity
    {
        int? _requestHashCode;
        Guid _Id;

        public virtual Guid Id
        {
            get
            {
                return _Id;
            }
            protected set
            {
                _Id = value;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is TEntity))
                return false;

            if (Object.ReferenceEquals(this, obj))
                return true;

            if (this.GetType() != obj.GetType())
                return false;

            TEntity item = (TEntity)obj;

            return item.Id == this.Id;
        }

        public override int GetHashCode()
        {
            if (!_requestHashCode.HasValue)
                _requestHashCode = this.Id.GetHashCode() ^ 31;

            return _requestHashCode.Value;
        }

        public static bool operator == (TEntity left, TEntity right)
        {
            if (Object.Equals(left, null))
                return (Object.Equals(right, null)) ? true : false;
            else
                return left.Equals(right);
        }

        public static bool operator != (TEntity left, TEntity right)
        {
            return !(left == right);
        }
    }
}
