using FluentValidation;
using FluentValidation.Results;
using System.Collections.Generic;
using System.Linq;

namespace EasyCrud.Shared.DomainObjects
{
    public abstract class Entity<TEntity> : AbstractValidator<TEntity>
        where TEntity : class
    {
        protected ValidationResult _validationResult;

        public List<string> Errors { get { return _validationResult?.Errors.Select(error => error.ErrorMessage).ToList(); } }

        protected Entity() { }
        public Entity(long id) 
        {
            Id = id;
        }

        public long Id { get; private set; }

        public abstract bool Validate();
    }
}
