/*
 * Swagger Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;
using IO.Swagger.Security;
using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class AnotherFakeApiController : ControllerBase
    { 
        /// <summary>
        /// To test special tags
        /// </summary>
        /// <remarks>To test special tags</remarks>
        /// <param name="body">client model</param>
        /// <response code="200">successful operation</response>
        [HttpPatch]
        [Route("/v3/another-fake/dummy")]
        [ValidateModelState]
        [SwaggerOperation("TestSpecialTags")]
        [SwaggerResponse(statusCode: 200, type: typeof(Client), description: "successful operation")]
        public virtual IActionResult TestSpecialTags([FromBody]Client body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Client));
            string exampleJson = null;
            exampleJson = "{\n  \"client\" : \"client\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Client>(exampleJson)
                        : default(Client);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}