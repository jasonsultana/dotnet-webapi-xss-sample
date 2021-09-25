using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplicationCore.Models;

namespace WebApplicationCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class XssController : ControllerBase
    {
        private static SimpleModel _simple;
        private static NestedModel _nested;
        private static CollectionModel _collection;
        
        [HttpGet]
        [Route("simple")]
        public SimpleModel GetSimple() => _simple;

        [HttpPost]
        [Route("simple")]
        public void SetSimple([FromBody]SimpleModel simple)
        {
            _simple = simple;
        }

        [HttpGet]
        [Route("nested")]
        public NestedModel GetNested() => _nested;

        [HttpPost]
        [Route("nested")]
        public void SetNested([FromBody] NestedModel nested)
        {
            _nested = nested;
        }

        [HttpGet]
        [Route("collection")]
        public CollectionModel GetCollection() => _collection;

        [HttpPost]
        [Route("collection")]
        public void SetCollecttion([FromBody] CollectionModel collection)
        {
            _collection = collection;
        }
    }
}