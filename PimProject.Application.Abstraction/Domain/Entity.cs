namespace PimProject.Application.Abstraction.Domain
{
    public abstract class Entity 
    {

        private int? _requestedHashCode;

        private string _id;

        public virtual string Id
        {
            get
            {
                return _id;
            }
            protected set
            {
                _id = value;
            }
        }

        public Entity(string id)
        {
            _id = id;
        }

        public Entity()
        {
            _id = Guid.NewGuid().ToString();
        }

        public bool IsTransient()
        {
            return Id == null;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Entity))
            {
                return false;
            }

            if (this == obj)
            {
                return true;
            }

            if (GetType() != obj.GetType())
            {
                return false;
            }

            Entity entity = (Entity)obj;
            if (entity.IsTransient() || IsTransient())
            {
                return false;
            }

            return entity.Id == Id;
        }

        public override int GetHashCode()
        {
            if (!IsTransient())
            {
                if (!_requestedHashCode.HasValue)
                {
                    _requestedHashCode = Id.GetHashCode() ^ 0x1F;
                }

                return _requestedHashCode.Value;
            }

            return base.GetHashCode();
        }

        public static bool operator ==(Entity left, Entity right)
        {
            if (object.Equals(left, null))
            {
                return object.Equals(right, null) ? true : false;
            }

            return left.Equals(right);
        }

        public static bool operator !=(Entity left, Entity right)
        {
            return !(left == right);
        }
    }
}
