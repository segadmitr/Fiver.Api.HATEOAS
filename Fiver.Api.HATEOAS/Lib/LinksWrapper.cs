﻿using System.Collections.Generic;

namespace Fiver.Api.HATEOAS.Lib
{
    public class LinksWrapper<T>
    {
        public T Value { get; set; }
        public List<LinkInfo> Links { get; set; }
    }
}
