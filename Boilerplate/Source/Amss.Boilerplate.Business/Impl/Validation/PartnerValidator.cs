﻿namespace Amss.Boilerplate.Business.Impl.Validation
{
    using Amss.Boilerplate.Data;
    using Amss.Boilerplate.Data.Specifications;
    using Amss.Boilerplate.Persistence;

    using FluentValidation;

    internal class PartnerValidator : AbstractValidator<PartnerEntity>
    {
        public PartnerValidator(IRepository repository)
        {
            this.RuleFor(i => i.Name).NotEmpty().Length(1, MetadataInfo.StringNormal)
                .Uniqness(repository, new PartnerUniqness());
        }
    }
}