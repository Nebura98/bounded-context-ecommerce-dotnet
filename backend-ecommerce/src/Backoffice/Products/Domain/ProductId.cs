﻿using System.ComponentModel.DataAnnotations;
using backend_ecommerce.Src.Shared.Domain;

namespace backend_ecommerce.src.Backoffice.Products.Domain
{
    public class ProductId : ValueObject
    {
        [Required]
        public Guid Id { get; private set; }

        public ProductId(Guid id)
        {
            Id = id;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Id;
        }
    }
}
