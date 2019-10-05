﻿using API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Domain.Services.Communication
{
    /// <summary>
    /// Refactor to generic type
    /// </summary>
    public class SaveCategoryResponse : BaseResponse
    {
        public Category Category { get; private set; }
        private SaveCategoryResponse(bool success, string message, Category category) : base(success, message)
        {
            Category = category;
        }
        public SaveCategoryResponse(Category category) : this(true, string.Empty, category)
        { }
        public SaveCategoryResponse(string message) : this(false, message, null)
        { }
    }
}
