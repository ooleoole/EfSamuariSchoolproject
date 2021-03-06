﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EfSamuariDomain.Entities;
using SamuraiWEB.ViewModels;

namespace SamuraiWEB.Utilities.Mappers.Interfaces
{
    public interface IViewModelToModelMapper
    {
        Samurai SamuraiViewModelToSamurai(SamuraiViewModel samuraiViewModel);
        IEnumerable<Samurai> SamuraiViewModelsToSamurais(IEnumerable<SamuraiViewModel> samuraiViewModels);
        Samurai CreateSamuraiViewModelToSamurai(CreateSamuriaViewModel createSamuriaViewModel);



    }
}
