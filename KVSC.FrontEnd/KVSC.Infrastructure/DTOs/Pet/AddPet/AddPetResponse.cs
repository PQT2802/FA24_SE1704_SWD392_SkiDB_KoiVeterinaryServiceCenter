﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Pet.AddPet
{
    public class AddPetResponse
    {
        public Extensions<AddPetData> Extensions { get; set; }
    }

    public class AddPetData
    {
        public Guid Id { get; set; }
    }
}
