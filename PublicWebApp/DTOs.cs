﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicWebApp
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public CustomerDocument DocumentId { get; set; }

        public Customer MapToDomain()
        {
            return new Customer()
            {
                Id = this.Id,
                Name = this.Name,
                Surname = this.Surname,
                Email = this.Email,
                CustomerDocument = this.DocumentId
            };
        }
    }
}
